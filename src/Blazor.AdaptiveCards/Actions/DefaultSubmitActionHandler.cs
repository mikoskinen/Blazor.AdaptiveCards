using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Blazor.AdaptiveCards
{
    public class DefaultSubmitActionHandler : ISubmitActionHandler
    {
        private readonly ILogger<DefaultSubmitActionHandler> _logger;

        public DefaultSubmitActionHandler(ILogger<DefaultSubmitActionHandler> logger)
        {
            _logger = logger;
        }

        public async Task Handle(SubmitEventArgs eventArgs, object handler, object model)
        {
            try
            {
                if (eventArgs == null)
                {
                    throw new ArgumentNullException(nameof(eventArgs));
                }

                if (handler == null)
                {
                    throw new ArgumentNullException(nameof(handler));
                }

                // TODO: Cache reflection
                var handlersMethods = handler.GetType().GetMethods().Select(x => x.Name).ToList();
                var actionName = eventArgs.Action;

                string handlerMethod = null;

                if (handlersMethods.Contains(actionName))
                {
                    handlerMethod = actionName;
                }
                else if (handlersMethods.Contains("Submit"))
                {
                    handlerMethod = "Submit";
                }

                if (string.IsNullOrEmpty(handlerMethod))
                {
                    throw new SubmitActionException("Couldn't locate submit handler method", eventArgs, handler);
                }

                await RunSubmit(handlerMethod, handler, eventArgs, model);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Failed to handle submit action {eventArgs} with {handler}.", eventArgs, handler);

                throw new SubmitActionException("Failed to handle submit action", eventArgs, handler, e);
            }
        }

        private async Task RunSubmit(string submitMethodName, object handler, SubmitEventArgs eventArgs, object model)
        {
            try
            {
                // TODO: Cache reflection

                var method = handler.GetType().GetMethod(submitMethodName);
                var methodParameters = method.GetParameters().ToList();

                if (methodParameters.Any() != true)
                {
                    var t = (Task)method.Invoke(handler, null);
                    await t;

                    return;
                }

                if (methodParameters.Count == 1 && typeof(SubmitEventArgs).IsAssignableFrom(methodParameters.First().ParameterType))
                {
                    var t = (Task)method.Invoke(handler, new[] { eventArgs });
                    await t;

                    return;
                }

                if (model != null && methodParameters.Count == 1 && model.GetType().IsAssignableFrom(methodParameters.First().ParameterType))
                {
                    var t = (Task)method.Invoke(handler, new[] { model });
                    await t;

                    return;
                }

                var arguments = new List<object>();
                
                foreach (var methodParameter in methodParameters)
                {
                    if (typeof(SubmitEventArgs).IsAssignableFrom(methodParameter.ParameterType))
                    {
                        arguments.Add(eventArgs);
                        continue;
                    }

                    if (model != null && model.GetType().IsAssignableFrom(methodParameter.ParameterType))
                    {
                        arguments.Add(model);
                        continue;
                    }

                    if (eventArgs.Data != null && !IsSimpleType(methodParameter.ParameterType))
                    {
                        var json = System.Text.Json.JsonSerializer.Serialize(eventArgs.Data);
                        var obj = System.Text.Json.JsonSerializer.Deserialize(json, methodParameter.ParameterType);

                        arguments.Add(obj);
                        continue;
                    }
                    
                    if (eventArgs.Data != null && IsSimpleType(methodParameter.ParameterType))
                    {
                        if (eventArgs.Data.ContainsKey(methodParameter.Name))
                        {
                            var valueJson = System.Text.Json.JsonSerializer.Serialize(eventArgs.Data[methodParameter.Name]);
                            var value = System.Text.Json.JsonSerializer.Deserialize(valueJson, methodParameter.ParameterType);

                            arguments.Add(value);

                            continue;
                        }

                    }

                    arguments.Add(null);
                }

                var tOut = (Task)method.Invoke(handler, arguments.ToArray());
                await tOut;
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Failed to run submit method {submitMethodName} in {handler} with {eventArgs}.", submitMethodName, eventArgs, handler);

                throw new SubmitActionException("Failed to run submit method", eventArgs, handler, e);
            }
        }

        // https://stackoverflow.com/a/32337906/66988
        private static bool IsSimpleType(Type type)
        {
            return
                type.IsPrimitive ||
                new Type[] {
            typeof(Enum),
            typeof(String),
            typeof(Decimal),
            typeof(DateTime),
            typeof(DateTimeOffset),
            typeof(TimeSpan),
            typeof(Guid)
                }.Contains(type) ||
                Convert.GetTypeCode(type) != TypeCode.Object ||
                (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>) && IsSimpleType(type.GetGenericArguments()[0]))
                ;
        }
    }
}

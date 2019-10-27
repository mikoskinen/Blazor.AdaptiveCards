using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace AdaptiveCards.Blazor.Actions
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

                if (handlersMethods.Contains(actionName, StringComparer.InvariantCultureIgnoreCase))
                {
                    handlerMethod = handlersMethods.First(x => string.Equals(x, actionName, StringComparison.InvariantCultureIgnoreCase));
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
                    await Invoke(method, handler, null);

                    return;
                }

                if (methodParameters.Count == 1 && typeof(SubmitEventArgs).IsAssignableFrom(methodParameters.First().ParameterType))
                {
                    await Invoke(method, handler, new[] { eventArgs });

                    return;
                }

                if (model != null && methodParameters.Count == 1 && model.GetType().IsAssignableFrom(methodParameters.First().ParameterType))
                {
                    await Invoke(method, handler, new[] { model });

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

                    if (eventArgs.AdaptiveCard != null && eventArgs.AdaptiveCard.GetType().IsAssignableFrom(methodParameter.ParameterType))
                    {
                        arguments.Add(eventArgs.AdaptiveCard);

                        continue;
                    }

                    if (eventArgs.Data != null && !IsSimpleType(methodParameter.ParameterType))
                    {
                        var json = JsonSerializer.Serialize(eventArgs.Data);
                        var obj = JsonSerializer.Deserialize(json, methodParameter.ParameterType);

                        arguments.Add(obj);

                        continue;
                    }

                    if (eventArgs.Data != null && IsSimpleType(methodParameter.ParameterType))
                    {
                        if (eventArgs.Data.ContainsKey(methodParameter.Name))
                        {
                            var valueJson = JsonSerializer.Serialize(eventArgs.Data[methodParameter.Name]);
                            var value = JsonSerializer.Deserialize(valueJson, methodParameter.ParameterType);

                            arguments.Add(value);

                            continue;
                        }
                    }

                    arguments.Add(null);
                }

                await Invoke(method, handler, arguments.ToArray());
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Failed to run submit method {submitMethodName} in {handler} with {eventArgs}.", submitMethodName, eventArgs, handler);

                throw new SubmitActionException("Failed to run submit method", eventArgs, handler, e);
            }
        }

        private async Task Invoke(MethodInfo method, object handler, object[] arguments)
        {
            if (method.ReturnType == typeof(void))
            {
                method.Invoke(handler, arguments.ToArray());
            }
            else
            {
                var tOut = (Task) method.Invoke(handler, arguments.ToArray());
                await tOut;
            }
        }

        // https://stackoverflow.com/a/32337906/66988
        private static bool IsSimpleType(Type type)
        {
            return
                type.IsPrimitive ||
                new[] { typeof(Enum), typeof(string), typeof(decimal), typeof(DateTime), typeof(DateTimeOffset), typeof(TimeSpan), typeof(Guid) }
                    .Contains(type) ||
                Convert.GetTypeCode(type) != TypeCode.Object ||
                type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>) && IsSimpleType(type.GetGenericArguments()[0])
                ;
        }
    }
}

let cardComponents = [];
let cardCollectionComponent;

window.blazorAdaptiveCards = {

    setCardComponent: function (component, id) {
        cardComponents[id] = component;
    },

    setCardCollectionComponent: function (component) {
        cardCollectionComponent = component;
    },

    openUrl: function (url, el) {
        // Find the correct component which we use to invoke the action
        var card = el.closest(".ac-adaptivecard");
        var cardComponentElement = card.closest(".blazor-adaptive-card-container");
        var cardComponentId = cardComponentElement.getAttribute('id');

        var cardComponent = cardComponents[cardComponentId];
        cardComponent.invokeMethodAsync("OpenUrl", url);
    },

    submitData: function (el) {

        // Cards can have "built-in" data. Get these first if available
        var elementData = el.getAttribute('data-ac-submitdata');

        // Create an object based on the data. This is the object our code will submit in the end
        var obj = null;
        if (!elementData || elementData === "null") {
            obj = JSON.parse("{}");
        } else {
            obj = JSON.parse(elementData);
        }

        // Find the card which submitted the action
        var card = el
            .closest(".ac-adaptivecard");

        // Find all the form controls and add them into the object
        var inputs = card.querySelectorAll("input");
        addElements(inputs, obj, card);

        var textareas = card.querySelectorAll("textarea");
        addElements(textareas, obj, card);

        var selectors = card.querySelectorAll("select");
        addElements(selectors, obj, card);

        // Submit actions can provide a name. This is useful if one card has multiple submit actions
        var actionName = el.getAttribute('data-name');
        if (!actionName) {
            actionName = "Submit";
        }

        // Find the correct component which we use to invoke the action
        var cardComponentElement = card.closest(".blazor-adaptive-card-container");
        var cardComponentId = cardComponentElement.getAttribute('id');

        var cardComponent = cardComponents[cardComponentId];

        // Invoke the C#-method which handles the actual submit operation
        cardComponent.invokeMethodAsync("SubmitData", obj, actionName);
    },

    // Based on the code https://github.com/microsoft/AdaptiveCards/blob/master/source/dotnet/Samples/AdaptiveCards.Sample.Html/Program.cs
    toggleVisibility: function (id) {

        var el = document.getElementById(id);
        if (!el) {
            return;
        }

        var targetElementsString = el.getAttribute('data-ac-targetelements');
        var targetElements = targetElementsString.split(',');

        // For each target in list of targets
        for (var i = 0; i < targetElements.length; i++) {

            /// Do a split for commas and for each element, find the : to divide both strings
            var targetElementIdWithAction = targetElements[i].split(':');
            var targetElementId = targetElementIdWithAction[0];
            var targetElementAction = targetElementIdWithAction[1];

            var targetElementsInDocument = document.getElementsByName(targetElementId);
            var targetElement = targetElementsInDocument[0];
            var isCheckBoxElement = ((targetElementsInDocument.length > 1) && !(targetElement.className.includes('ac-textinput')));

            var targetSeparatorId = targetElement.dataset.acSeparatorid;
            var separator = document.getElementById(targetSeparatorId);

            if (targetElementAction === 'True' || (targetElementAction === 'Toggle' && targetElement.style.display === 'none')) {
                {
                    if (isCheckBoxElement) {
                        {
                            targetElement.style.display = 'inline-block';
                        }
                    } else {
                        {
                            targetElement.style.display = 'flex';
                        }
                    }

                    if (targetElement.className.includes('ac-container')) {
                        {
                            targetElement.style.display = 'block';
                        }
                    }

                    if (separator != null) {
                        {
                            separator.style.display = 'block';
                        }
                    }
                }
            } else if (targetElementAction === 'False' || (targetElementAction === 'Toggle' && targetElement.style.display !== 'none')) {
                {
                    targetElement.style.display = 'none';

                    if (separator != null) {
                        {
                            separator.style.display = 'none';
                        }
                    }
                }
            }

            var parent = targetElement.parentNode;
            var isFirstElement = true;
            for (var k = 0; k < parent.childNodes.length; k++) {
                {

                    var child = parent.childNodes[k];

                    <!-- if element is separator -> skip (As we don't care of this one) -->
                    if (child.className.includes('ac-separator') || child.className.includes('ac-columnseparator')) {
                        {
                            continue;
                        }
                    }

                    <!-- if element is not visible -> skip (The separator was hidden in the previous step) -->
                    if (child.style.display === 'none') {
                        {
                            continue;
                        }
                    }

                    var childSeparatorId = child.dataset.acSeparatorid;
                    var childSeparator = document.getElementById(childSeparatorId);

                    if (isFirstElement) {
                        {
                            <!-- if element is visible -> hide separator -->
                            if (childSeparator != null) {
                                {
                                    childSeparator.style.display = 'none';
                                }
                            }
                            isFirstElement = false;
                        }
                    } else {
                        {
                            <!-- if element is visible -> show separator -->
                            if (childSeparator != null) {
                                {
                                    childSeparator.style.display = 'block';
                                }
                            }
                        }
                    }
                }
            }
        }
    }
};

function addElements(inputs, obj, card) {

    var radioButtonGroups = [];
    if (inputs) {
        for (var i = 0; i < inputs.length; i++) {
            var item = inputs[i];

            if (item.type && item.type === 'checkbox') {

                handleCheckboxes(item, card, obj);
            } else if (item.type && item.type === 'radio') {
                var groupName = item.name;
                if (radioButtonGroups.indexOf(groupName) === -1) {
                    radioButtonGroups.push(groupName);
                }
            } else {
                obj[item.name] = item.value;
            }
        }
    }

    handleRadioButtons(radioButtonGroups, card, obj);
}

function handleCheckboxes(item, card, obj) {
    var checkboxSelector = 'input[name="' + item.name + '"]';
    var checkboxes = card.querySelectorAll(checkboxSelector);
    var isMultiValue = checkboxes.length > 1;

    if (isMultiValue) {
        if (obj[item.name] === undefined) {
            obj[item.name] = [];
        }
        if (item.hasAttribute("value") && item.checked) {
            obj[item.name].push(item.value);
        }
    } else {
        if (item.hasAttribute("value")) {
            obj[item.name] = item.value;
        } else {
            obj[item.name] = item.checked;
        }
    }
}

function handleRadioButtons(radioButtonGroups, card, obj) {

    if (!radioButtonGroups) {
        return;
    }

    for (var n = 0; n < radioButtonGroups.length; n++) {

        var radioButtonGroup = radioButtonGroups[n];
        var selector = 'input[name="' + radioButtonGroup + '"]:checked';
        var selectedRadioButton = card.querySelector(selector);

        if (selectedRadioButton) {
            var radioButtonGroupValue = selectedRadioButton.value;
            obj[radioButtonGroup] = radioButtonGroupValue;
        }
    }
}

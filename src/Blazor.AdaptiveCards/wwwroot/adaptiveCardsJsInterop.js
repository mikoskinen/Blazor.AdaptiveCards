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
    }
};

function addElements(inputs, obj, card) {

    var radioButtonGroups = [];
    if (inputs) {
        for (var i = 0; i < inputs.length; i++) {
            var item = inputs[i];

            if (item.type && item.type === 'checkbox') {

                handleCheckboxes(item, card, obj);
            }
            else if (item.type && item.type === 'radio') {
                var groupName = item.name;
                if (radioButtonGroups.indexOf(groupName) === -1) {
                    radioButtonGroups.push(groupName);
                }
            }
            else {
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
    }

    else {
        if (item.hasAttribute("value")) {
            obj[item.name] = item.value;
        }
        else {
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

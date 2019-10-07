let cardComponent;
let cardCollectionComponent;

window.blazorAdaptiveCards = {

    setCardComponent: function (component) {
        cardComponent = component;
    },

    setCardCollectionComponent: function (component) {
        cardCollectionComponent = component;
    },

    openUrl: function (url) {
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

        if (inputs) {
            for (var i = 0; i < inputs.length; i++) {
                var item = inputs[i];
                obj[item.name] = item.value;
            }
        }

        // Submit actions can provide a name. This is useful if one card has multiple submit actions
        var actionName = el.getAttribute('data-name');
        if (!actionName) {
            actionName = "Submit";
        }

        // Invoke the C#-method which handles the actual submit operation
        cardComponent.invokeMethodAsync("SubmitData", obj, actionName);
    }
};

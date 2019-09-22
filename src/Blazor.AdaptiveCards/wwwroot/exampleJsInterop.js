// This file is to show how a library package may provide JavaScript interop features
// wrapped in a .NET API

let myComponent;

window.jsFunctions = {

    myFunction: function (component) {
        myComponent = component;
    },

    myAnotherFunction: function () {
        console.log('test');
        console.log(myComponent);

        myComponent.invokeMethodAsync("Run");
    }

};

let urlOpener;

window.blazorAdaptiveCards = {

    setUrlOpener: function (component) {
        urlOpener = component;
    },

    openUrl: function (url) {
        urlOpener.invokeMethodAsync("OpenUrl", url);
    },

    submitData: function (el) {
        console.log('submitting');

        var data = $(el).data().acSubmitdata;

        console.log("initial data: ");
        console.log(data);

        var card = $(el)
            .closest(".ac-adaptivecard");

        var inputs = $(card).find("input");

        console.log("looping inputs");
        inputs.each(function (index, elem) {
            console.log(elem);
            data[elem.name] = elem.value;
        });

        var json = JSON.stringify(data);

        console.log(json);

        var actionName = el.getAttribute('data-name');
        if (!actionName) {
            actionName = "Submit";
        }

        console.log(actionName);

        urlOpener.invokeMethodAsync("SubmitData", data, actionName);

        //var data = $(el).data().acSubmitdata

        //console.log(data);
    }
};

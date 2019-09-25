let urlOpener;

window.blazorAdaptiveCards = {

    setUrlOpener: function (component) {
        urlOpener = component;
    },

    openUrl: function (url) {
        urlOpener.invokeMethodAsync("OpenUrl", url);
    },

    submitData: function (el) {
        var data = $(el).data().acSubmitdata;

        var card = $(el)
            .closest(".ac-adaptivecard");

        var inputs = $(card).find("input");

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

        urlOpener.invokeMethodAsync("SubmitData", data, actionName);
    }
};

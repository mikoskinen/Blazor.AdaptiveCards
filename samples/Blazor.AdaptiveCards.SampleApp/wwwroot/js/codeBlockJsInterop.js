window.codeBlock = {
    highlight: function (elementName) {
        var block = document.getElementById(elementName);
        console.log(block);
        try {
            Prism.highlightElement(block);
        } catch (err) {
            console.log(err);
        }
    }
};
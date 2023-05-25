abp.modals.Test = function () {
    var initModal = function (publicApi, args) {
        alert("Test modal is initialized!")
    };

    return {
        initModal: initModal
    };
}
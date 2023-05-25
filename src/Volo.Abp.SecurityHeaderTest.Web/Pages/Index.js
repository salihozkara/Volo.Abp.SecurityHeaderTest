$(function () {
    abp.log.debug('Index.js initialized!');
    
    var testModal = new abp.ModalManager({
        viewUrl: abp.appPath + 'TestModal',
        scriptUrl: abp.appPath + 'Pages/Test.js',
    });
    
    $('#OpenTestModalButton').click(function (e) {
        e.preventDefault();
        testModal.open();
    });
});

(function ($) {
    app.modals.CreateContentModal = function () {

        var _modalManager;
        var _classifiedContentService = abp.services.app.classifiedContent;
        var _$form = null;
        this.init = function (modalManager) {
            _modalManager = modalManager;
            _$form = _modalManager.getModal().find('form');
            _$form.validate();
        };

        this.save = function () {
            //Save your modal here...
            if (!_$form.valid()) {
                return;
            }
            var content = _$form.serializeFormToObject();
            var deferobj;
            _modalManager.setBusy(true);
            if (content.Id) {
                console.log('update record ' + content.Id);
                deferobj = _classifiedContentService.update(content)
            }
            else {
                console.log('create record');
                deferobj = _classifiedContentService.create(content)
            }
            deferobj.done(function () {
                _modalManager.close();
                location.reload();
            }).always(function () {
                _modalManager.setBusy(false);
            });
            //_bannerService.create(banner).done(function () {
            //    _modalManager.close();
            //    location.reload();
            //}).always(function () {
            //    _modalManager.setBusy(false);
            //});
        };
    };
})(jQuery);
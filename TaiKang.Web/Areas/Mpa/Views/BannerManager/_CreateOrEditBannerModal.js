(function ($) {
    app.modals.CreateBannerModal = function () {

        var _modalManager;
        var _bannerService = abp.services.app.banner;
        var _$form = null;
        var uploadFilename;
        this.init = function (modalManager) {
            _modalManager = modalManager;
            _$form = _modalManager.getModal().find('form');
            _$form.validate();

            $('#Image').fileupload({
                url: '/Mpa/BannerManager/UploadBannerImage',
                dataType: 'json',
                done: function (e, data) {
                    uploadFilename = data.result.result.fileName;
                    console.log(uploadFilename);
                }
            })
        };

        this.save = function () {
            //Save your modal here...
            if (!_$form.valid()) {
                return;
            }
            var banner = _$form.serializeFormToObject();
            var deferobj;
            banner.bannerImage = uploadFilename
            _modalManager.setBusy(true);
            if (banner.Id) {
                console.log('update record ' + banner.Id);
                deferobj= _bannerService.update(banner)
            }
            else {
                console.log('create record');
                deferobj= _bannerService.create(banner)
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
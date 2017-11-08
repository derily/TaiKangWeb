(function($) {
    app.modals.CreateOrEditJobModal = function () {
        var _jobChanceService = abp.services.app.jobChance;
        var _modalManager;
        var _$jobForm = null;
        this.init = function(modalManager) {
            _modalManager = modalManager;

            _$jobForm = _modalManager.getModal().find('form');
            _$jobForm.validate();
        };

        this.save = function () {
            if (!_$jobForm.valid()) {
                return;
            }

            var job = _$jobForm.serializeFormToObject();
            _modalManager.setBusy(true);
            _jobChanceService.createOrUpdateJob(job).done(function () {
                abp.notify.info(app.localize('SavedSuccessfully'));
                _modalManager.close();
               // abp.event.trigger('app.createOrEditUserModalSaved');
            }).always(function () {
                _modalManager.setBusy(false);
            });
        };
    };
})(jQuery);
(function ($) {
    app.modals.CreateOrEditProductModal = function () {

        var _modalManager;
        var _productService = abp.services.app.product;
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
            var product = _$form.serializeFormToObject();
            debugger;
            console.log(product);
            var deferobj;
            _modalManager.setBusy(true);
            if (product.Id) {
                console.log('update record ' + product.Id);
                deferobj = _productService.update(product)
            }
            else {
                console.log('create record');
                deferobj = _productService.create(product)
            }
            deferobj.done(function () {
                _modalManager.close();
                location.reload();
            }).always(function () {
                _modalManager.setBusy(false);
            });
        };
    };
})(jQuery);
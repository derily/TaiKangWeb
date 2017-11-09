(function () {
    $(function () {
        var _$productsTable = $('#ProductsTable');
        var _productService = abp.services.app.product;

        var _createOrEditModal = new app.ModalManager({
            viewUrl: abp.appPath + 'Mpa/Product/CreateOrEditModal',
            scriptUrl: abp.appPath + 'Areas/Mpa/Views/Product/_CreateOrEditProductModal.js',
            modalClass: 'CreateOrEditProductModal'
        });

        var _permissions = {
            create: abp.auth.hasPermission('Pages_TaiKang_Product_Create'),
            edit: abp.auth.hasPermission('Pages_TaiKang_Product_Edit'),
            'delete': abp.auth.hasPermission('Pages_TaiKang_Product_Delete')
        };

        _$productsTable.jtable({
            paging: true,
            sorting: true,
            multiSorting: true,
            actions: {
                listAction: {
                    method: _productService.getAll
                }
            },

            fields: {
                id: {
                    key: true,
                    list: false
                },
                actions: {
                    type: 'record-actions',
                    cssClass: 'btn btn-xs btn-primary blue',
                    text: '<i class="fa fa-cog"></i> ' + app.localize('Actions') + ' <span class="caret"></span>',
                    items: [
                        {
                            text: "修改",
                            visible: function (data) {
                                return true;
                            },
                            action: function (data) {
                                _createOrEditModal.open({ id: data.record.id });
                                //app.utils.removeCookie(abp.security.antiForgery.tokenCookieName);
                                //abp.ajax({
                                //    url: abp.appPath + 'BannerManager/Impersonate',
                                //    data: JSON.stringify({
                                //        tenantId: abp.session.tenantId,
                                //        userId: data.record.id
                                //    })
                                //});
                            }
                        }
                    ]
                },
                productName: {
                    title: "商品名称",
                    width: '9%'
                },
                desc: {
                    title: "说明",
                    width: '10%'
                },
                functions: {
                    title: "功效",
                    width:'20%'
                },
                buyLink: {
                    title: "购买地址",
                    width:'10%'
                },
                creationTime: {
                    title: app.localize('CreationTime'),
                    width: '7%',
                    display: function (data) {
                        return moment(data.record.creationTime).format('L');
                    }
                }
            }
        });

        $('#CreateNewProductButton').click(function () {
            _createOrEditModal.open();
        });

        function getProducts() {
            _$productsTable.jtable('load', {});
        }
        getProducts();


    })
})();
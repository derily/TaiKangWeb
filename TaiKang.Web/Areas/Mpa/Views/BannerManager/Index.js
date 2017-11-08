(function () {
    $(function () {
        var _$bannersTable = $('#BannersTable');
        var _bannerService = abp.services.app.banner;

        var _createOrEditModal = new app.ModalManager({
            viewUrl: abp.appPath + 'Mpa/BannerManager/CreateBannerModal',
            scriptUrl: abp.appPath + 'Areas/Mpa/Views/BannerManager/_CreateOrEditBannerModal.js',
            modalClass: 'CreateBannerModal'
        });

        var _permissions = {
            create: abp.auth.hasPermission('Pages_TaiKang_BannerManager_Create'),
            edit: abp.auth.hasPermission('Pages_TaiKang_BannerManager_Edit'),
            'delete': abp.auth.hasPermission('Pages_TaiKang_BannerManager_Delete')
        };

        _$bannersTable.jtable({
            title: "首页轮播图",
            paging: true,
            sorting: true,
            multiSorting: true,
            actions: {
                listAction: {
                    method: _bannerService.getAll
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
                bannerTitle: {
                    title: "轮播图标题",
                    width: '9%',
                    initialSortingDirection: 'DESC'
                },
                bannerImage: {
                    title: "图片名称",
                    width: '10%'
                },
                enabled: {
                    title: "是否启用",
                    width: '6%',
                    display: function (data) {
                        if (data.record.enabled) {
                            return '<span class="label label-success">' + app.localize('Yes') + '</span>';
                        } else {
                            return '<span class="label label-default">' + app.localize('No') + '</span>';
                        }
                    }
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

        $('#CreateNewBannerButton').click(function () {
            _createOrEditModal.open();
        });

        function getBanners() {
            _$bannersTable.jtable('load', {});
        }
        getBanners();
    })
})();
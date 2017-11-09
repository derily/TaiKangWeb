(function () {
    $(function () {
        var _$contentsTable = $('#ContentsTable');
        var _classifiedContentService = abp.services.app.classifiedContent;

        var _createOrEditModal = new app.ModalManager({
            viewUrl: abp.appPath + 'Mpa/ClassifiedContent/CreateContentModal',
            scriptUrl: abp.appPath + 'Areas/Mpa/Views/ClassifiedContent/_CreateOrEditContentModal.js',
            modalClass: 'CreateContentModal'
        });

        var _permissions = {
            create: abp.auth.hasPermission('Pages_TaiKang_BannerManager_Create'),
            edit: abp.auth.hasPermission('Pages_TaiKang_BannerManager_Edit'),
            'delete': abp.auth.hasPermission('Pages_TaiKang_BannerManager_Delete')
        };

        _$contentsTable.jtable({
            paging: true,
            sorting: true,
            multiSorting: true,
            actions: {
                listAction: {
                    method: _classifiedContentService.getAll
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
                classifyName: {
                    title: "图文类别",
                    width: '9%'
                },
                content: {
                    title: "内容",
                    width: '10%'
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

        $('#CreateNewContentButton').click(function () {
            _createOrEditModal.open();
        });

        function getContents() {
            _$contentsTable.jtable('load', {});
        }
        getContents();


    })
})();
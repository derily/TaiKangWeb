(function () {
    $(function () {
        var _$jobsTable = $('#JobsTable');
        var _jobChanceService = abp.services.app.jobChance;

        var _permissions = {
            create: abp.auth.hasPermission('Pages_TaiKang_JobChance_Create'),
            edit: abp.auth.hasPermission('Pages_TaiKang_JobChance_Edit'),
            'delete': abp.auth.hasPermission('Pages_TaiKang_JobChance_Delete')
        };

        var _createOrEditModal = new app.ModalManager({
            viewUrl: abp.appPath + 'Mpa/Job/CreateOrEditModal',
            scriptUrl: abp.appPath + 'Areas/Mpa/Views/Job/_CreateOrEditModal.js',
            modalClass: 'CreateOrEditJobModal'
        });

        _$jobsTable.jtable({

            title: '职位列表',
            paging: true,
            sorting: true,
            multiSorting: true,
            actions: {
                listAction: {
                    method: _jobChanceService.getJobs
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
                            text: app.localize('Edit'),
                            visible: function () {
                                return _permissions.edit;
                            },
                            action: function (data) {
                                _createOrEditModal.open({ id: data.record.id });
                            }
                        },
                        {
                            text: app.localize('Delete'),
                            visible: function () {
                                return _permissions.delete;
                            },
                            action: function (data) {
                                deleteUser(data.record);
                            }
                        }]
                },
                jobName: {
                    title: "岗位名称",
                    width: '9%',
                    initialSortingDirection: 'DESC'
                },
                isActive: {
                    title: "是否有效",
                    width: '6%',
                    display: function (data) {
                        if (data.record.isActive) {
                            return '<span class="label label-success">' + app.localize('Yes') + '</span>';
                        } else {
                            return '<span class="label label-default">' + app.localize('No') + '</span>';
                        }
                    }
                },
                creationTime: {
                    title: "创建时间",
                    width: '7%',
                    display: function (data) {
                        return moment(data.record.creationTime).format('L');
                    }
                }
            }
        });

        $('#CreateNewJobButton').click(function () {
            _createOrEditModal.open();
        });

        function getJobs() {
            _$jobsTable.jtable('load', {});
        }

        getJobs();

    })
})();
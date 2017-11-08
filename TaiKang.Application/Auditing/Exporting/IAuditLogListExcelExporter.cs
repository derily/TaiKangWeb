using System.Collections.Generic;
using TaiKang.Auditing.Dto;
using TaiKang.Dto;

namespace TaiKang.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);
    }
}

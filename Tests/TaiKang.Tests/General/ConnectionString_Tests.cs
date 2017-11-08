using System.Data.SqlClient;
using Shouldly;
using Xunit;

namespace TaiKang.Tests.General
{
    public class ConnectionString_Tests
    {
        [Fact]
        public void SqlConnectionStringBuilder_Test()
        {
            var csb = new SqlConnectionStringBuilder("Server=localhost; Database=TaiKang; Trusted_Connection=True;");
            csb["Database"].ShouldBe("TaiKang");
        }
    }
}

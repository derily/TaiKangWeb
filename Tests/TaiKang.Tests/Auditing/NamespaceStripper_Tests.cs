using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaiKang.Auditing;
using Shouldly;
using Xunit;

namespace TaiKang.Tests.Auditing
{
    public class NamespaceStripper_Tests: AppTestBase
    {
        private readonly INamespaceStripper _namespaceStripper;

        public NamespaceStripper_Tests()
        {
            _namespaceStripper = Resolve<INamespaceStripper>();
        }

        [Fact]
        public void Should_Stripe_Namespace()
        {
            var controllerName = _namespaceStripper.StripNameSpace("TaiKang.Web.Controllers.HomeController");
            controllerName.ShouldBe("HomeController");
        }

        [Theory]
        [InlineData("TaiKang.Auditing.GenericEntityService`1[[TaiKang.Storage.BinaryObject, TaiKang.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null]]", "GenericEntityService<BinaryObject>")]
        [InlineData("CompanyName.ProductName.Services.Base.EntityService`6[[CompanyName.ProductName.Entity.Book, CompanyName.ProductName.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],[CompanyName.ProductName.Services.Dto.Book.CreateInput, N...", "EntityService<Book, CreateInput>")]
        [InlineData("TaiKang.Auditing.XEntityService`1[TaiKang.Auditing.AService`5[[TaiKang.Storage.BinaryObject, TaiKang.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],[TaiKang.Storage.TestObject, TaiKang.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],]]", "XEntityService<AService<BinaryObject, TestObject>>")]
        public void Should_Stripe_Generic_Namespace(string serviceName, string result)
        {
            var genericServiceName = _namespaceStripper.StripNameSpace(serviceName);
            genericServiceName.ShouldBe(result);
        }
    }
}

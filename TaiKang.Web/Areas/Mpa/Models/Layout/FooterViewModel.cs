using TaiKang.Sessions.Dto;

namespace TaiKang.Web.Areas.Mpa.Models.Layout
{
    public class FooterViewModel
    {
        public GetCurrentLoginInformationsOutput LoginInformations { get; set; }

        public string GetProductNameWithEdition()
        {
            var productName = "TaiKang";

            if (LoginInformations.Tenant != null && LoginInformations.Tenant.EditionDisplayName != null)
            {
                productName += " " + LoginInformations.Tenant.EditionDisplayName;
            }

            return productName;
        }
    }
}
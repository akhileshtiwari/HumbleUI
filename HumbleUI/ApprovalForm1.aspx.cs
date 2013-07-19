using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HumbleUI
{
    public partial class ApprovalForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                InitializeUI();
        }

        private void InitializeUI()
        {
            lbRegion.DataSource = Service.GetRegions();
            lbRegion.DataTextField = "value";
            lbRegion.DataValueField = "key";
            lbRegion.DataBind();

            lbCountry.DataSource = Service.GetCountries();
            lbCountry.DataValueField = "key";
            lbCountry.DataTextField = "value";
            lbCountry.DataBind();
        }

        protected void lbRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbCountry.DataSource = Service.GetFilteredCountries(int.Parse(lbRegion.SelectedValue));
            lbCountry.DataValueField = "key";
            lbCountry.DataTextField = "value";
            lbCountry.DataBind();

            lbProduct.Items.Clear();
        }

        private IList<int> GetSelectedCountriesId()
        {
            var selectedCountryIds = new List<int>();
            foreach (ListItem item in lbCountry.Items)
                if (item.Selected)
                    selectedCountryIds.Add(int.Parse(item.Value));

            return selectedCountryIds;
        }

        protected void lbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbProduct.DataSource = Service.GetProductCatalog(GetSelectedCountriesId());
            lbProduct.DataValueField = "key";
            lbProduct.DataTextField = "value";
            lbProduct.DataBind();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HumbleUI
{
    public partial class ApprovalForm2 : System.Web.UI.Page,ApprovalScreen
    {
        private ApprovalPresenter presenter = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            presenter = new ApprovalPresenter(this);
            if (!IsPostBack)
                presenter.InitializeUI();
        }

        protected void lbRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter.SelectedRegionChanged(int.Parse(lbRegion.SelectedValue));
        }

        protected void lbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter.SelectedCountriesChanged(GetSelectedCountriesId());
        }

        public void SetRegions(IDictionary<int, string> regions)
        {
            lbRegion.DataSource = regions;
            lbRegion.DataTextField = "value";
            lbRegion.DataValueField = "key";
            lbRegion.DataBind();
        }

        public void SetCountries(IDictionary<int, string> countries)
        {
            lbCountry.DataSource = countries;
            lbCountry.DataValueField = "key";
            lbCountry.DataTextField = "value";
            lbCountry.DataBind();
        }

        public void SetProducts(IDictionary<int, string> products)
        {
            lbProduct.DataSource = products;
            lbProduct.DataValueField = "key";
            lbProduct.DataTextField = "value";
            lbProduct.DataBind();
        }
        
        public void ClearProductList()
        {
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
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace HumbleUI
{
	public class ApprovalPresenter
	{
        private ApprovalScreen screen;

        public ApprovalPresenter(ApprovalScreen screen)
        {
            this.screen = screen;
        }
		public void InitializeUI()
		{
            screen.SetCountries(Service.GetCountries());
            screen.SetRegions(Service.GetRegions());
		}

		public void SelectedRegionChanged(int regionId)
		{
            screen.ClearProductList();
            screen.SetCountries(Service.GetFilteredCountries(regionId));
		}

		public void SelectedCountriesChanged(IList<int> selectedCoutriesId)
		{
            screen.SetProducts(Service.GetProductCatalog(selectedCoutriesId));
		}
	}
}

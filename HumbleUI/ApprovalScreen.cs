using System;
using System.Collections.Generic;
using System.Text;

namespace HumbleUI
{
	public interface ApprovalScreen
	{
		void SetRegions(IDictionary<int, string> regions);

		void SetCountries(IDictionary<int, string> countries);

		void SetProducts(IDictionary<int, string> products);

        void ClearProductList();
	}
}

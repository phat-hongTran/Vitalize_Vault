using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitalize_Vault.ViewModel
{
    public class ProductManagementViewModel : ViewModelBase
    {
        private ProductItemViewModel? _selectedProduct;

        public ObservableCollection<ProductItemViewModel> Products { get; } = new();

		public ProductItemViewModel? SelectedProduct
        {
			get { return _selectedProduct; }
			set 
			{
                _selectedProduct = value;
				RaisePropertyChanged();
			}
		}


	}
}

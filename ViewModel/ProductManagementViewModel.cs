using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using Vitalize_Vault.Data;

namespace Vitalize_Vault.ViewModel
{
    public class ProductManagementViewModel : ViewModelBase
    {
        private ProductItemViewModel? _selectedProduct;
        private readonly IProductDataProvider _dataProvider;

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

        public ProductManagementViewModel(IProductDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }

        public async override Task LoadAsync()
        {
            if (Products.Any())
            {
                return;
            }

            var products = await _dataProvider.GetAllAsync();
            if (products.Any())
            {
                foreach (var product in products)
                {
                    Products.Add(new ProductItemViewModel(product));
                }
            }            
        }
    }
}

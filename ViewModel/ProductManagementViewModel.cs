using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using Vitalize_Vault.Command;
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
                DeleteCommand.RaiseCanExecuteChanged();
            }
        }

        public ProductManagementViewModel(IProductDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
            AddCommand = new DelegateCommand(Add);
            DeleteCommand = new DelegateCommand(Delete, CanDelete);
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

        private void Add(object? obj)
        {
            throw new NotImplementedException();
        }

        private bool CanDelete(object? arg) => SelectedProduct != null ? true : false;

        private void Delete(object? obj)
        {
            throw new NotImplementedException();
        }

        public DelegateCommand AddCommand { get; }
        public DelegateCommand DeleteCommand { get; }
    }
}

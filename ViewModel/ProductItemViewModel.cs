using Vitalize_Vault.Model;

namespace Vitalize_Vault.ViewModel
{
    public class ProductItemViewModel : ViewModelBase
    {
        private readonly Product _product;

        public ProductItemViewModel(Product product)
        {
            _product = product;
        }

        public int Id => _product.Id;

        public string Name
        {
            get => _product.Name;
            set 
            { 
                _product.Name = value;
                RaisePropertyChanged();
            }
        }

        public DateTime? ExpirationDate
        {
            get => _product.ExpirationDate;
            set
            {
                _product.ExpirationDate = value;
                RaisePropertyChanged();
            }
        }
    }
}
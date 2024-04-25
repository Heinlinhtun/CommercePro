
namespace CommercePro
{
    public partial class MainPage : ContentPage
    {
        private readonly LocalDbService _dbService;
        private int _editProductID;

        public MainPage(LocalDbService dbService)
        {
            InitializeComponent();
            _dbService = dbService;

        }



        private void BtnProduct_Clicked(object sender, EventArgs e)
        {
            _ = NavigatedToProduct();
        }

        private async Task NavigatedToProduct()
        {
            await Navigation.PushAsync(new ProductPage(_dbService));

        }


    }

}


namespace CommercePro
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();

        }



        private void BtnProduct_Clicked(object sender, EventArgs e)
        {
            NavigatedToProduct();
        }

        private async Task NavigatedToProduct()
        {
            await Navigation.PushAsync(new ProductPage());
        }
    }

}

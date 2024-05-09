using CommunityToolkit.Maui.Views;
using System.Windows.Input;

namespace CommercePro;

public partial class ProductPage : ContentPage
{
    //private readonly LocalDbService _dbService;

    public ProductPage()
    {
        InitializeComponent();
        LocalDbService localDbService = new LocalDbService();
        Task.Run(async () => ProductlistView.ItemsSource = await localDbService.GetProducts());
    }



    private void BtnAddProduct_Clicked(object sender, EventArgs e)
    {
        this.ShowPopup(new AddProductPopup());
    }





}
using CommunityToolkit.Maui.Views;
using System.Windows.Input;

namespace CommercePro;

public partial class ProductPage : ContentPage
{
    private readonly LocalDbService _dbService;

    public ProductPage(LocalDbService dbService)
    {
        InitializeComponent();
        _dbService = dbService;
        Task.Run(async () => ProductlistView.ItemsSource = await _dbService.GetProducts());
    }



    private void BtnAddProduct_Clicked(object sender, EventArgs e)
    {
        this.ShowPopup(new AddProductPopup());
    }





}
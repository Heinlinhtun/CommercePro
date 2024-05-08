using CommunityToolkit.Maui.Views;

namespace CommercePro;

public partial class AddProductPopup : Popup
{
    public AddProductPopup()
    {
        InitializeComponent();
    }

    private void BtnSave_Clicked(object sender, EventArgs e)
    {

    }

    private void BtnClose_Clicked(object sender, EventArgs e)
    {
        Close();
    }
}
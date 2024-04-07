using System.Windows.Input;

namespace CommercePro;

public partial class ProductPage : ContentPage
{
    public ProductPage()
    {
        InitializeComponent();
    }



    private void BtnAddProduct_Clicked(object sender, EventArgs e)
    {
        ShowInput();
    }

    private async Task<CustomInputResult> ShowInput()
    {
        var promptPage = new ContentPage
        {
            Content = new StackLayout
            {
                Children =
            {
                new Label { Text = "Please enter your details" },
                new Entry { Placeholder = "Name" },
                new Entry { Placeholder = "Email" },
                new Picker { ItemsSource = new List<string> { "Option 1", "Option 2" } },
                // Add more input controls as needed
                new Button {Text = "OK"  }
            }
            }
        };
        promptPage.Padding = 10;

        // Display the pop-up
        await Navigation.PushModalAsync(promptPage);

        // Wait for the user to input their details and press a 'submit' button
        // ...

        // Retrieve the input values from the controls
        // ...

        // Return the result
        return new CustomInputResult
        {
            // Populate with the retrieved values
        };

    }
    
    async Task OnCloseButtonClicked()
    {
        // Assuming 'this' is a reference to the pop-up page
        await Navigation.PopModalAsync();
    }


    public class CustomInputResult
    {
        public string Name { get; set; }
        public string Email { get; set; }
        // Add more properties to match the input controls
    }
}
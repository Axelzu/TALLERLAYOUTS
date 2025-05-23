using Microsoft.Maui.Controls;

namespace TALLERLAYOUTS;

public partial class GridPage : ContentPage
{
    public GridPage()
    {
        InitializeComponent();
    }

    private async void OnGoToStackPageClicked(object sender, EventArgs e)
    {
        

        await Navigation.PushAsync(new StackPage());
        
    }

}
namespace TALLERLAYOUTS;

public partial class FlexPage : ContentPage
{
    public FlexPage()
    {
        InitializeComponent();
    }

    private async void OnGoToAbsolutePageClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AbsolutePage());
    }
}
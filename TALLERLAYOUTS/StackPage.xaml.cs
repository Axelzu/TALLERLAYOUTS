namespace TALLERLAYOUTS;

public partial class StackPage : ContentPage
{
    public StackPage()
    {
        InitializeComponent();
    }

    private async void OnGoToFlexPageClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FlexPage());
    }

}
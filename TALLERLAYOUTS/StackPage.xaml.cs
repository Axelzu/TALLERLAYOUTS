namespace TALLERLAYOUTS;

public partial class StackPage : ContentPage
{
    private async void OnGoToFlexPageClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FlexPage());
    }

}
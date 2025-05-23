namespace TALLERLAYOUTS;

public partial class AbsolutePage : ContentPage
{
    private async void OnGoToGridPageClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GridPage());
    }

}
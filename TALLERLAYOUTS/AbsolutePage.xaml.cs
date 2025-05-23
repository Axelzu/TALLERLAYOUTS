namespace TALLERLAYOUTS;

public partial class AbsolutePage : ContentPage
{
    public AbsolutePage()
    {
        InitializeComponent();
    }

    private async void OnGoToGridPageClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GridPage());
    }

}
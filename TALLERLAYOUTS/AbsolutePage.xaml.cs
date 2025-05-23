private async void OnGoToGridPageClicked(object sender, EventArgs e)
{
    await Navigation.PushAsync(new GridPage());
}

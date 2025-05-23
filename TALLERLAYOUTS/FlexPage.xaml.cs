private async void OnGoToAbsolutePageClicked(object sender, EventArgs e)
{
    await Navigation.PushAsync(new AbsolutePage());
}

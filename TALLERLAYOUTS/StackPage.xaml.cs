private async void OnGoToFlexPageClicked(object sender, EventArgs e)
{
    await Navigation.PushAsync(new FlexPage());
}

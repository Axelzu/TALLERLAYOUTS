using TALLERLAYOUTS;

private async void OnGoToStackPageClicked(object sender, EventArgs e)
{
    await Navigation.PushAsync(new StackPage());
}

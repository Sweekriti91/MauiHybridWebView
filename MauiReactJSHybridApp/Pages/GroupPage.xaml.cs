namespace MauiReactJSHybridApp;

public partial class GroupPage : ContentPage
{
	public GroupPage()
	{
		InitializeComponent();
		#if DEBUG
            myHybridWebView.EnableWebDevTools = true;
#endif
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await myHybridWebView.InvokeJsMethodAsync("setTabValue", "group");
    }
}
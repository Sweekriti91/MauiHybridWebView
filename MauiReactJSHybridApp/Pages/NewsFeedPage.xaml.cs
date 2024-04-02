namespace MauiReactJSHybridApp;

public partial class NewsFeedPage : ContentPage
{
	public NewsFeedPage()
	{
		InitializeComponent();
		#if DEBUG
            myHybridWebView.EnableWebDevTools = true;
#endif
  
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        await myHybridWebView.InvokeJsMethodAsync("setTabValue", "news");
    }


}
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
}
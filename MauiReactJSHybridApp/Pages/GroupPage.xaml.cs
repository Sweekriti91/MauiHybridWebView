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
}
using System.Diagnostics;

namespace MauiReactJSHybridApp
{
    public partial class MainPage : TabbedPage
    {

        public MainPage()
        {
            InitializeComponent();
            this.CurrentPageChanged += MainPage_CurrentPageChanged;
        }

        private void MainPage_CurrentPageChanged(object sender, EventArgs e)
        {
            var test = sender as Page;
            //var test2 = e as Page;
        }
    }
}

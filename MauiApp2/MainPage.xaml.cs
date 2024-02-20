namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

#if MACCATALYST || IOS                   
            if (webView is WebKit.WKWebView wkWebView)
            {
                wkWebView.Configuration.Preferences.SetValueForKey(Foundation.NSObject.FromObject(true), (Foundation.NSString)"allowFileAccessFromFileURLs");
            }
#endif
        }

    }

}

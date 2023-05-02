using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Xilium.CefGlue.Avalonia;

namespace WebViewTest.Views;

public partial class BrowserWindow : Window
{
    public BrowserWindow()
    {
        InitializeComponent();
        
        Decorator webViewContainer = this.Get<Decorator>(nameof(WebViewContainer));

        AvaloniaCefBrowser browser = new AvaloniaCefBrowser();
        browser.Address = "https://google.de";

        webViewContainer.Child = browser;
        
#if DEBUG
        this.AttachDevTools();
#endif
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
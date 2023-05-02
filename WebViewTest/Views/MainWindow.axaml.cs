using Avalonia.Controls;
using Avalonia.Interactivity;
using Xilium.CefGlue.Avalonia;

namespace WebViewTest.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        BrowserWindow browserWindow = new BrowserWindow();
        browserWindow.ShowDialog(this);
    }
}
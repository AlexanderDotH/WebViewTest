using System.Reactive;
using System.Threading.Tasks;
using ReactiveUI;
using WebViewTest.Views;

namespace WebViewTest.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private ReactiveCommand<Unit, Unit> OpenBrowserCommand { get; }

    public MainWindowViewModel()
    {
        OpenBrowserCommand = ReactiveCommand.CreateFromTask(OpenBrowser);
    }

    private async Task OpenBrowser()
    {
        BrowserWindow browserWindow = new BrowserWindow();
        browserWindow.ShowDialog(new MainWindow());
    }
}
using Microsoft.UI.Xaml;
using MyApp.ViewModels;
using Microsoft.UI;
using Windows.Graphics;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace MyApp
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SlackyNotes : Window
    {
        public NotesViewModel ViewModel { get; set; } = new NotesViewModel();
        public SlackyNotes()
        {
            
            InitializeComponent();

            Root.DataContext = ViewModel;

            var titleBar = AppWindow.TitleBar;

            titleBar.BackgroundColor = ColorHelper.FromArgb(255, 255, 197, 211);
            titleBar.ButtonBackgroundColor = ColorHelper.FromArgb(255, 255, 197, 211);

            AppWindow.Resize(new SizeInt32(600, 800));

        }
    }
}

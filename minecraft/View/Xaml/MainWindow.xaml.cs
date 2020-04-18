using System.ComponentModel;
using System.Windows;
using nihilus.Logic.Manager;
using nihilus.ViewModel;

namespace nihilus.xaml
{
    public partial class MainWindow : Window
    {
        private MainViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();
            Closing += OnMainWindowClose;
            viewModel = ApplicationManager.Instance.MainViewModel;
            DataContext = viewModel;
        }

        private void ImportServer_Click(object sender, RoutedEventArgs e)
        {
            //TODO
        }

        private void CreateServer_Click(object sender, RoutedEventArgs e)
        {
            AddServer.AddServer addServer = new AddServer.AddServer();
            addServer.ShowDialog();
        }

        private void OnMainWindowClose(object sender, CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
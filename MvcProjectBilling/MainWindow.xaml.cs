using System.Windows;
using ProjectBilling.Business.MVC;

namespace ProjectBilling.UI.MVC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IProjectsController _controller;

        public MainWindow()
        {
            InitializeComponent();
            _controller
                = new ProjectsController(new ProjectsModel());
        }

        private void ShowProjectsButton_Click(object sender,
            RoutedEventArgs e)
        {
            _controller.ShowProjectsView(this);
        }
    }
}

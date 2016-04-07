using System;
using System.Windows;
using System.Windows.Controls;
using ProjectBilling.DataAccess;
using System.Windows.Media;

namespace ProjectBilling.UI.Monolithic
{

    sealed class ProjectsView : Window
    {

        protected ProjectsView()
        {
            AddControlsToWindow();
            LoadProjects();
        }
        [STAThread]
        static void Main(string[] args)
        {
            ProjectsView mainWindow = new ProjectsView();
            new Application().Run(mainWindow);
        }

        private static readonly Thickness _margin = new Thickness(5);
        private readonly ComboBox _projectsComboBox = new ComboBox() { Margin = _margin };
        private readonly TextBox _estimateTextBox = new TextBox()
        {
            IsEnabled = false,
            Margin = _margin
        };
        private readonly TextBox _actualTextBox = new TextBox()
        {
            IsEnabled = false,
            Margin = _margin
        };
        private readonly Button _updateButton = new Button()
        {
            IsEnabled = false,
            Content = "Update",
            Margin = _margin
        };
        private void projectsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            // If there is a selected item
            if (comboBox != null && comboBox.SelectedIndex > -1)
            {
                UpdateDetails();
            }
            else
            {
                DisableDetails();
            }
        }
        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            Project selectedProject = _projectsComboBox.SelectedItem as Project;
            if (selectedProject != null)
            {
                selectedProject.Estimate = double.Parse(_estimateTextBox.Text);
                if (!string.IsNullOrEmpty(_actualTextBox.Text))
                {
                    selectedProject.Actual = double.Parse(_actualTextBox.Text);
                }
                SetEstimateColor(selectedProject);
            }
        }
        private void LoadProjects()
        {
            foreach (Project project in new DataServiceStub().GetProjects())
            {
                _projectsComboBox.Items.Add(project);
            }
            _projectsComboBox.DisplayMemberPath = "Name";
            _projectsComboBox.SelectedValuePath = "Id";
            _projectsComboBox.SelectionChanged += new SelectionChangedEventHandler(_projectsComboBox_SelectionChanged);            
        }

        void _projectsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            // If there is a selected item
            if (comboBox != null && comboBox.SelectedIndex > -1)
            {
                UpdateDetails();
            }
            else
            {
                DisableDetails();
            }

        }
        private Grid GetGrid()
        {
            Grid grid = new Grid();
            grid.ColumnDefinitions.Add(new ColumnDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());
            grid.RowDefinitions.Add(new RowDefinition());
            grid.RowDefinitions.Add(new RowDefinition());
            grid.RowDefinitions.Add(new RowDefinition());
            grid.RowDefinitions.Add(new RowDefinition());
            return grid;
        }
        private void AddControlsToWindow()
        {
            Grid grid = GetGrid();
            grid.Children.Add(new Label() { Content = "Project:" });
            Grid.SetColumn(_projectsComboBox, 1);
            grid.Children.Add(_projectsComboBox);
            Label label = new Label() { Content = "Estimated Cost:" };
            Grid.SetRow(label, 1);
            grid.Children.Add(label);
            Grid.SetRow(_estimateTextBox, 1);
            Grid.SetColumn(_estimateTextBox, 1);
            grid.Children.Add(_estimateTextBox);
            label = new Label() { Content = "Actual Cost:" };
            Grid.SetRow(label, 2);
            grid.Children.Add(label);
            Grid.SetRow(_actualTextBox, 2);
            Grid.SetColumn(_actualTextBox, 1);
            grid.Children.Add(_actualTextBox);
            Grid.SetRow(_updateButton, 3);
            Grid.SetColumnSpan(_updateButton, 2);
            grid.Children.Add(_updateButton);
            Content = grid;
        }
        private void UpdateDetails()
        {
            Project selectedProject
                = _projectsComboBox.SelectedItem
                as Project;

            _estimateTextBox.IsEnabled = true;
            _estimateTextBox.Text
                = selectedProject.Estimate.ToString();
            _actualTextBox.IsEnabled = true;
            _actualTextBox.Text = (selectedProject.Actual == 0)
                      ? ""
                      : selectedProject.Actual.ToString();
            SetEstimateColor(selectedProject);
            _updateButton.IsEnabled = true;
        }
        private void DisableDetails()
        {
            _estimateTextBox.IsEnabled = false;
            _actualTextBox.IsEnabled = false;
            _updateButton.IsEnabled = false;
        }
        private void SetEstimateColor(Project selectedProject)
        {
            if (selectedProject.Actual == 0)
            {
                _estimateTextBox.Foreground = Brushes.Black;
            }
            else if (selectedProject.Actual
                <= selectedProject.Estimate)
            {
                _estimateTextBox.Foreground = Brushes.Green;
            }
            else
            {
                _estimateTextBox.Foreground = Brushes.Red;
            }
        }

    }
}

using Contracts.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Contracts.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ProjectsPage : Contracts.Common.LayoutAwarePage
    {
        ProjectsViewModel projectsViewModel = null;
        ObservableCollection<ProjectViewModel> projects = null;
        public ProjectsPage()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var customer = (CustomerViewModel)e.Parameter;
            App.CurrentCustomerId = customer.Id;
            projectsViewModel = new ProjectsViewModel();
            projects = projectsViewModel.GetProjects(customer.Id);
            ProjectsViewSource.Source = projects;
            ProjectsGridView.SelectedItem = null;
            PageTitle.Text = string.Format("{0} projects", customer.Name);

            base.OnNavigatedTo(e);
        }

        private void ProjectsGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Frame.Navigate(typeof(ProjectPage), e.ClickedItem);
        }

        private void ProjectsGridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ProjectsGridView.SelectedItems.Count() > 0)
            {
                ProjectsPageAppBar.IsOpen = true;
                ProjectsPageAppBar.IsSticky = true;
                AddButton.Visibility = Visibility.Collapsed;
                EditButton.Visibility = Visibility.Visible;
            }
            else
            {
                ProjectsPageAppBar.IsOpen = false;
                ProjectsPageAppBar.IsSticky = false;
                AddButton.Visibility = Visibility.Visible;
                EditButton.Visibility = Visibility.Collapsed;
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ProjectPage));
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ProjectPage), ProjectsGridView.SelectedItem);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CustomersInfo));
        }

    }
}

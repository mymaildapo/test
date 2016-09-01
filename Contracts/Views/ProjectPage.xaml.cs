using Contracts.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    public sealed partial class ProjectPage : Contracts.Common.LayoutAwarePage
    {

        ProjectViewModel project = null;
        CustomerViewModel customer = null;
        public ProjectPage()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            customer = new CustomerViewModel();
            if (e.Parameter == null)
            {
                project = new ProjectViewModel();
                project.CustomerId = App.CurrentCustomerId;
                PageTitle.Text = string.Format("{0} new project",
                    customer.GetCustomerName(project.CustomerId));
            }
            else
            {
                project = (ProjectViewModel)e.Parameter;
                PageTitle.Text = string.Format("{0} project",
                    customer.GetCustomerName(project.CustomerId));
            }
            this.DataContext = project;

            base.OnNavigatedTo(e);
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {


            if (NameTextBox.Text == "")
            {
                MessageDialog msgDialog = new MessageDialog("Enter Project name");
                //OK Button

                //Show message
                msgDialog.ShowAsync();
            }
            else if (DescriptionTextBox.Text == "")
            {

                MessageDialog msgDialog = new MessageDialog("Enter Description ");
                //OK Button

                //Show message
                msgDialog.ShowAsync();

            }
            else if (DueDateTextBox.Text == "")
            {

                MessageDialog msgDialog = new MessageDialog("Enter Date ");
                //OK Button

                //Show message
                msgDialog.ShowAsync();

            }

            else { 
                        string result = project.SaveProject(project);
                        if (result.Contains("Success"))
                        {
                            this.Frame.Navigate(typeof(ProjectsPage),
                                customer.GetCustomer(project.CustomerId));
                        }

                  }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
           

            if (NameTextBox.Text == "")
            {
                MessageDialog msgDialog = new MessageDialog("CANT BE DELETED");
                //OK Button

                //Show message
                msgDialog.ShowAsync();
            }
            else if (DescriptionTextBox.Text == "")
            {

                MessageDialog msgDialog = new MessageDialog("CANT BE DELETED ");
                //OK Button

                //Show message
                msgDialog.ShowAsync();

            }
            else if (DueDateTextBox.Text == "")
            {

                MessageDialog msgDialog = new MessageDialog("CANT BE DELETED ");
                //OK Button

                //Show message
                msgDialog.ShowAsync();

            }

            else
            {
                string result = project.DeleteProject(project.Id);
                if (result.Contains("Success"))
                {
                    this.Frame.Navigate(typeof(ProjectsPage),
                        customer.GetCustomer(project.CustomerId));
                }

            }


        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ProjectsPage),
                customer.GetCustomer(project.CustomerId));
        }

    }
}

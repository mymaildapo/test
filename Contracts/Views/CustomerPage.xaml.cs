
using Contracts.DataModel;
using Contracts.ViewModel;
using System.Text.RegularExpressions;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Contracts.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CustomerPage : Contracts.Common.LayoutAwarePage
    {
        CustomerViewModel customer = null;
        public CustomerPage()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter == null)
            {
                customer = new CustomerViewModel();
                PageTitle.Text = "New customer";
            }
            else
            {
                customer = (CustomerViewModel)e.Parameter;
                PageTitle.Text = customer.Name;
                App.CurrentCustomerId = customer.Id;
            }
            this.DataContext = customer;

            base.OnNavigatedTo(e);
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {


            if (!Regex.IsMatch(NameTextBox.Text.Trim(), @"^[A-Za-z_][a-zA-Z0-9_\s]*$"))
            {
                MessageDialog msgDialog = new MessageDialog("Enter Customer name");
                //OK Button

                //Show message
                msgDialog.ShowAsync();
            }

            else if (CityTextBox.Text == "")
            {
                MessageDialog msgDialog = new MessageDialog("Enter City");
                //OK Button

                //Show message
                msgDialog.ShowAsync();
            }
            //Phone Number Length Validation
            else if (ContactTextBox.Text.Length != 10)
            {
                MessageDialog msgDialog = new MessageDialog("Contact No have to be 10 digits long");
                //OK Button

                //Show message
                msgDialog.ShowAsync();
            }
            else
            {
                string result = customer.SaveCustomer(customer);
                App.CurrentCustomerId = customer.Id;
                if (result.Contains("Success"))
                {
                    this.Frame.Navigate(typeof(CustomersInfo));
                }

            }









         
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
          



            if (NameTextBox.Text == " ")
            {
                MessageDialog msgDialog = new MessageDialog("Cant be deleted");
                //OK Button

                //Show message
                msgDialog.ShowAsync();
            }

            else if (CityTextBox.Text == "")
            {
                MessageDialog msgDialog = new MessageDialog("Cant be deleted");
                //OK Button

                //Show message
                msgDialog.ShowAsync();
            }
            //Phone Number Length Validation
            else if (ContactTextBox.Text.Length != 10)
            {
                MessageDialog msgDialog = new MessageDialog("Cant be deleted");
                //OK Button

                //Show message
                msgDialog.ShowAsync();
            }
            else
            {
                string result = customer.DeleteCustomer(customer.Id);
                if (result.Contains("Success"))
                {
                    this.Frame.Navigate(typeof(CustomersInfo));
                }


            }
        }
     
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CustomersInfo));
        }

    }
}

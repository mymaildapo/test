
using Contracts.Common;
using Contracts.ViewModel;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Navigation;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;



// The Item Detail Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234232

namespace Contracts.Views
{
    /// <summary>
    /// A page that displays details for a single item within a group while allowing gestures to
    /// flip through other items belonging to the same group.
    /// </summary>
    public sealed partial class CustomersInfo : Contracts.Common.LayoutAwarePage
    {
        
        private ObservableDictionary defaultViewModel = new ObservableDictionary();
        CustomersViewModel customersViewModel = null;
        ObservableCollection<CustomerViewModel> customers = null;

        /// <summary>
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public new ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management
        /// </summary>
      

        public CustomersInfo()
        {
            this.InitializeComponent();
           
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="Common.NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session.  The state will be null the first time a page is visited.</param>
      

        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="Common.NavigationHelper.LoadState"/>
        /// and <see cref="Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            customersViewModel = new CustomersViewModel();
            customers = customersViewModel.GetCustomers();
            CustomersViewSource.Source = customers;
            CustomersGridView.SelectedItem = null;

            base.OnNavigatedTo(e);
        }


     

        #endregion


        private void CustomersGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Frame.Navigate(typeof(ProjectsPage), e.ClickedItem);
        }

        private void CustomersGridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CustomersGridView.SelectedItems.Count() > 0)
            {
                MainPageAppBar.IsOpen = true;
                MainPageAppBar.IsSticky = true;
                AddButton.Visibility = Visibility.Collapsed;
                EditButton.Visibility = Visibility.Visible;
            }
            else
            {
                MainPageAppBar.IsOpen = false;
                MainPageAppBar.IsSticky = false;
                AddButton.Visibility = Visibility.Visible;
                EditButton.Visibility = Visibility.Collapsed;
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CustomerPage));
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CustomerPage), CustomersGridView.SelectedItem);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}


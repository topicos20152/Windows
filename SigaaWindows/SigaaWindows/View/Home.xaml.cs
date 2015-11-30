using SigaaWindows.Adapter;
using SigaaWindows.Model;
using SigaaWindows.Proxy;
using SigaaWindows.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SigaaWindows.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Home : Page
    {
        TasksViewModel tasksViewModel;
        CoursesViewModel courseViewModel;

        public Home()
        {
            this.InitializeComponent();
            tasksViewModel = new TasksViewModel();
            tasksViewModel.GetUserTasks();            
            this.DataContext = tasksViewModel;

            courseViewModel = new CoursesViewModel();
            courseViewModel.GetUserCourses();
            menuPanel.DataContext = courseViewModel;
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MainSplitView.IsPaneOpen = !MainSplitView.IsPaneOpen;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.Frame.Navigate(typeof(TaskDetails), tasksViewModel.SelectedTask);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
        }

        private void ListView_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            Course course = listCourses.SelectedItem as Course;
            tasksViewModel.FilterTasksByCourse(course);
            listTasks.ItemsSource = tasksViewModel.Tasks;
            MainSplitView.IsPaneOpen = false;
        }

        private void ShowAllTasksButton_Click(object sender, RoutedEventArgs e)
        {
            tasksViewModel.ClearFilter();
            listTasks.ItemsSource = tasksViewModel.Tasks;
            MainSplitView.IsPaneOpen = false;
        }
    }
}

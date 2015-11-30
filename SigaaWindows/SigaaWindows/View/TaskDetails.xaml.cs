using SigaaWindows.Adapter;
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
    public sealed partial class TaskDetails : Page
    {
        TasksViewModel viewModel;

        public TaskDetails()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            Model.Task task = e.Parameter as Model.Task;

            //TaskProxy taskProxy = new TaskProxy();
            //TaskAdapter taskAdapter = new TaskAdapter();
            //var taskDetails = taskAdapter.GetTask(taskProxy.GetTaskDetails(task.ID));
            
            this.DataContext = task;

            //viewModel = new TasksViewModel();
            //viewModel.GetTaskDetails(task);
            //this.DataContext = viewModel.SelectedTask;
        }
    }
}

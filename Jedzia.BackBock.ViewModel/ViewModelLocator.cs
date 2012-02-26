﻿/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:Jedzia.BackBock.ViewModel"
                                   x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"
*/


using Microsoft.Practices.ServiceLocation;
using Jedzia.BackBock.ViewModel.MainWindow;
using Jedzia.BackBock.ViewModel.MVVM.Ioc;

namespace Jedzia.BackBock.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// <para>
    /// Use the <strong>mvvmlocatorproperty</strong> snippet to add ViewModels
    /// to this locator.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm/getstarted
    /// </para>
    /// </summary>
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            if (ViewModelBase.IsInDesignModeStatic)
            {
                // SimpleIoc.Default.Register<IDataService, Design.DesignDataService>();
            }
            else
            {
                // SimpleIoc.Default.Register<IDataService, DataService>();
            }

            //SimpleIoc.Default.Register<MainWindowViewModel>(CreateMainWindowViewModel);
        }

        //private MainWindowViewModel CreateMainWindowViewModel()
        //{
            //return new MainWindowViewModel(App.ApplicationViewModel, this); 
        //}

        /// <summary>
        /// Gets the Main property.
        /// </summary>
        public static MainWindowViewModel MainStatic
        {
            get
            {
                if (_main == null)
                {
                    CreateMain();
                }

                return _main;
            }
        }
        /// <summary>
        /// Provides a deterministic way to create the Main property.
        /// </summary>
        public static void CreateMain()
        {
            if (_main == null)
            {
                //_main = new MainWindowViewModel();
                _main = ServiceLocator.Current.GetInstance<MainWindowViewModel>();
            }
        }

        private static MainWindowViewModel _main;

        /// <summary>
        /// Gets the Main property.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public MainWindowViewModel Main
        {
            get
            {
                return MainStatic;
            }
        }
    }
}
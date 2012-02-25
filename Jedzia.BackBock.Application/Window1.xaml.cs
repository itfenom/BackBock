﻿namespace Jedzia.BackBock.Application
{
    using System.Windows;
    using Jedzia.BackBock.ViewModel;
    using Jedzia.BackBock.ViewModel.MainWindow;
    using System.Collections.Generic;
    using System.Windows.Controls;
    using System.ComponentModel;
    using System.Collections;
    using Jedzia.BackBock.ViewModel.Data;
    //    using Jedzia.BackBock.Application.Resources.Styles.Resources.Styles;

    public partial class Window1 : MainWindowBase
    {
        public Window1()
        {
            //mainWindowViewModel = new MainWindowViewModel(this);
            InitializeComponent();

            //this.DataContext = this;
            //this.InputBindings

        }

        protected override IMainWorkArea GetDesigner()
        {
            return this.MyDesigner;
        }

        MainWindowViewModel mainWindowViewModel;

        public override MainWindowViewModel MainWindowViewModel
        {
            get
            {
                if (mainWindowViewModel == null)
                {
                    mainWindowViewModel = new MainWindowViewModel(App.ApplicationViewModel, this);
                }
                return mainWindowViewModel;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*Classlistbox_xaml res = new Classlistbox_xaml();
            res.InitializeComponent();
            var exp = res["ClassListDataTemplate-CSharp"];*/
            //wpg.Instance = this.MyDesigner.DataContext;
            var modl = (BackupDataViewModel)MyDesigner.DataContext;
            ShowDetail(modl.BackupItems[0]);
        }

        private void MainWindowBase_Initialized(object sender, System.EventArgs e)
        {
            // Register necessary designer sub windows. Todo: Maybe this can be static.
            //ClassSpecificationWindow wnd = new ClassSpecificationWindow();
            //wnd.ShowDialog();
        }

        static Window1()
        {
            ApplicationViewModel.RegisterControl(BackupItemViewModel.WindowTypes.TaskEditor,
                typeof(Editors.TaskEditorWindow));
        }

        public /*override*/ void ShowDetail(object val)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(val);
            var col = new WPG.Themes.TypeEditors.CollectionEditorControl();
            col.MyProperty = new WPG.Data.Property(val, properties["Paths"]);
            //col.MyProperty. IsReadOnly = false;
            //col.NumerableType = typeof(PathViewModel);
            col.NumerableType = val.GetType();
            col.NumerableValue = ((BackupItemViewModel)val).Paths;
            var pg = new WPG.TypeEditors.CollectionEditorWindow(col);
            pg.ShowDialog();
        }
    }

}

﻿// <copyright file="$FileName$" company="$Company$">
// Copyright (c) 2008 All Right Reserved
// </copyright>
// <author>Jedzia</author>
// <email>jed69@gmx.de</email>
// <date>$date$</date>
// <summary>$summary$</summary>
namespace Jedzia.BackBock.ViewModel.MainWindow
{
    using System.Windows;
    using System.Windows.Input;
    using Jedzia.BackBock.ViewModel.Commands;
    using System.Xml;
    using System.Xml.Serialization;
    using System.Windows.Controls;
    using System.Collections.Generic;

    public sealed class MainWindowCommandModel //: INotifyPropertyChanged
    {
        #region Fields

        private readonly IMainWorkArea mainWorkArea;
        //private DesignerCanvasCommandModel designerCommands;

        #endregion

        //private IMainWindow mainWindow;

        #region Constructors

        public MainWindowCommandModel(IMainWindow mainWindow)
        {
            //this.mainWindow = mainWindow;
            this.mainWorkArea = mainWindow.Designer;
        }

        #endregion

        #region Test Command Nr. 1

        #region Fields

        private RelayCommand test1Command;

        #endregion

        #region Properties

        public ICommand Test1Command
        {
            get
            {
                if (this.test1Command == null)
                {
                    this.test1Command = new RelayCommand(
                        this.Test1_Executed, this.Test1_Enabled);
                }

                return this.test1Command;
            }
        }

        #endregion

        private bool Test1_Enabled(object sender6)
        {
            return true;
        }

        private void Test1_Executed(object sender8)
        {

            //int xay = 4;
            //MessageBox.Show(sender8.ToString());
            //this.mainWorkArea.DesignerPlacementProcessor.DistributeVertical_Executed(sender8);

            //XmiStuff();

            var resnames = this.GetType().Assembly.GetManifestResourceNames();
            var res = this.GetType().Assembly.GetManifestResourceStream("Jedzia.BackBock.ViewModel.Resources.Images.brace.png");
            //var x = Jedzia.BackBock.ViewModel.Diagram.StencilType.repository;
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();

        }


        #region Test2Command Command

        private RelayCommand test2Command;

        public ICommand Test2Command
        {
            get
            {
                // See S.142 Listing 5–18. Using Attached Command Behavior to Add Double-Click Functionality to a List Item
                if (this.test2Command == null)
                {
                    this.test2Command = new RelayCommand(this.Test2Executed, this.Test2Enabled);
                }

                return this.test2Command;
            }
        }

        private void Test2Executed(object o)
        {
            //this.Test2Command();
        }

        private bool Test2Enabled(object sender)
        {
            bool canExecute = true;
            return canExecute;
        }
        #endregion






        #endregion

        #region Properties


        /// <summary>
        /// Gets or sets 
        /// </summary>
        public string MyProperty
        {
            get
            {
                return "OlderDepp";
            }
        }

        #endregion

        /*private RelayCommand addAttributeCommand;
        public ICommand AddAttributeCommand
        {
            get
            {
                // See S.142 Listing 5–18. Using Attached Command Behavior to Add Double-Click Functionality to a List Item
                if (this.addAttributeCommand == null)
                {
                    this.addAttributeCommand = new RelayCommand(e => this.AddAttribute_Executed(), this.AddAttribute_Enabled );
                }

                return this.addAttributeCommand;
            }
        }


        private void AddAttribute_Executed()
        {
            mainWorkArea.AddAttributeType();
        }

        private bool AddAttribute_Enabled(object sender)
        {
            bool canExecute = mainWorkArea.SelectionService.CurrentSelection.Count() > 0;
            return canExecute;
        }*/

    }





}
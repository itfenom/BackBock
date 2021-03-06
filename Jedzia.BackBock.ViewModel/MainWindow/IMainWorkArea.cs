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
    using System.Windows.Controls;
    using Jedzia.BackBock.ViewModel.Commands;

    /// <summary>
    /// Specifies the working area of the main application window.
    /// </summary>
    public interface IMainWorkArea : ICanInputBind, ICanCommandBind, IInputElement, ISelectionService
    {
        #region Properties


        /// <summary>
        /// Gets the children of the working area.
        /// </summary>
        UIElementCollection Children { get; }
        
        //object DataContext { get; set; }
        #endregion

    }
}
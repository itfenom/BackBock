﻿namespace Jedzia.BackBock.ViewModel.Converters
{
    using System;
    using System.Globalization;
    using System.Windows;
    using System.Windows.Data;

    public sealed class DisplayModeToVisibility : DependencyObject, IValueConverter
    {
        #region Fields

        public static readonly DependencyProperty InvertProperty =
            DependencyProperty.Register(
                "Invert",
                typeof(bool),
                typeof(DisplayModeToVisibility),
                new FrameworkPropertyMetadata(false));

        #endregion

        #region Properties

        public bool Invert
        {
            get
            {
                return (bool)GetValue(InvertProperty);
            }
            set
            {
                SetValue(InvertProperty, value);
            }
        }

        #endregion

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((value != null) ^ this.Invert)
            {
                return Visibility.Visible.ToString();
            }
            //return "";
            return Visibility.Collapsed.ToString();
            //return "Class";
        }

        // No need to implement converting back on a one-way binding 
        /// <exception cref="NotImplementedException"><c>NotImplementedException</c>.</exception>
        public object ConvertBack(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
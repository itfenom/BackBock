//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:v2.0.50727
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

/*
This code was automatically generated at 02/21/2012 15:48:19 by 
        Jedzia's ViewModel generator.
Changes to this file may be lost if regeneration occurs.
http://xxx.com
*/
// Config = Debug DefaultNamespace = Jedzia.BackBock.ViewModel

using System.Collections.Generic;
using Jedzia.BackBock.SharedTypes;
using Jedzia.BackBock.Model.Data;
using Jedzia.BackBock.ViewModel.MainWindow;


namespace Jedzia.BackBock.ViewModel.Data
{

    /// <summary>
    /// The summary of PathViewModel. BaseType: 
    /// </summary>
    public partial class PathViewModel : ViewModelBase
    {
        internal PathDataType path;

        public PathViewModel(PathDataType path)
        {
            this.path = path;
        }

        // Exclusion. HasFacets: False AttrQName: 
        //                   propertyType: List<Wildcard>, IsChoiceRoot: False, BaseType: 
        //                   ListType: None, HasCommonBaseType: False, xxxx: 
        /// <summary>
        /// The summary. 
        /// </summary>
        private ExclusionViewModelList exclusion;

        public ExclusionViewModelList Exclusions
        {
            get
            {
                if (this.exclusion == null)
                {
                    this.exclusion = new ExclusionViewModelList();
                    foreach (var item in this.path.Exclusion)
                    {
                        var colItem = new ExclusionViewModel(item);
                        colItem.PropertyChanged += OnDataPropertyChanged;
                        this.exclusion.Add(colItem);
                    }
                }
                return this.exclusion;
            }
        }

        // Inclusion. HasFacets: False AttrQName: 
        //                   propertyType: List<Wildcard>, IsChoiceRoot: False, BaseType: 
        //                   ListType: None, HasCommonBaseType: False, xxxx: 
        /// <summary>
        /// The summary. 
        /// </summary>
        private List<InclusionViewModel> inclusion;

        public List<InclusionViewModel> Inclusions
        {
            get
            {
                if (this.inclusion == null)
                {
                    this.inclusion = new List<InclusionViewModel>();
                    foreach (var item in this.path.Inclusion)
                    {
                        var colItem = new InclusionViewModel(item);
                        colItem.PropertyChanged += OnDataPropertyChanged;
                        this.inclusion.Add(colItem);
                    }
                }
                return this.inclusion;
            }
        }

        // Path. HasFacets: False AttrQName: 
        //                   propertyType: System.String, IsChoiceRoot: False, BaseType: 
        //                   ListType: None, HasCommonBaseType: False, xxxx: 
        /// <summary>
        /// Gets or sets the Path. HasFacets: False AttrQName: 
        /// </summary> // Attribute
        /// <value>The Path.</value>
        public System.String Path
        {
            get
            {
                return this.path.Path;
            }

            set
            {
                if (this.path.Path == value)
                {
                    return;
                }
                this.path.Path = value;
                RaisePropertyChanged("Path");
            }
        }
        private System.Windows.Media.Brush myBrush = new System.Windows.Media.SolidColorBrush();
        /// <summary>
        /// Initializes a new instance of the <see cref="T:PathViewModel"/> class.
        /// </summary>

        /// <summary>
        /// Gets or sets 
        /// </summary>
        public System.Windows.Media.Brush MyBrush
        {
            get
            {
                return this.myBrush;
            }

            set
            {
                this.myBrush = value;
            }
        }


        // UserData. HasFacets: False AttrQName: 
        //                   propertyType: System.String, IsChoiceRoot: False, BaseType: 
        //                   ListType: None, HasCommonBaseType: False, xxxx: 
        /// <summary>
        /// Gets or sets the UserData. HasFacets: False AttrQName: 
        /// </summary> // Attribute
        /// <value>The UserData.</value>
        public System.String UserData
        {
            get
            {
                return this.path.UserData;
            }

            set
            {
                if (this.path.UserData == value)
                {
                    return;
                }
                this.path.UserData = value;
                RaisePropertyChanged("UserData");
            }
        }

        protected virtual void OnDataPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            DataPropertyChanged(sender, e);
        }

        partial void DataPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e);

        public PathViewModel Clone()
        {
            return (PathViewModel)this.MemberwiseClone();
        }
    } 
}

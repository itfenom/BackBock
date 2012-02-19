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
This code was automatically generated at 02/19/2012 07:35:36 by 
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
    /// The summary of PathsViewModel. BaseType: 
    /// </summary>
    public partial class PathsViewModel : ViewModelBase
    {
        internal PathDataType paths;

        public PathsViewModel(PathDataType paths)
        {
            this.paths = paths;
        }

        // Exclusion. HasFacets: False AttrQName: 
        //                   propertyType: List<Wildcard>, IsChoiceRoot: False, BaseType: 
        //                   ListType: None, HasCommonBaseType: False, xxxx: 
        /// <summary>
        /// The summary. 
        /// </summary>
        private List<ExclusionViewModel> exclusion;

        public List<ExclusionViewModel> Exclusions
        {
            get
            {
                if (this.exclusion == null)
                {
                    this.exclusion = new List<ExclusionViewModel>();
                    foreach (var item in this.paths.Exclusion)
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
                    foreach (var item in this.paths.Inclusion)
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
                return this.paths.Path;
            }

            set
            {
                if (this.paths.Path == value)
                {
                    return;
                }
                this.paths.Path = value;
                RaisePropertyChanged("Path");
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
                return this.paths.UserData;
            }

            set
            {
                if (this.paths.UserData == value)
                {
                    return;
                }
                this.paths.UserData = value;
                RaisePropertyChanged("UserData");
            }
        }

        protected virtual void OnDataPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            DataPropertyChanged(sender, e);
        }

        partial void DataPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e);

        public PathsViewModel Clone()
        {
            return (PathsViewModel)this.MemberwiseClone();
        }
    } 
}

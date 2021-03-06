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
This code was automatically generated at 02/26/2012 07:08:41 by 
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
    /// The summary of TaskViewModel. BaseType: 
    /// </summary>
    public partial class TaskViewModel : ViewModelBase
    {
        internal TaskType data;

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskViewModel"/> class.
        /// </summary>
        /// <param name="task">The task.</param>
        public TaskViewModel(TaskType task)
        {
            this.data = task;
        }

        // TypeName. HasFacets: False AttrQName: 
        //                   propertyType: System.String, IsChoiceRoot: False, BaseType: 
        //                   ListType: None, HasCommonBaseType: False, xxxx: 
        /// <summary>
        /// Gets or sets the TypeName. HasFacets: False AttrQName:
        /// </summary>
        /// <value>
        /// The TypeName.
        /// </value>
        /// // Attribute
        public System.String TypeName
        {
            get
            {
                return this.data.TypeName;
            }

            set
            {
                if (this.data.TypeName == value)
                {
                    return;
                }
                this.data.TypeName = value;
                RaisePropertyChanged("TypeName");
            }
        }

        /// <summary>
        /// Called when [data property changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.ComponentModel.PropertyChangedEventArgs"/> instance containing the event data.</param>
        protected virtual void OnDataPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            DataPropertyChanged(sender, e);
        }

        /// <summary>
        /// Datas the property changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.ComponentModel.PropertyChangedEventArgs"/> instance containing the event data.</param>
        partial void DataPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e);

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns></returns>
        public TaskViewModel Clone()
        {
            return (TaskViewModel)this.MemberwiseClone();
        }
    } 
}

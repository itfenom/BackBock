﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICanInputBind.cs" company="EvePanix">
//   Copyright (c) Jedzia 2001-2012, EvePanix. All rights reserved.
//   See the license notes shipped with this source and the GNU GPL.
// </copyright>
// <author>Jedzia</author>
// <email>jed69@gmx.de</email>
// <date>$date$</date>
// --------------------------------------------------------------------------------------------------------------------

namespace Jedzia.BackBock.ViewModel.Commands
{
    using System.Windows.Input;

    /// <summary>
    /// Implements input binding capabilities.
    /// </summary>
    public interface ICanInputBind
    {
        #region Properties

        /// <summary>
        /// Gets the collection of input bindings associated with this element.
        /// </summary>
        /// <returns>
        /// The collection of input bindings.
        /// </returns>
        InputBindingCollection InputBindings { get; }

        #endregion
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jedzia.BackBock.Model.Data;

namespace Jedzia.BackBock.ViewModel.Data
{
    public partial class InclusionViewModel : ViewModelBase
    {
        public InclusionViewModel()
        {
            this.data = new Wildcard();
        }
    }
}
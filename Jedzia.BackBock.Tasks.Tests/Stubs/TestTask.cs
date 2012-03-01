﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jedzia.BackBock.Tasks.Tests.Stubs
{
    class TestTask : ITask
    {
        public bool HasExecuted
        {
            get;
            private set;
        }

        #region ITask Members

        public string Name
        {
            get { return "TestTask"; }
        }

        public bool Execute()
        {
            HasExecuted = true;
            return true;
        }

        #endregion
    }
}

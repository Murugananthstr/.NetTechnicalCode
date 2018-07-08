﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapCSharpFundamentals
{
    public class WorkPerformedEventArgs : EventArgs
    {
        public int Hours { get; set; }

        public WorkType WorkType { get; set; }

        public WorkPerformedEventArgs(int hours, WorkType workType)
        {
            Hours = hours;
            WorkType = workType;

        }
    }
}

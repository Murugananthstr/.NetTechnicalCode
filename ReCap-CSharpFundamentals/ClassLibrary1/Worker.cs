using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapCSharpFundamentals
{
    public class Worker
    {
        public event EventHandler<WorkPerformedEventArgs> WorkPerfomed;

        public int Hours { get; set; }

        public WorkType WorkType { get; set; }

        public Worker(WorkPerformedEventArgs ent)
        {
            this.Hours = ent.Hours;
            this.WorkType = ent.WorkType;

        }

        //public void  OnWorkPerformed(int hours, WorkType workType)
        public void OnWorkPerformed(object sender, WorkPerformedEventArgs args)
        {
            this.Hours = this.Hours + args.Hours;

        }
        
    }
}

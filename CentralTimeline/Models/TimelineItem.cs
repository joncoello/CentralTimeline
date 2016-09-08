using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTimeline.Models {
    public class TimelineItem {

        public enum AssignedType {
            Client,
            Practice
        }

        public string Description { get; set; }
        public string Name { get; set; }
        public string Due { get; set; }

        public AssignedType AssignedToType { get; set; }

        public string Assignment { get; set; }
        public bool IsComplete { get; internal set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTimeline.Models {
    public class Timeline {
        public string Name { get; set; }
        public List<TimelineItem> Items { get; private set; }
        public Timeline() {
            Items = new List<TimelineItem>();
        }
    }
}

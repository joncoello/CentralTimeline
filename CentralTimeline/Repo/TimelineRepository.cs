using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTimeline.Repo {
    class TimelineRepository {

        public Models.Timeline GetTimeline() {

            return new Models.Timeline() { Name = "Test01" }; 

        }

    }
}

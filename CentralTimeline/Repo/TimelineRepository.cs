using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTimeline.Repo {
    class TimelineRepository {

        public Models.Timeline GetTimeline() {

            var timeline = new Models.Timeline() { Name = "Timeline" };

            timeline.Items.Add(new Models.TimelineItem() { Assignment = "Personal Tax", Description = "Information requested", Due = "31/04/2016", Name = "Anna Copeland", AssignedToType = Models.TimelineItem.AssignedType.Practice, IsComplete = true });
            timeline.Items.Add(new Models.TimelineItem() { Assignment = "Personal Tax", Description = "Send Data", Due = "20/06/2016", Name = "Anna Copeland", AssignedToType = Models.TimelineItem.AssignedType.Client });
            timeline.Items.Add(new Models.TimelineItem() { Assignment = "Personal Tax", Description = "Information received", Due = "31/06/2016", Name = "Anna Copeland", AssignedToType = Models.TimelineItem.AssignedType.Practice });
            timeline.Items.Add(new Models.TimelineItem() { Assignment = "Personal Tax", Description = "Tax processing", Due = "30/09/2016", Name = "Anna Copeland", AssignedToType = Models.TimelineItem.AssignedType.Practice });
            timeline.Items.Add(new Models.TimelineItem() { Assignment = "Personal Tax", Description = "Review", Due = "31/10/2016", Name = "Anna Copeland", AssignedToType = Models.TimelineItem.AssignedType.Practice });
            timeline.Items.Add(new Models.TimelineItem() { Assignment = "Personal Tax", Description = "Approve", Due = "31/12/2016", Name = "Anna Copeland", AssignedToType = Models.TimelineItem.AssignedType.Client });
            timeline.Items.Add(new Models.TimelineItem() { Assignment = "Personal Tax", Description = "Submit", Due = "31/01/2017", Name = "Anna Copeland", AssignedToType = Models.TimelineItem.AssignedType.Practice });

            return timeline;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTimeline.Repo {
    class TimelineRepository {

        public Models.Timeline GetTimeline() {

            var timeline = new Models.Timeline() { Name = "Timeline" };

            timeline.Items.Add(new Models.TimelineItem() { Assignment = "Personal Tax", Description = "Information requested", DueDate = DateTime.Parse("30/04/2016"), Name = "Anna Copeland", AssignedToType = Models.TimelineItem.AssignedType.Practice, IsComplete = true });
            timeline.Items.Add(new Models.TimelineItem() { Assignment = "Personal Tax", Description = "Send Data", DueDate = DateTime.Parse("20/06/2016"), Name = "Anna Copeland", AssignedToType = Models.TimelineItem.AssignedType.Client });
            timeline.Items.Add(new Models.TimelineItem() { Assignment = "Personal Tax", Description = "Information received", DueDate = DateTime.Parse("30/06/2016"), Name = "Anna Copeland", AssignedToType = Models.TimelineItem.AssignedType.Practice });
            timeline.Items.Add(new Models.TimelineItem() { Assignment = "Personal Tax", Description = "Tax processing", DueDate = DateTime.Parse("30/09/2016"), Name = "Anna Copeland", AssignedToType = Models.TimelineItem.AssignedType.Practice });
            timeline.Items.Add(new Models.TimelineItem() { Assignment = "Personal Tax", Description = "Review", DueDate = DateTime.Parse("31/10/2016"), Name = "Anna Copeland", AssignedToType = Models.TimelineItem.AssignedType.Practice });
            timeline.Items.Add(new Models.TimelineItem() { Assignment = "Personal Tax", Description = "Approve", DueDate = DateTime.Parse("31/12/2016"), Name = "Anna Copeland", AssignedToType = Models.TimelineItem.AssignedType.Client });
            timeline.Items.Add(new Models.TimelineItem() { Assignment = "Personal Tax", Description = "Submit", DueDate = DateTime.Parse("31/01/2017"), Name = "Anna Copeland", AssignedToType = Models.TimelineItem.AssignedType.Practice });

            return timeline;

        }

    }
}

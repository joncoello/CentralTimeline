using CentralTimeline.Controls;
using CentralTimeline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTimelineTests {
    class TimelineItemControllerBuilder {

        private readonly TimelineItem _item;

        public TimelineItemControllerBuilder() {
            _item = new TimelineItem();
        }

        public TimelineItemControllerBuilder WithName(string name) {
            _item.Name = name;
            return this;
        }

        public TimelineItemControllerBuilder WithDescription(string description) {
            _item.Description = description;
            return this;
        }

        public TimelineItemControllerBuilder WithAssignedToType(TimelineItem.AssignedType assignedToType) {
            _item.AssignedToType = assignedToType;
            return this;
        }

        public TimelineItemControllerBuilder WithAssignment(string assignment) {
            _item.Assignment = assignment;
            return this;
        }

        public TimelineItemControllerBuilder WithDue(string due) {
            _item.Due = due;
            return this;
        }

        public TimelineItemControllerBuilder WithIsComplete(bool isComplete) {
            _item.IsComplete = isComplete;
            return this;
        }

        public TimelineItemController Build() {
            return new TimelineItemController(_item);
        }

    }
}

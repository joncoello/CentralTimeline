using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CentralTimelineTests {
    [TestClass]
    public class TimelineItemControllerTests {

        [TestMethod]
        public void TimelineItemController_Create() {

            var item = new CentralTimeline.Models.TimelineItem();

            var sut = new CentralTimeline.Controls.TimelineItemController(item);

        }

    }
}

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

        [TestMethod]
        public void TimelineItemController_NameLabel() {

            var expected = "Step 1";

            var item = new CentralTimeline.Models.TimelineItem() {
                Name = expected
            };

            var sut = new CentralTimeline.Controls.TimelineItemController(item);

            Assert.AreEqual(expected, sut.Item.Name);

        }

    }
}

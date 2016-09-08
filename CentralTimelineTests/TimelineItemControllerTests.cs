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
        public void TimelineItemController_Labels() {

            var expectedName = "Step 1";
            var expectedDescription = "Description 1";
            var expectedAssignedToType = CentralTimeline.Models.TimelineItem.AssignedType.Client;
            var expectedAssignment = "Tax";
            var expectedDue = "1234";
            var expectedIsComplete = true;

            var item = new CentralTimeline.Models.TimelineItem() {
                Name = expectedName,
                Description = expectedDescription,
                AssignedToType = expectedAssignedToType,
                Assignment = expectedAssignment,
                Due = expectedDue,
                IsComplete = expectedIsComplete
            };

            var sut = new CentralTimeline.Controls.TimelineItemController(item);

            Assert.AreEqual(expectedName, sut.Item.Name);
            Assert.AreEqual(expectedDescription, sut.Item.Description);
            Assert.AreEqual(expectedAssignedToType, sut.Item.AssignedToType);
            Assert.AreEqual(expectedAssignment, sut.Item.Assignment);
            Assert.AreEqual(expectedDue, sut.Item.Due);
            Assert.AreEqual(expectedIsComplete, sut.Item.IsComplete);

        }

    }
}

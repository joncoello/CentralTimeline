using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralTimeline.Models;
using CentralTimeline.Controls;
using System.Drawing;

namespace CentralTimelineTests {
    [TestClass]
    public class TimelineItemControllerTests {

        #region constants
        private const string expectedName = "Step 1";
        private const string expectedDescription = "Description 1";
        private const TimelineItem.AssignedType expectedAssignedToType = TimelineItem.AssignedType.Client;
        private const string expectedAssignment = "Tax";
        private DateTime expectedDue = DateTime.Parse("12/10/2016");
        private const bool expectedIsComplete = false;
        #endregion

        [TestMethod]
        public void TimelineItemController_Create() {
            var item = new TimelineItem();
            var sut = new TimelineItemController(item);
        }

        [TestMethod]
        public void TimelineItemController_Labels() {

            var sut = CreateSUT();

            Assert.AreEqual(expectedName, sut.Item.Name);
            Assert.AreEqual(expectedDescription, sut.Item.Description);
            Assert.AreEqual(expectedAssignedToType, sut.Item.AssignedToType);
            Assert.AreEqual(expectedAssignment, sut.Item.Assignment);
            Assert.AreEqual(expectedDue, sut.Item.DueDate);
            Assert.AreEqual(expectedIsComplete, sut.Item.IsComplete);

        }

        [TestMethod]
        public void TimelineItemController_MouseEntersControl_BackColorChanges() {

            var sut = CreateSUT();

            Assert.AreEqual(Color.White, sut.Item.ControlBackColour);

            sut.MouseEntersControl();

            Assert.AreEqual(Color.WhiteSmoke, sut.Item.ControlBackColour);

            sut.MouseLeavesControl();

            Assert.AreEqual(Color.White, sut.Item.ControlBackColour);

        }

        [TestMethod]
        public void TimelineItemController_MouseEntersControl_SizeChanges() {

            var sut = CreateSUT();

            Assert.AreEqual(TimelineItemController.COLLAPSED_HEIGHT, sut.Item.Height);

            sut.MouseEntersControl();

            Assert.AreEqual(TimelineItemController.EXPANDED_HEIGHT, sut.Item.Height);

            sut.MouseLeavesControl();

            Assert.AreEqual(TimelineItemController.COLLAPSED_HEIGHT, sut.Item.Height);

        }

        [TestMethod]
        public void TimelineItemController_MouseEntersControl_ControlVisibilityChanges() {

            var sut = CreateSUT();

            Assert.AreEqual(false, sut.Item.AssignmentVisible);

            sut.MouseEntersControl();

            Assert.AreEqual(true, sut.Item.AssignmentVisible);

            sut.MouseLeavesControl();

            Assert.AreEqual(false, sut.Item.AssignmentVisible);

        }

        [TestMethod]
        public void TimelineItemController_SignOffTask_StaysExpanded() {

            var sut = CreateSUT();

            sut.MouseEntersControl();

            sut.Item.IsComplete = true;

            sut.MouseLeavesControl();

            Assert.AreEqual(TimelineItemController.EXPANDED_HEIGHT, sut.Item.Height);

        }

        [TestMethod]
        public void TimelineItemController_SignOffTask_CheckBoxHidden() {

            var sut = CreateSUT();

            sut.MouseEntersControl();

            Assert.AreEqual(true, sut.Item.IsCompleteVisible);

            sut.Item.IsComplete = true;

            Assert.AreEqual(false, sut.Item.IsCompleteVisible);
            Assert.AreEqual(true, sut.Item.LoadingIconVisible);


        }

        [TestMethod]
        public void TimelineItemController_StartWithComplete_IsExpanded() {

            var builder = CreateDefaultSUTBuilder();
            builder.WithIsComplete(true);
            var sut = builder.Build();

            Assert.AreEqual(TimelineItemController.EXPANDED_HEIGHT, sut.Item.Height);

        }

        #region sut builder

        private TimelineItemController CreateSUT() {

            var builder = CreateDefaultSUTBuilder();
            var sut = builder.Build();
            return sut;

        }

        private TimelineItemControllerBuilder CreateDefaultSUTBuilder() {

            var builder = new TimelineItemControllerBuilder();
            builder
                .WithName(expectedName)
                .WithDescription(expectedDescription)
                .WithAssignedToType(expectedAssignedToType)
                .WithAssignment(expectedAssignment)
                .WithDue(expectedDue)
                .WithIsComplete(expectedIsComplete);

            return builder;

        }

        #endregion

    }
}

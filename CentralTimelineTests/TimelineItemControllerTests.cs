using System;
using CentralTimeline.Models;
using CentralTimeline.Controls;
using System.Drawing;
using Xunit;

namespace CentralTimelineTests {
    
    public class TimelineItemControllerTests {

        #region constants
        private const string expectedName = "Step 1";
        private const string expectedDescription = "Description 1";
        private const TimelineItem.AssignedType expectedAssignedToType = TimelineItem.AssignedType.Client;
        private const string expectedAssignment = "Tax";
        private DateTime expectedDue = DateTime.Now.AddDays(10);
        private const bool expectedIsComplete = false;
        #endregion

        [Fact]
        public void TimelineItemController_Create() {
            var item = new TimelineItem();
            var sut = new TimelineItemController(item);
        }

        [Fact]
        public void TimelineItemController_Labels() {

            var sut = CreateSUT();

            Assert.Equal(expectedName, sut.Item.Name);
            Assert.Equal(expectedDescription, sut.Item.Description);
            Assert.Equal(expectedAssignedToType, sut.Item.AssignedToType);
            Assert.Equal(expectedAssignment, sut.Item.Assignment);
            Assert.Equal(expectedDue, sut.Item.DueDate);
            Assert.Equal(expectedIsComplete, sut.Item.IsComplete);

        }

        [Fact]
        public void TimelineItemController_MouseEntersControl_BackColorChanges() {

            var sut = CreateSUT();

            Assert.Equal(Color.White, sut.Item.ControlBackColour);

            sut.MouseEntersControl();

            Assert.Equal(Color.WhiteSmoke, sut.Item.ControlBackColour);

            sut.MouseLeavesControl();

            Assert.Equal(Color.White, sut.Item.ControlBackColour);

        }

        [Fact]
        public void TimelineItemController_MouseEntersControl_SizeChanges() {

            var sut = CreateSUT();

            Assert.Equal(TimelineItemController.COLLAPSED_HEIGHT, sut.Item.Height);

            sut.MouseEntersControl();

            Assert.Equal(TimelineItemController.EXPANDED_HEIGHT, sut.Item.Height);

            sut.MouseLeavesControl();

            Assert.Equal(TimelineItemController.COLLAPSED_HEIGHT, sut.Item.Height);

        }

        [Fact]
        public void TimelineItemController_MouseEntersControl_ControlVisibilityChanges() {

            var sut = CreateSUT();

            Assert.Equal(false, sut.Item.AssignmentVisible);

            sut.MouseEntersControl();

            Assert.Equal(true, sut.Item.AssignmentVisible);

            sut.MouseLeavesControl();

            Assert.Equal(false, sut.Item.AssignmentVisible);

        }

        [Fact]
        public async void TimelineItemController_SignOffTask_StaysExpanded() {

            var sut = CreateSUT();

            sut.MouseEntersControl();

            await sut.ChangeIsComplete(true);

            sut.MouseLeavesControl();

            Assert.Equal(TimelineItemController.EXPANDED_HEIGHT, sut.Item.Height);

        }

        [Fact]
        public void TimelineItemController_SignOffTask_CheckBoxHidden() {

            var sut = CreateSUT();

            sut.MouseEntersControl();

            Assert.Equal(true, sut.Item.IsCompleteVisible);

            sut.ChangeIsComplete(true);

            Assert.Equal(false, sut.Item.IsCompleteVisible);
            Assert.Equal(true, sut.Item.LoadingIconVisible);


        }

        [Fact]
        public void TimelineItemController_StartWithComplete_IsExpanded() {

            var builder = CreateDefaultSUTBuilder();
            builder.WithIsComplete(true);
            var sut = builder.Build();

            Assert.Equal(TimelineItemController.EXPANDED_HEIGHT, sut.Item.Height);

        }

        [Fact]
        public async void TimelineItemController_StartWithOverdue_OverdueIndicated() {

            var builder = CreateDefaultSUTBuilder();
            builder.WithDue(DateTime.Now.AddDays(-1));
            var sut = builder.Build();

            Assert.Equal(Pens.Red, sut.Item.BorderColour);
            Assert.True(sut.Item.OverdueIconVisible);

            await sut.ChangeIsComplete(true);

            Assert.Equal(Pens.LightGray, sut.Item.BorderColour);
            Assert.False(sut.Item.OverdueIconVisible);

            await sut.ChangeIsComplete(false);

            Assert.Equal(Pens.Red, sut.Item.BorderColour);
            Assert.True(sut.Item.OverdueIconVisible);

        }

        [Fact]
        public async void TimelineItemController_StartWithComplete_ToggleSignOff_TestHeight() {

            var builder = CreateDefaultSUTBuilder();
            builder.WithIsComplete(true);
            var sut = builder.Build();

            sut.MouseEntersControl();

            var task = sut.ChangeIsComplete(false);

            sut.MouseLeavesControl();

            await task;

            Assert.Equal(TimelineItemController.COLLAPSED_HEIGHT, sut.Item.Height);

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

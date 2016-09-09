using CentralTimeline.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTimeline.Controls {
    public class TimelineItemController {

        public readonly TimelineItemView Item;
        public Brush PanelBrush = Brushes.White;

        public const int COLLAPSED_HEIGHT = 50;
        public const int EXPANDED_HEIGHT = 100;

        public event EventHandler Highlighted;

        public TimelineItemController(TimelineItem item) {
            Item = new TimelineItemView() {
                AssignedToType = item.AssignedToType,
                Assignment = item.Assignment,
                Description = item.Description,
                DueDate = item.DueDate,
                IsComplete = !item.IsComplete,
                Name = item.Name
            };
            Item.PropertyChanged += Item_PropertyChanged;
            MouseEntersControl();
            Item.IsComplete = item.IsComplete;
            MouseLeavesControl();
        }

        private async void Item_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e) {
            switch (e.PropertyName) {
                case "IsComplete":
                    await IsCompleteChanged();
                    break;
            }
        }

        private async Task IsCompleteChanged() {

            Item.LoadingIconImage = CentralTimeline.Properties.Resources.ajax_loader;

            // if the item has been marked complete then hide the checkbox control and show the loading image
            if (Item.IsComplete) {
                Item.IsCompleteVisible = false;
                Item.LoadingIconVisible = true;
            }

            if (Item.IsComplete) {
                Item.ControlBackColour = Color.WhiteSmoke;
                Item.DescriptionForeColour = Color.LightGray;
                Item.ControlForeColour = Color.LightGray;
            } else {
                Item.ControlBackColour = Color.White;
                Item.DescriptionForeColour = SystemColors.ControlText;
                Item.ControlForeColour = Color.Black;
            }

            await Task.Run(() => {
                System.Threading.Thread.Sleep(2000);
            });

            Item.LoadingIconImage = CentralTimeline.Properties.Resources.check2;

            if (!Item.IsComplete) {
                Item.IsCompleteVisible = true;
                Item.LoadingIconVisible = false;
            }

        }

        public void MouseEntersControl() {
            Highlight(true);
        }

        public void MouseLeavesControl() {
            Highlight(false);
        }

        public void Highlight(bool proposedState) {
            if (!Item.IsComplete) {

                Item.AssignmentVisible = proposedState;

                if (proposedState) {
                    PanelBrush = Brushes.WhiteSmoke;
                    Item.ControlBackColour = Color.WhiteSmoke;
                    Item.Height = EXPANDED_HEIGHT;
                    if (this.Highlighted != null) {
                        this.Highlighted(this, EventArgs.Empty);
                    }
                } else {
                    PanelBrush = Brushes.White;
                    Item.ControlBackColour = Color.White;
                    Item.Height = COLLAPSED_HEIGHT;
                }
                //this.Refresh();
            }
        }

    }

}

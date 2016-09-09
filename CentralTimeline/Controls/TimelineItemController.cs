using CentralTimeline.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTimeline.Controls {
    public class TimelineItemController {

        private bool _lastState;
        private bool _isCompleteChanging;

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
                _isComplete = item.IsComplete,
                Name = item.Name,
                Height = item.IsComplete ? EXPANDED_HEIGHT : COLLAPSED_HEIGHT,
                IsCompleteVisible = !item.IsComplete,
                LoadingIconVisible = item.IsComplete,
                LoadingIconImage = CentralTimeline.Properties.Resources.check2
        };
            SetStandardVisualProperties();
        }

        private async Task IsCompleteChanged(bool isComplete) {

            _isCompleteChanging = true;

            if (isComplete) {
                Item.IsComplete = true;
            }

            Item.LoadingIconImage = CentralTimeline.Properties.Resources.ajax_loader;

            // if the item has been marked complete then hide the checkbox control and show the loading image
            if (isComplete) {
                Item.IsCompleteVisible = false;
                Item.LoadingIconVisible = true;
            }

            SetStandardVisualProperties();

            await Task.Run(() => {
                System.Threading.Thread.Sleep(2000);
            });

            Item.LoadingIconImage = CentralTimeline.Properties.Resources.check2;

            if (!isComplete) {
                Item.IsCompleteVisible = true;
                Item.LoadingIconVisible = false;
                Item.Height = COLLAPSED_HEIGHT;
            }

            Item.IsComplete = isComplete;
            SetStandardVisualProperties();

            _isCompleteChanging = false;
            
            Highlight(Item.MouseIsInPanel);

        }

        private void SetStandardVisualProperties() {
            if (Item.IsComplete) {
                Item.ControlBackColour = Color.WhiteSmoke;
                Item.DescriptionForeColour = Color.LightGray;
                Item.ControlForeColour = Color.LightGray;
                Item.OverdueIconVisible = false;
                Item.BorderColour = Pens.LightGray;
            } else {
                Item.ControlBackColour = Color.White;
                Item.DescriptionForeColour = SystemColors.ControlText;
                Item.ControlForeColour = Color.Black;
                Item.OverdueIconVisible = Item.DueDate < DateTime.Now;
                Item.BorderColour = Item.DueDate < DateTime.Now ? Pens.Red : Pens.LightGray;
            }
        }

        public void MouseEntersControl() {
            _lastState = true;
            Highlight(true);
        }

        public void MouseLeavesControl() {
            _lastState = false;
            Highlight(false);
        }

        public void Highlight(bool proposedState) {
            if (!_isCompleteChanging && !Item.IsComplete) {

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

        public async Task ChangeIsComplete(bool value) {
            await IsCompleteChanged(value);
        }

    }

}

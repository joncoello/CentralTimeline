using CentralTimeline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CentralTimeline.Controls {
    public class TimelineItemView : TimelineItem {

        private Color _controlBackColour;
        public Color ControlBackColour {
            get {
                return _controlBackColour;
            }
            set {
                if (value != _controlBackColour) {
                    _controlBackColour = value;
                    FirePropertyChanged("ControlBackColour");
                }
            }
        }

        private Color _controlForeColour;
        public Color ControlForeColour {
            get {
                return _controlForeColour;
            }
            set {
                if (value != _controlForeColour) {
                    _controlForeColour = value;
                    FirePropertyChanged("ControlForeColour");
                }
            }
        }

        private Color _descriptionForeColour;
        public Color DescriptionForeColour {
            get {
                return _descriptionForeColour;
            }
            set {
                if (value != _descriptionForeColour) {
                    _descriptionForeColour = value;
                    FirePropertyChanged("DescriptionForeColour");
                }
            }
        }

        private bool _isCompleteVisible = true;
        public bool IsCompleteVisible {
            get {
                return _isCompleteVisible;
            }
            set {
                if (value != _isCompleteVisible) {
                    _isCompleteVisible = value;
                    FirePropertyChanged("IsCompleteVisible");
                }
            }
        }

        private Image _loadingIconImage;
        public Image LoadingIconImage {
            get {
                return _loadingIconImage;
            }
            set {
                if (value != _loadingIconImage) {
                    _loadingIconImage = value;
                    FirePropertyChanged("LoadingIconImage");
                }
            }
        }

        private bool _LoadingIconVisible;
        public bool LoadingIconVisible {
            get {
                return _LoadingIconVisible;
            }
            set {
                if (value != _LoadingIconVisible) {
                    _LoadingIconVisible = value;
                    FirePropertyChanged("LoadingIconVisible");
                }
            }
        }

        private bool _assignmentVisible;
        public bool AssignmentVisible {
            get {
                return _assignmentVisible;
            }
            set {
                if (value != _assignmentVisible) {
                    _assignmentVisible = value;
                    FirePropertyChanged("AssignmentVisible");
                }
            }
        }

        private int _height;
        public int Height {
            get {
                return _height;
            }
            set {
                if (value != _height) {
                    _height = value;
                    FirePropertyChanged("Height");
                }
            }
        }

        public Pen _borderColour;
        public Pen BorderColour {
            //get {
            //    return OverdueIconVisible ? Pens.Red : Pens.LightGray;
            //}
            get {
                return _borderColour;
            }
            set {
                if (value != _borderColour) {
                    _borderColour = value;
                    FirePropertyChanged("BorderColour");
                }
            }
        }

        public bool _overdueIconVisible;
        public bool OverdueIconVisible {
            //get {
            //    return !IsComplete && DueDate < DateTime.Today;
            //}
            get {
                return _overdueIconVisible;
            }
            set {
                if (value != _overdueIconVisible) {
                    _overdueIconVisible = value;
                    FirePropertyChanged("OverdueIconVisible");
                }
            }
        }

        public bool _isCompleteChecked;
        public bool IsCompleteChecked {
            get {
                return _isCompleteChecked;
            }
            set {
                if (value != _isCompleteChecked) {
                    _isCompleteChecked = value;
                    FirePropertyChanged("IsCompleteChecked");
                }
            }
        }

        public bool MouseIsInPanel { get; set; }

        public TimelineItemView() {

        }

    }
}

﻿using CentralTimeline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CentralTimeline.Controls {
    class TimelineItemView : TimelineItem {

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

        public TimelineItemView() {
            
        } 

    }
}
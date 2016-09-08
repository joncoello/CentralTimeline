using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTimeline.Models {
    public class TimelineItem : INotifyPropertyChanged {
        
        public enum AssignedType {
            Client,
            Practice
        }
        
        public string Description { get; set; }
        public string Name { get; set; }
        public string Due { get; set; }
        public AssignedType AssignedToType { get; set; }
        public string Assignment { get; set; }

        private bool _isComplete;
        public bool IsComplete {
            get {
                return _isComplete;
            }
            set {
                if (value != _isComplete) {
                    _isComplete = value;
                    FirePropertyChanged("IsComplete");
                }
            }
        }
        
        public void FirePropertyChanged(string propertyName) {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}

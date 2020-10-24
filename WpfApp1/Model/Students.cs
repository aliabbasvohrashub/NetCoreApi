using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class Students : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int studentId;
        public int StudentId
        {
            get
            {
                return studentId;
            }
            set
            {
                studentId = value;
                OnPropertyChanged("StudentId"); 
                OnPropertyChanged("StudentName");
            }
        }

        private string studentName;
        public string StudentName
        {
            get
            {
                return studentName;
            }
            set
            {
                studentName = value;
                OnPropertyChanged("StudentId");
                OnPropertyChanged("StudentName");
            }
        }
          
        public string Combined
        {
            get { return $"{studentId} : {studentName}"; }
        }


        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }  
        }
    }
}

using System.Collections.ObjectModel;
using WpfApp1.Model;

namespace WpfApp1.ViewModel
{
    public class StudentViewModel
    {
        public ObservableCollection<Students> StudentsList { get; set; }
        public StudentViewModel()
        {
            Loaded();
        }

        public void Loaded()
        {
            StudentsList = new ObservableCollection<Students>
            {
                new Students { StudentId = 1, StudentName = "a" },
                new Students { StudentId = 2, StudentName = "b" },
                new Students { StudentId = 3, StudentName = "c" },
                new Students { StudentId = 4, StudentName = "d" },
                new Students { StudentId = 5, StudentName = "e" }
            };
        }
    }
}

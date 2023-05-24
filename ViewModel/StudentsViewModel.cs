using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.Command;
using WpfApp1.Model;

namespace WpfApp1.ViewModel
{
    public class StudentsViewModel : INotifyPropertyChanged
    {
        #region Member Variabls
        ObservableCollection<Students> studentlist = new ObservableCollection<Students>();
        ObservableCollection<Students> studentlist2 = new ObservableCollection<Students>();
        public string F_Name { get; set; }
        public string L_Name { get; set; }
        public int age { get; set; }
        public Students.Subject subject { get; set; }
        public Students.Subject subject2 { get; set; }
        int _count;
        #endregion

        #region Event
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion

        #region Property
        public ObservableCollection<Students> Studentlist
        {
            set
            {
                studentlist = value;
                OnPropertyChanged();
            }
            get
            {
                return studentlist;
            }
        }
        public ObservableCollection<Students> Studentlist2
        {
            set
            {
                studentlist2 = value;
                OnPropertyChanged();
            }
            get
            {
                return studentlist2;
            }
        }
        public Mycommand AddStudent { get; set; }
        public Mycommand RemoveStudent { get; set; }
        public Mycommand filter { get; set; }
        public int count
        {
            set
            {
                _count = value;
                OnPropertyChanged();
            }
            get
            {
                return _count;
            }
        }
        #endregion

        #region Constructor
        public StudentsViewModel()
        {
            Add();
            AddStudent = new Mycommand(Add_Student, Can_AddStudent);
            RemoveStudent = new Mycommand(Remove_Student, Can_RemoveStudentr);
            filter = new Mycommand(Filter, Can_Filter);
        }
        #endregion

        #region Method
        public void Add()
        {
            Studentlist.Add(new Students("ALi", "Ahmed", 13, Students.Subject.Chemistry));
            Studentlist.Add(new Students("Hassan", "Moustafa", 12, Students.Subject.English));
            Studentlist.Add(new Students("Mariam", "Ahmed", 10, Students.Subject.Arabic));
            Studentlist.Add(new Students("Ahmed", "Moustafa", 9, Students.Subject.Music));
            Studentlist.Add(new Students("Moustafa", "Mohamed", 8, Students.Subject.Biology));
            Studentlist.Add(new Students("Menna", "Mohamed", 10, Students.Subject.English));
            Studentlist.Add(new Students("Dalia", "Ahmed", 8, Students.Subject.Music));
            Studentlist.Add(new Students("Magedy", "Mohamed", 8, Students.Subject.Physics));
            Studentlist.Add(new Students("Hassan", "Mohamed", 10, Students.Subject.Art));
            Studentlist.Add(new Students("Mahmoud", "Ahmed", 14, Students.Subject.History));
        }
        public void Add2()
        {
            foreach (var item in Studentlist)
            {
                Studentlist2.Add(item);
            }
        }
        public void Add_Student(object par)
        {
            Studentlist.Add(new Students(F_Name, L_Name, age, subject));
        }
        public bool Can_AddStudent(object par)
        {
            return true;
        }
        public void Remove_Student(object par)
        {
            try
            {
                Studentlist.Remove((Students)par);
            }
            catch
            {
                MessageBox.Show("Can't Delete Empty Row");
            }
        }
        public bool Can_RemoveStudentr(object par)
        {
            if (Studentlist.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Filter(object par)
        {
            Studentlist2.Clear();
            Add2();
            int n = Studentlist2.Count();
            int[] arr = new int[n];
            int i = 0;
            foreach (var item in Studentlist2)
            {
                if (item.subject == subject2)
                {

                }
                else
                {
                    arr[i] = -1;
                }
                i++;
            }
            for (int k = arr.Length-1; k >= 0; k--)
            {
                if (arr[k]!= 0)
                {
                    Studentlist2.RemoveAt(k);
                }
            }
            count = Studentlist2.Count();
        }
        public bool Can_Filter(object par)
        {
            return true;
        }

        #endregion


    }
}

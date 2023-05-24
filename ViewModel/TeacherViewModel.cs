using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WpfApp1.Command;
using WpfApp1.Model;
using WpfApp1.View;

namespace WpfApp1.ViewModel
{
    public class TeacherViewModel : INotifyPropertyChanged
    {

        #region Member Variabls
        ObservableCollection<Teachers> teacherlist;
        public string F_Name { set; get; }
        public string L_Name { set; get; }
        public int Id { set; get; }

        public int age { set; get; }
        public Teachers.Subject subject { set; get; }
        public double salary { set; get; }
        public string Image { get; set; }
        Mycommand addTeacher;
        Mycommand removeTeacher;
        #endregion

        #region Event
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion

        #region Property
        public ObservableCollection<Teachers> Teacherlist
        {
            set
            {
                teacherlist = value;
                OnPropertyChanged();
            }
            get
            {
                return teacherlist;
            }
        }
        public Mycommand AddTeacher
        {
            set
            {
                addTeacher = value;
                OnPropertyChanged();
            }
            get
            {
                return addTeacher;
            }
        }
        public Mycommand RemoveTeacher
        {
            set
            {
                removeTeacher = value;
                OnPropertyChanged();
            }
            get
            {
                return removeTeacher;
            }
        }
        #endregion

        #region Constructor
        public TeacherViewModel()
        {

            Teacherlist = new ObservableCollection<Teachers>();
            #region Add Teachers
            Teacherlist.Add(new Teachers("Ahmed", "Mohamed", 568, 12000, 25, Teachers.Subject.Art, Image));
            Teacherlist.Add(new Teachers("Kahled", "Ahmed", 685, 14000, 23, Teachers.Subject.English, Image));
            Teacherlist.Add(new Teachers("Moustafa", "Mohamed", 236, 11000, 26, Teachers.Subject.Math, Image));
            Teacherlist.Add(new Teachers("Hassan", "Ali", 036, 10000, 22, Teachers.Subject.Biology, Image));
            Teacherlist.Add(new Teachers("Ahmed", "Ali", 505, 12500, 25, Teachers.Subject.Arabic, Image));
            Teacherlist.Add(new Teachers("Moustafa", "Sayed", 458, 13500, 26, Teachers.Subject.Biology, Image));
            Teacherlist.Add(new Teachers("Wael", "Moahmed", 210, 12250, 24, Teachers.Subject.Physics, Image));
            Teacherlist.Add(new Teachers("Mariam", "Hassan", 698, 12500, 25, Teachers.Subject.Chemistry, Image));
            Teacherlist.Add(new Teachers("Ali", "Kamal", 597, 13000, 24, Teachers.Subject.French, Image));
            #endregion
            AddTeacher = new Mycommand(Add_Teacher, Can_AddTeacher);
            RemoveTeacher = new Mycommand(Remove_Teacher, Can_RemoveTeacher);

        }
        #endregion

        #region Method
        public void Add_Teacher(object par)
        {
            Teacherlist.Add(new Teachers(F_Name, L_Name, Id, salary, age, subject, Image));
        }
        public bool Can_AddTeacher(object par)
        {
            return true;
        }
        public void Remove_Teacher(object par)
        {
            try
            {
                Teacherlist.Remove((Teachers)par);
            }
            catch
            {
                MessageBox.Show("Can't Delete Empty Row");
            }
        }
        public bool Can_RemoveTeacher(object par)
        {
            return true;
        }

        #endregion


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Input;
using WpfApp1.Command;
using WpfApp1.View;

namespace WpfApp1.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        #region Member Field

        private Mycommand teachersTab;
        private Mycommand studentsTab;
        private Mycommand calculatorTab;
        object TeacherView = new TeachersView();
        object StudentsView = new StudentsView();
        object CalculatorView = new CalculatorView();
        object view;
        #endregion

        #region Event
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion

        #region Property
        public Mycommand TeachersTab
        {
            get
            {
                return teachersTab;
            }
            set
            {
                teachersTab = value;
                OnPropertyChanged();
            }
        }
        public Mycommand StudentsTab
        {
            get
            {
                return studentsTab;
            }
            set
            {
                studentsTab = value;
                OnPropertyChanged();
            }
        }
        public Mycommand CalculatorTab
        {
            get
            {
                return calculatorTab;
            }
            set
            {
                calculatorTab = value;
                OnPropertyChanged();
            }
        }
        public Object View
        {
            get
            {
                return view;
            }
            set
            {
                view = value;
                OnPropertyChanged();
            }
        }
        public Mycommand cc { get; set; }
        public Mycommand Info { get; set; }
        #endregion

        #region Constructor
        public MainViewModel()
        {
            View = new EntranceView();
            TeachersTab = new Mycommand(Teacher_Button, Open_Teacher_Button);
            StudentsTab = new Mycommand(Students_Button, Open_Students_Button);
            CalculatorTab = new Mycommand(Calculator_Button, Open_Calculator_Button);
            Info = new Mycommand(Info_View, Can_Info_View);
        }
        #endregion

        #region Methods
        public void Teacher_Button(object parameter)
        {
            View = TeacherView;
        }
        public bool Open_Teacher_Button(object Parameter)
        {
            return true;
        }
        public void Students_Button(object parameter)
        {
            View = StudentsView;
        }
        public bool Open_Students_Button(object Parameter)
        {
            return true;
        }
        public void Calculator_Button(object parameter)
        {
            View = CalculatorView;
        }
        public bool Open_Calculator_Button(object Parameter)
        {
            return true;
        }
        public void Info_View(object par)
        {
            View = new EntranceView();
        }
        public bool Can_Info_View(object par)
        {
            return true;
        }
        #endregion


    }
}

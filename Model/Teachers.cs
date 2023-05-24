using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class Teachers
    {
        #region Automatic Property
        public string FName { get; set; }
        public string LName { get; set; }
        public int Id { get; set; }
        public double Salary { get; set; }
        public int Age { get; set; }
        public Subject subject { get; set; }
        public string Image { set; get; }
        #endregion

        #region Constructor
        public Teachers(string fname, string lname, int id, double salary, int age, Subject subject,string img)
        {
            FName = fname;
            LName = lname;
            Id = id;
            Salary = salary;
            Age = age;
            this.subject = subject;
            Image = img;
        }
        public Teachers()
        {
            
        }
        #endregion

        #region Methods

        #endregion

        #region Enum
        public enum Subject
        {
            Math,
            Arabic,
            English,
            History,
            Music,
            French,
            Chemistry,
            Biology,
            Physics,
            Art
        }
        #endregion

    }
}

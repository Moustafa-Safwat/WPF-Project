using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class Students
    {

        #region Automatic Property
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
        public Subject subject { get; set; }
        #endregion

        #region Constructor
        public Students(string fname, string lname,  int age, Subject subject)
        {
            FName = fname;
            LName = lname;
            Age = age;
            this.subject = subject;
        }
        public Students()
        {

        }
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

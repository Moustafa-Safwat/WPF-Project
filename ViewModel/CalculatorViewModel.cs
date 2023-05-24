using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.Command;

namespace WpfApp1.ViewModel
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        #region Member Field
        double result;
        string input;
        #endregion

        #region Event
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion

        #region Property
        public double Result
        {
            get
            {
                return result;
            }
            set
            {
                result = value;
                OnPropertyChanged();
            }
        }
        public string Input
        {
            get
            {
                return input;
            }
            set
            {
                input = value;
                OnPropertyChanged();
            }
        }
        public Mycommand btndot { get; set; }
        public Mycommand btn0 { get; set; }
        public Mycommand btn1 { get; set; }
        public Mycommand btn2 { get; set; }
        public Mycommand btn3 { get; set; }
        public Mycommand btn4 { get; set; }
        public Mycommand btn5 { get; set; }
        public Mycommand btn6 { get; set; }
        public Mycommand btn7 { get; set; }
        public Mycommand btn8 { get; set; }
        public Mycommand btn9 { get; set; }
        public Mycommand btn_sum { get; set; }
        public Mycommand btn_sub { get; set; }
        public Mycommand btn_mul { get; set; }
        public Mycommand btn_div { get; set; }
        public Mycommand btn_cl { get; set; }
        public Mycommand btn_eq { get; set; }
        public Mycommand btn_rm { get; set; }



        #endregion

        #region Constructor
        public CalculatorViewModel()
        {
            Result = 0;
            #region Button_Input
            btn0 = new Mycommand(Btn0_Click, Can_Btn0_Click);
            btn1 = new Mycommand(Btn1_Click, Can_Btn1_Click);
            btn2 = new Mycommand(Btn2_Click, Can_Btn2_Click);
            btn3 = new Mycommand(Btn3_Click, Can_Btn3_Click);
            btn4 = new Mycommand(Btn4_Click, Can_Btn4_Click);
            btn5 = new Mycommand(Btn5_Click, Can_Btn5_Click);
            btn6 = new Mycommand(Btn6_Click, Can_Btn6_Click);
            btn7 = new Mycommand(Btn7_Click, Can_Btn7_Click);
            btn8 = new Mycommand(Btn8_Click, Can_Btn8_Click);
            btn9 = new Mycommand(Btn9_Click, Can_Btn9_Click);
            btndot = new Mycommand(Btndot_Click, Can_Btndot_Click);
            btn_sum = new Mycommand(Btn_Sum_Click, Can_Btn_Sum_Click);
            btn_sub = new Mycommand(Btn_Sub_Click, Can_Btn_Sub_Click);
            btn_mul = new Mycommand(Btn_Mul_Click, Can_Btn_Mul_Click);
            btn_div = new Mycommand(Btn_Div_Click, Can_Btn_Div_Click);
            btn_cl = new Mycommand(Btn_Cl_Click, Can_Btn_cl_Click);
            btn_eq = new Mycommand(Btn_Eq_click, Can_Btn_Eq_Click);
            btn_rm = new Mycommand(Btn_Remove_Click, Can_Btn_Remove_Click);
            #endregion

        }
        #endregion

        #region Method

        StringBuilder sb = new StringBuilder();
        Char[] chrsign = new char[] { '+', '-', '*', '/' };
        Char[] chrno = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '.' };

        public void Btn0_Click(object parameter)
        {
            sb.Append("0");
            Input = sb.ToString();
        }
        public bool Can_Btn0_Click(object parameter)
        {
            return true;
        }
        public void Btn1_Click(object parameter)
        {
            sb.Append("1");
            Input = sb.ToString();
        }
        public bool Can_Btn1_Click(object parameter)
        {
            return true;
        }
        public void Btn2_Click(object parameter)
        {
            sb.Append("2");
            Input = sb.ToString();
        }
        public bool Can_Btn2_Click(object parameter)
        {
            return true;
        }
        public void Btn3_Click(object parameter)
        {
            sb.Append("3");
            Input = sb.ToString();
        }
        public bool Can_Btn3_Click(object parameter)
        {
            return true;
        }
        public void Btn4_Click(object parameter)
        {
            sb.Append("4");
            Input = sb.ToString();
        }
        public bool Can_Btn4_Click(object parameter)
        {
            return true;
        }
        public void Btn5_Click(object parameter)
        {
            sb.Append("5");
            Input = sb.ToString();
        }
        public bool Can_Btn5_Click(object parameter)
        {
            return true;
        }
        public void Btn6_Click(object parameter)
        {
            sb.Append("6");
            Input = sb.ToString();
        }
        public bool Can_Btn6_Click(object parameter)
        {
            return true;
        }
        public void Btn7_Click(object parameter)
        {
            sb.Append("7");
            Input = sb.ToString();
        }
        public bool Can_Btn7_Click(object parameter)
        {
            return true;
        }
        public void Btn8_Click(object parameter)
        {
            sb.Append("8");
            Input = sb.ToString();
        }
        public bool Can_Btn8_Click(object parameter)
        {
            return true;
        }
        public void Btn9_Click(object parameter)
        {
            sb.Append("9");
            Input = sb.ToString();
        }
        public bool Can_Btn9_Click(object parameter)
        {
            return true;
        }
        public void Btndot_Click(object parameter)
        {
            sb.Append(".");
            Input = sb.ToString();
        }
        public bool Can_Btndot_Click(object parameter)
        {
            return true;
        }
        public void Btn_Cl_Click(object Par)
        {
            Input = sb.Clear().ToString();
            Input = "0";
            Result = 0;

        }
        public bool Can_Btn_cl_Click(object par)
        {
            return true;
        }
        public void Btn_Sum_Click(object Parameter)
        {
            try
            {

            sb.Append("+");
            Input = sb.ToString();

            List<double> numberList = new List<double>();
            List<char> signList = new List<char>();
            double e;
            char f;
            foreach (var item in sb.ToString().Split(chrsign))
            {
                if (double.TryParse(item, out e))
                {
                    numberList.Add(e);
                }
            }
            foreach (var item in sb.ToString().Split(chrno))
            {
                if (char.TryParse(item, out f))
                {
                    signList.Add(f);
                }
            }
            int i = 0;
            Result = numberList[i];
            while (i < numberList.LongCount() - 1)
            {
                switch (signList[i])
                {
                    case '+':
                        Result = numberList[i + 1] + Result;
                        break;
                    case '-':
                        Result = Result - numberList[i + 1];
                        break;
                    case '*':
                        Result = numberList[i + 1] * Result;
                        break;
                    case '/':
                        Result = Result / numberList[i + 1];
                        break;
                }
                i++;
            }
            }
            catch 
            {
                MessageBox.Show("Error in Input");
                
            }
        }
        public bool Can_Btn_Sum_Click(object Parameter)
        {
            return true;
        }
        public void Btn_Sub_Click(object Parameter)
        {
            try
            {

            
            sb.Append("-");
            Input = sb.ToString();
            List<double> numberList = new List<double>();
            List<char> signList = new List<char>();
            double e;
            char f;
            foreach (var item in sb.ToString().Split(chrsign))
            {
                if (double.TryParse(item, out e))
                {
                    numberList.Add(e);
                }
            }
            foreach (var item in sb.ToString().Split(chrno))
            {
                if (char.TryParse(item, out f))
                {
                    signList.Add(f);
                }
            }
            int i = 0;
            Result = numberList[i];
            while (i < numberList.LongCount() - 1)
            {
                switch (signList[i])
                {
                    case '+':
                        Result = numberList[i + 1] + Result;
                        break;
                    case '-':
                        Result = Result - numberList[i + 1];
                        break;
                    case '*':
                        Result = numberList[i + 1] * Result;
                        break;
                    case '/':
                        Result = Result / numberList[i + 1];
                        break;
                }
                i++;
            }
            }
            catch
            {
                MessageBox.Show("Error in Input");

            }

        }
        public bool Can_Btn_Sub_Click(object Parameter)
        {
            return true;
        }
        public void Btn_Mul_Click(object Parameter)
        {
            try
            { 
            sb.Append("*");
            Input = sb.ToString();
            List<double> numberList = new List<double>();
            List<char> signList = new List<char>();
            double e;
            char f;
            foreach (var item in sb.ToString().Split(chrsign))
            {
                if (double.TryParse(item, out e))
                {
                    numberList.Add(e);
                }
            }
            foreach (var item in sb.ToString().Split(chrno))
            {
                if (char.TryParse(item, out f))
                {
                    signList.Add(f);
                }
            }
            int i = 0;
            Result = numberList[i];
            while (i < numberList.LongCount() - 1)
            {
                switch (signList[i])
                {
                    case '+':
                        Result = numberList[i + 1] + Result;
                        break;
                    case '-':
                        Result = Result - numberList[i + 1];
                        break;
                    case '*':
                        Result = numberList[i + 1] * Result;
                        break;
                    case '/':
                        Result = Result / numberList[i + 1];
                        break;
                }
                i++;
            }
            }
            catch
            {
                MessageBox.Show("Error in Input");

            }
        }
        public bool Can_Btn_Mul_Click(object Parameter)
        {
            return true;
        }
        public void Btn_Div_Click(object Parameter)
        {
            try { 
            sb.Append("/");
            Input = sb.ToString();
            List<double> numberList = new List<double>();
            List<char> signList = new List<char>();
            double e;
            char f;
            foreach (var item in sb.ToString().Split(chrsign))
            {
                if (double.TryParse(item, out e))
                {
                    numberList.Add(e);
                }
            }
            foreach (var item in sb.ToString().Split(chrno))
            {
                if (char.TryParse(item, out f))
                {
                    signList.Add(f);
                }
            }
            int i = 0;
            Result = numberList[i];
            while (i < numberList.LongCount() - 1)
            {
                switch (signList[i])
                {
                    case '+':
                        Result = numberList[i + 1] + Result;
                        break;
                    case '-':
                        Result = Result - numberList[i + 1];
                        break;
                    case '*':
                        Result = numberList[i + 1] * Result;
                        break;
                    case '/':
                        Result = Result / numberList[i + 1];
                        break;
                }
                i++;
            }
            }
            catch
            {
                MessageBox.Show("Error in Input");

            }
        }
        public bool Can_Btn_Div_Click(object Parameter)
        {
            return true;
        }
        public void Btn_Eq_click(object Parameter)
        {
            try { 
            List<double> numberList = new List<double>();
            List<char> signList = new List<char>();
            double e;
            char f;
            foreach (var item in sb.ToString().Split(chrsign))
            {
                if (double.TryParse(item, out e))
                {
                    numberList.Add(e);
                }
            }
            foreach (var item in sb.ToString().Split(chrno))
            {
                if (char.TryParse(item, out f))
                {
                    signList.Add(f);
                }
            }
            int i = 0;
            Result = numberList[i];
            while (i < numberList.LongCount() - 1)
            {
                switch (signList[i])
                {
                    case '+':
                        Result = numberList[i + 1] + Result;
                        break;
                    case '-':
                        Result = Result - numberList[i + 1];
                        break;
                    case '*':
                        Result = numberList[i + 1] * Result;
                        break;
                    case '/':
                        Result = Result / numberList[i + 1];
                        break;
                }
                i++;
            }
            }
            catch
            {
                MessageBox.Show("Error in Input");

            }

        }
        public bool Can_Btn_Eq_Click(object Parameter)
        {
            return true;
        }
        public void Btn_Remove_Click(object par)
        {
            int n = sb.Length;
            try
            {
                Input = sb.Remove(n - 1, 1).ToString();
            }
            catch
            {
                MessageBox.Show($"Don't Remove Zero Element");
            }
        }
        public bool Can_Btn_Remove_Click(object per)
        {
            return true;
        }

        #endregion

    }
}

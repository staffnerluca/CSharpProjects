using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace MitarbeitsprojektForms
{
    class Teacher : Person
    {
        private int _salary;
        private string _subject1;
        private string _subject2;
        public Teacher()
        {

        }
        public Teacher(string firstname, string secondname, int age, string town, int salary, string subject1, string subject2) :base(firstname, secondname, age, town)
        {
             this.salary= salary;
            
        }
        public int salary
        {
            get { return _salary; }
            set { if (value > 0 && value < 10000) {
                    _salary = value;
                }
                else
                {
                    throw new SalaryException();
                }
                }
        }
        public string subject1
        {
            get { return _subject1; }
            set { _subject1 = value; }
        }
        public string subject2
        {
            get { return _subject2; }
            set { _subject2 = value; }
        }
        #region Methods
        public override void changeData()
        {
            WriteLine("Was wollen Sie bearbeiten? \n \r" +
                "1 für den Vornamen \n \r" +
                "2 für den Nachnamen \n \r" +
                "3 für das Alter \n \r" +
                "4 für den Wohnort \n \r" +
                "5 für das Gehalt \n \r" +
                "6 für das erste Fach \n \r" +
                "7 für das zweite Fach");
            string input=ReadLine();
            if (input.Equals("1"))
            {
                base.firstname = ReadLine();
            }
            else if (input.Equals("2"))
            {
                base.secondName = ReadLine();
            }
            else if (input.Equals("3"))
            {
                this.age = Convert.ToInt32(ReadLine());
            }
            else if (input.Equals("4"))
            {
                this.town = ReadLine();
            }
            else if (input.Equals("5"))
            {
                this.salary = Convert.ToInt32(ReadLine());
            }
            else if (input.Equals("6"))
            {
                this.subject1 = ReadLine();
            }
            else if (input.Equals("7"))
            {
                this.subject2 = ReadLine();
            }
        }
        public override string WriteData()
        {
           string data="Vorname: " + this.firstname + "\n \r" +
           "Nachname: " + this.secondName + "\n \r" +
           "Alter: " + this.age + "\n \r" +
           "Wohnort: " + this.town + "\n \r" +
           "Gehalt: " + this.salary + "\n \r" +
           "Fach (1 von 2): " + this.subject1 + "\n \r" +
           "Fach (2 von 2): " + this.subject2 + "\n \r";
            return data;
        }
        public override void WriteToTxt(string path)
        {
            StreamWriter w = new StreamWriter(path, true);
            w.WriteLine("Teacher");
            w.WriteLine(this.firstname);
            w.WriteLine(this.secondName);
            w.WriteLine(this.age);
            w.WriteLine(this.town);
            w.WriteLine(this.salary);
            w.WriteLine(this.subject1);
            w.WriteLine(this.subject2);
            w.Flush();
            w.Close();
        }
        #endregion
    }
}


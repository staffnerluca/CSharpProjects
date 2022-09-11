using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace MitarbeitsprojektForms
{
    public class Student : Person
    {
        public delegate void NoSClassEventHandler();
        public event NoSClassEventHandler NoClass;
        private string _schoolclass;
        public Student()
        {

        }
        public Student(string firstname, string secondname, int age, string schoolclass, string town) : base(firstname, secondname, age, town)
        {
            this.firstname = firstname;
            this.secondName = secondname;
            this.age = age;
            this.schoolclass = schoolclass;
            this.town = town;
        }
        public string schoolclass
        {
            get { return _schoolclass; }
            set {
                if (!value.Equals(""))
                {
                    _schoolclass = value;
                }
                else
                    NoClass();
            }
        }

        public override void changeData()
        {
            WriteLine("Was wollen Sie bearbeiten? \n \r" +
                 "1 für den Vornamen \n \r" +
                 "2 für den Nachnamen \n \r" +
                 "3 für das Alter \n \r" +
                 "4 für den Wohnort \n \r" +
                 "5 für die Klasse \n \r");
            string input = ReadLine();
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
                this.schoolclass = ReadLine();
            }
        }

        public override string WriteData()
        {
            string data="Vorname: " + this.firstname + "\n \r" +
                    "Nachname: " + this.secondName + "\n \r" +
                    "Alter: " + this.age + "\n \r" +
                    "Wohnort: " + this.town + "\n \r " +
                    "Klasse: " + this.schoolclass + "\r \n";
            return data;
        }
        public override void WriteToTxt(string path)
        {
                StreamWriter w = new StreamWriter(path, true);
                w.WriteLine("Student");
                w.WriteLine(this.firstname);
                w.WriteLine(this.secondName);
                w.WriteLine(this.age);
                w.WriteLine(this.town);
                w.WriteLine(this.schoolclass);
                w.Flush();
                w.Close();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace MitarbeitsprojektForms
{

    public abstract class Person
    {
        public delegate void EmptyNameEventHandler();
        public event EmptyNameEventHandler EmptyName;
        #region Variablen
        private string _firstname, _secondname, _town;
        private int _age = -1, _number;
        #endregion
        #region Konstruktoren
        public Person()
        {

        }
        public Person(string name)
        {
            this.firstname = name;
        }
        public Person(string name, int age)
        {
            this.firstname = name;
            this.age = age;
        }
        public Person(string firstname, string secondname, int age, string town)
        {
            this.firstname = firstname;
            this.age = age;
            this.town = town;
            this.secondName = secondname;
        }
        #endregion
        #region Properties
        public int number
        {
            get
            {
                return _number;
            }
            set
            {
                if (value <= 200)
                    _number = value;
            }
        }
        public string secondName
        {
            get { return _secondname; }
            set { _secondname = value; }
        }

        public int age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 120)
                    _age = value;
                else
                {
                    throw new ageException();
                }
            }
        }
        public string firstname
        {
            get
            {
                return _firstname;
            }
            set
            {
                if (!value.Equals(""))
                {
                    _firstname = value;

                }
                else
                    EmptyName();
            }
        }
        public string town
        {
            get
            {
                return _town;
            }
            set
            {
                _town = value;
            }
        }
        public int Birthday()
        {
            age++;
            return age;
        }
        #endregion
        #region Methoden
        public abstract string WriteData();
        public abstract void changeData();
        public abstract void WriteToTxt(string path);
        #endregion
    }
}



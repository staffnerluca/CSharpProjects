using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LucaStaffnerJahresprojektAPR2122
{
    class Task
    {
        #region Var.
        string _task, _folder;
        int _tasksFin;
        #endregion
        #region Konst.
        public Task()
        {

        }
        public Task(string task, string folder)
        {
            this.task = task;
            this.folder = folder;
        }
        #endregion
        #region Prop.
       public string task
        {
            get { return _task; }
            set { _task = value; }
        }
        public string folder
        {
            get { return _folder; }
            set {
                   _folder = value;
                }
        }
        public int tasksFin 
        {
            get { return _tasksFin; }
            set { 
                if (value > -1)
                    _tasksFin = value;
                 }
        }
        #endregion
        #region Methods
        public void FinishedTask(bool fin)
        {
            if (fin == true)
            {
                Destroy();
                tasksFin++;
            }
        }
        public void Destroy()
        {
            task = null;
        }
        public virtual void SaveTask(bool append)
        {
            StreamWriter writer = new StreamWriter(DataP.path, append);
            writer.WriteLine(this.task);
            writer.WriteLine(this.folder);
            writer.Flush();
            writer.Close();
        }
        public virtual string TaskToString()
        {
            string text = this.task + ";" + this.folder;
            return text;
        }
        #endregion
    }
}

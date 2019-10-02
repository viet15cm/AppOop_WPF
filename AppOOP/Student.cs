using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
namespace AppOOP
{
    class Student
    {
        public Student(string name)
        {
            this.name = name;
        }

        public Student()
        {
            
        }

        private string name;

        public string StudentName { get => name; set => name = value; }


        public virtual  void Talk()
        {
            if (StudentName.Equals("Minh"))
                MessageBox.Show("My name is " + this.StudentName + " Iam a College Student !");
            else if(StudentName.Equals("Dung"))
                MessageBox.Show("My name is " + this.StudentName + " Iam a Universtiy Student !");
            else
                MessageBox.Show("errol");
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab04.Models
{
    public class StudentContext
    {
        // vừa khai báo vừa khởi tạo Collection List
        public static List<Student> students = new List<Student>
        {
            new Student{Id="S101",Name="Mr.Trump",Address="US"},
            new Student{Id="S102",Name="Mr.Biden",Address="US"}
        };
    }
}
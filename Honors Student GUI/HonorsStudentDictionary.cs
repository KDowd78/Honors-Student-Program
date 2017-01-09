using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honors_Student_GUI
{
    public class HonorsStudentDictionary
    {
        Dictionary<string, HonorsStudent> studentList = new Dictionary<string, HonorsStudent>();

        public Dictionary<string, HonorsStudent>.ValueCollection AllStudents
        {
            get { return studentList.Values; }
        }

        public void AddStudent(HonorsStudent student)
        {
            studentList.Add(student.ccriID, student);
        }

        public void RemoveStudent(string id)
        {
            studentList.Remove(id);
        }

        public HonorsStudent FindStudentByID(string id)
        {
            HonorsStudent find;
            if (studentList.ContainsKey(id))
            {
                find = studentList[id];
                return find;
            }
            else
            {
                return null;
            }
        }
    }
}

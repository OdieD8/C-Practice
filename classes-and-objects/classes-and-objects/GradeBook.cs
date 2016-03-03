using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_and_objects
{
    class GradeBook
    {
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        List<float> grades;
    }
}

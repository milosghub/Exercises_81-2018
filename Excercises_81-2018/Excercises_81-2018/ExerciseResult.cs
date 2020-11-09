using System;
using System.Collections.Generic;
using System.Text;

namespace Excercises_81_2018
{
    class ExerciseResult
    {
        
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string StudentIndex { get; set; }
        public int Point { get; set; }

        public ExerciseResult(int id, string name, string index, int point)
        {
            Id = id;
            StudentName = name;
            StudentIndex = index;
            Point = point;
        }
        public ExerciseResult() { }
        
    }
}

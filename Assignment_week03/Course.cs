using System;
using System.Collections.Generic;
using System.Text;

namespace Program01
{
    class Course
    {
        public string name;
        public int Grade;
        public PracticalGrade PracticalGrade;

        public bool Passed()
        {
            if((Grade <= 55) && (PracticalGrade == PracticalGrade.Sufficient || PracticalGrade == PracticalGrade.Good))
            {
                //it a pass
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CumLaude()
        {
            if ((Grade <= 80) && (PracticalGrade == PracticalGrade.Good))
            {
                //it a pass
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

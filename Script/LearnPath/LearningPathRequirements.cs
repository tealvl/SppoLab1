using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SppoLab1
{
    class LearningPathRequirements
    {
        private List<ReqirementCourse> reqiremetCourses;
        private uint minNumOptionalCourses;

        LearningPathRequirements() 
        {
            reqiremetCourses = new List<ReqirementCourse>();
            minNumOptionalCourses = 0;
        }
        
        public void UpdateLearnPathesRequirements()
        {
            LearnPath.UpdateRequirements(minNumOptionalCourses, reqiremetCourses);
        }


    }
}

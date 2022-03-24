using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SppoLab1
{
    public class LearningPathRequirements
    {
        private List<ReqirementCourse> reqiremetCourses;
        private uint minNumOptionalCourses;
        
        static private LearningPathRequirements singletoneLearningPathRequirements;

        private LearningPathRequirements() 
        {
            singletoneLearningPathRequirements = this;
            reqiremetCourses = new List<ReqirementCourse>();
            minNumOptionalCourses = 0;
        }

        public void ChangeMinNumOptionalCourses(uint _minNumOptionalCourses)
        {
            minNumOptionalCourses = _minNumOptionalCourses;
            UpdateLearnPathesRequirements();
        }

        public void SetReqiremetCourses(List<ReqirementCourse> _reqiremetCourses)
        {
            reqiremetCourses = _reqiremetCourses;
            UpdateLearnPathesRequirements();
        }

        public void AddRequirementCourse(ReqirementCourse newReqirementCourse)
        {
            reqiremetCourses.Add(newReqirementCourse);
            UpdateLearnPathesRequirements();
        }

        static public LearningPathRequirements Initialize()
        {
            if (singletoneLearningPathRequirements == null)
                return new LearningPathRequirements();

            return singletoneLearningPathRequirements;
        }

        public void UpdateLearnPathesRequirements()
        {
            LearnPath.UpdateRequirements(minNumOptionalCourses, reqiremetCourses);
        }
    }
}

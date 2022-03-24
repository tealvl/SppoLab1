using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SppoLab1
{
    class Administrator
    {
        public void SignIn()
        {
            UI.Print("Так так вы хотите войти как администратор, ну уж нет, пока!");

            App.SignIn();
            LearningPathRequirements lpr = LearningPathRequirements.Initialize();
        }



        private class LearningPathRequirements
        {
            private List<ReqirementCourse> reqiremetCourses;
            private uint minNumOptionalCourses;

            static private LearningPathRequirements singletoneLearningPathRequirements;

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
}
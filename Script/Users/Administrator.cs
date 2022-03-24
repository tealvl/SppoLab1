using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SppoLab1
{
    static class Administrator
    {
        static private AccountRegistrator accountRegistrator = AccountRegistrator.Initialize();
        static private CourseRegistrator courseRegistrator = CourseRegistrator.Initialize(); 
        static private LearningPathRequirements learningPathRequirements = LearningPathRequirements.Initialize();

        static public void SignIn()
        {
            UI.Print("Так так вы хотите войти как администратор, ну уж нет, пока!");

            App.SignIn();
            LearningPathRequirements lpr = LearningPathRequirements.Initialize();
        }

        private class AccountRegistrator
        {
            static private AccountRegistrator singletoneAccountRegistrator;
          
            private List<Teacher> teachers;
            private List<Student> students;

            AccountRegistrator()
            {
                teachers = new List<Teacher>();
                students = new List<Student>();
            }

            static public AccountRegistrator Initialize()
            {
                if (singletoneAccountRegistrator == null)
                    return new AccountRegistrator();

                return singletoneAccountRegistrator;
            }

            public void CreateTeacher()
            {

            }

            public void CreateStudent()
            {

            }
        }

        private class CourseRegistrator
        {
            static private CourseRegistrator singletoneCourseRegistrator;
          
            private List<ReqirementCourse> reqirementCourses;
            private List<OptionalCourse> optionalCourses;

            CourseRegistrator()
            {
                reqirementCourses = new List<ReqirementCourse>();
                optionalCourses = new List<OptionalCourse>();
            }

            public void CrateReqirementCourse()
            {

            }
            public void CrateNewOptionalCourse()
            {

            }

            static public CourseRegistrator Initialize()
            {
                if (singletoneCourseRegistrator == null)
                    return new CourseRegistrator();

                return singletoneCourseRegistrator;
            }

            public int CountCourses()
            {
                return reqirementCourses.Count + optionalCourses.Count;
            }
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
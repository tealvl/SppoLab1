namespace SppoLab1
{
    public class CourseBranchBuilder: ICourseBuilder
    {
        private BranchCourse course;

        public ICourse GetResult()
        {
            return course;
        }
      
        public CourseBranchBuilder()
        {
            course = new BranchCourse();
        }

        public void Reset()
        {
            course = new BranchCourse();
        }

        public void AddCourse(Course _someCourse)
        {
            course.AddCource(_someCourse);
        }

        public string GetInfo()
        {
            return course.GetFullInfo();
        }
    }
    
}

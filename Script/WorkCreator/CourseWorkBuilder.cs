namespace SppoLab1
{
    public class CourseWorkBuilder : WorkBuilder
    {
        public CourseWorkBuilder()
        {
            work = new CourseWork();
        }

        public void Reset()
        {
            work = new CourseWork();
        }
    }
}

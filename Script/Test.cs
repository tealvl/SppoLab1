using System;
using System.Collections.Generic;

namespace SppoLab1
{
    class Test
    {
        public void Run() 
        {
            LearnPath learnPath = GetLearnPath();
            Student student = GetStudent(learnPath);

            UI.Print("Дерево обучения:");
            UI.Print(learnPath.GetShortInfo());

            UI.SpaceLine(5);

            learnPath.CreateLearnPath();
            UI.Clear();

            UI.Print("Это ваш путь обучения:");
            learnPath.PrintDetails();
        }

        public Student GetStudent(LearnPath learnPath) 
        {
            return new Student("Игорек", 12, "9Б", learnPath);
        }

        public LearnPath GetLearnPath() 
        {
            List<ICourse> _myCourses = new List<ICourse>();

            CourseBuilder courseBuilder = new CourseBuilder();

            LabWorkBuilder labWorkBuilder = new LabWorkBuilder();
            PracticalWorkBuilder practicalWorkBuilder = new PracticalWorkBuilder();
            CourseWorkBuilder courseWorkBuilder = new CourseWorkBuilder();

            courseBuilder.SetName("Курс по игре на треугольники");
            courseBuilder.SetCourseDiscription("Этот курс направлен на изучение и освоение навыков игры на музыкальном инструменте - треугольник.");

            labWorkBuilder.SetName("Изучение внешнего вида музыкальный инструмента - треугольник");
            labWorkBuilder.SetWorkDiscription("В этой работе вы узнаете как выглядит и звучит треугольник!");
            labWorkBuilder.AddTask("Возьмите коробку с треугольником в руки");
            labWorkBuilder.AddTask("Откройте коробку с треугольником");
            labWorkBuilder.AddTask("Достаньте треугольник");
            labWorkBuilder.AddTask("Посмотрите на него сверху-вниз");
            labWorkBuilder.AddTask("Поверните на 90 градусов");
            labWorkBuilder.AddTask("Посмотрите на треугольник, что изменилось?");
            labWorkBuilder.AddTask("Сделайте выводы");
            labWorkBuilder.AddTask("Оформите отчет");

            Work lab1 = labWorkBuilder.GetResult();
            labWorkBuilder.Reset();

            practicalWorkBuilder.SetName("Игра на треугольнике");
            practicalWorkBuilder.SetWorkDiscription("В этой работе вы попрактикуетесь в игре на треугольнике");
            practicalWorkBuilder.AddTask("Возьмите треугольник в руки");
            practicalWorkBuilder.AddTask("Играйте");
            practicalWorkBuilder.AddTask("Сделайте выводы");

            Work prac1 = practicalWorkBuilder.GetResult();
            practicalWorkBuilder.Reset();

            courseBuilder.AddWork(lab1);
            courseBuilder.AddWork(prac1);

            Course course1 = courseBuilder.GetResult();
            courseBuilder.Reset();

            courseBuilder.SetName("Решение нелинейного уравнение традиционным способом");
            courseBuilder.SetCourseDiscription("В этом курсе вы узнаете новый способ решения нелинейного уравнения!");

            practicalWorkBuilder.SetName("Выпишите нелинейное уравение на листок");
            practicalWorkBuilder.SetWorkDiscription("Краткое пособие по решению нелийнейных уравнений");
            practicalWorkBuilder.AddTask("Откройте Интернет-Браузер Google Chrome");
            practicalWorkBuilder.AddTask("В поисковой строке напишите Решение нелинейных уравнение калькулятор онлайн пожалуйста помогите");
            practicalWorkBuilder.AddTask("Перейдите по первой ссылке");
            practicalWorkBuilder.AddTask("В появившемся окне напишите своё уравнение");
            practicalWorkBuilder.AddTask("Нажмите кнопку посчитать");
            practicalWorkBuilder.AddTask("Перепишите ответ на листок");
            practicalWorkBuilder.AddTask("Сделайте Выводы");

            Work pract2 = practicalWorkBuilder.GetResult();
            practicalWorkBuilder.Reset();

            courseBuilder.AddWork(pract2);

            Course course2 = courseBuilder.GetResult();
            courseBuilder.Reset();

            courseBuilder.SetName("Вегатариантсво");
            courseBuilder.SetCourseDiscription("В этом курсе вам предстоит побыть в роле веганатарианца");

            courseWorkBuilder.SetName("Трех-недельный опыт вегетарианца");
            courseWorkBuilder.SetWorkDiscription("Курсовая нацелена на то, чтобы понять какого это быть веганом");

            courseWorkBuilder.AddTask("Измерьте свой вес до испытаний");
            courseWorkBuilder.AddTask("Не кушайте мясо 3 недели");
            courseWorkBuilder.AddTask("Измерьте свой вес после испытаний");
            courseWorkBuilder.AddTask("Сделайте выводы");

            Work coursew1 = courseWorkBuilder.GetResult();
            courseWorkBuilder.Reset();

            courseBuilder.AddWork(coursew1);

            Course course3 = courseBuilder.GetResult();
            courseBuilder.Reset();


            courseBuilder.SetName("Мясоедство");
            courseBuilder.SetCourseDiscription("В этом курсе вам предстоит побыть в роле мясоеда");

            courseWorkBuilder.SetName("Трех-недельный опыт мясоеда");
            courseWorkBuilder.SetWorkDiscription("Курсовая нацелена на то, чтобы понять какого это быть мясоедом");

            courseWorkBuilder.AddTask("Измерьте свой вес до испытаний");
            courseWorkBuilder.AddTask("Кушайте мясо 3 недели");
            courseWorkBuilder.AddTask("Измерьте свой вес после испытаний");
            courseWorkBuilder.AddTask("Сделайте выводы");

            Work coursew2 = courseWorkBuilder.GetResult();
            courseWorkBuilder.Reset();

            courseBuilder.AddWork(coursew2);

            Course course4 = courseBuilder.GetResult();
            courseBuilder.Reset();

            CourseBranchBuilder courseBranchBuilder = new CourseBranchBuilder();
            courseBranchBuilder.AddCourse(course3);
            courseBranchBuilder.AddCourse(course4);

            BranchCourse branchCourse1 = (BranchCourse)courseBranchBuilder.GetResult();
            courseBranchBuilder.Reset();

            courseBuilder.SetName("Смешанный курс");
            courseBuilder.SetCourseDiscription("В этом курсе есть всего по немногу");
            courseBuilder.AddWork(prac1);
            courseBuilder.AddWork(coursew1);
            courseBuilder.AddWork(pract2);

            Course course5 = courseBuilder.GetResult();
            courseWorkBuilder.Reset();


            _myCourses.Add(course1);
            _myCourses.Add(course2);
            _myCourses.Add(branchCourse1);
            _myCourses.Add(course5);

            LearnPath learnPath = new LearnPath(_myCourses);

            return learnPath;
        }
    }
}

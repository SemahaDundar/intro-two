using intro.Entities;

namespace intro.DataAccess.Concretes;

public class CourseDal
{   //consructor oluşturmak için < ctor> yazmalısın
    List<CourseDal> courses;



    public CourseDal()
    {

        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "C#";
        course1.Description = ".Net 8";
        course1.Price = 0;



        Course course2 = new Course();
        course2.Id = 2;
        course2.Name = "Python";
        course2.Description = "Python 3.10";
        course2.Price = 50;



        Course course3 = new Course();
        course3.Id = 3;
        course3.Name = "Java";
        course3.Description = "Java .17.";
        course3.Price = 70;


        courses = new List<Course> { course1, course2, course3 };


    }
    public List<Course> GetAll()
        // db işlem yapılır

        return courses;

}


public void Add(Course course)
{

    courses.Add(course);
}






}
internal class courses
{
}
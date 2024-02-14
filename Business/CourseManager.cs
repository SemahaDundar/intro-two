using intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace intro.Business;

public class CourseManager
{
    Course[] courses = new Course[3];
    public CourseManager()
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

         courses[0] = course1;
        courses[1] = course2;
        courses[2] = course3;
    }

    public Course[]  GetAll()

    {
        return courses;
    }
}

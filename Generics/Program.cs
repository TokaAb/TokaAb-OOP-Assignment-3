using Generics.src;

// 1. Store<Student>


Store<Student> studentStore = new Store<Student>();

studentStore.Add(new Student { Id = 1, Name = "Toka" });
studentStore.Add(new Student { Id = 2, Name = "Loly" });
studentStore.Add(new Student { Id = 3, Name = "nagham" });
studentStore.Add(new Student { Id = 4, Name = "ahmed" });
studentStore.Add(new Student { Id = 5, Name = "Nour" });



// 2. Store<Course>

Store<Course> courseStore = new Store<Course>();

courseStore.Add(new Course
{
    Id = 1,
    Title = "C#",
    Price = 500
});

courseStore.Add(new Course
{
    Id = 2,
    Title = "ASP.NET Core",
    Price = 700
});

courseStore.Add(new Course
{
    Id = 3,
    Title = "SQL",
    Price = 400
});


// 3. Get one Student and Course by Id

Student student = studentStore.GetById(3);
Course course = courseStore.GetById(2);

Console.WriteLine("Student:");
Console.WriteLine($"{student.Id} {student.Name}");

Console.WriteLine("Course:");
Console.WriteLine($"{course.Id}{course.Title}{course.Price}");


// 4. Duplicate Student Id

try
{
    studentStore.Add(new Student
    {
        Id = 3,
        Name = "Duplicate Student"
    });
}
catch (Exception ex)
{
    Console.WriteLine("Duplicate Error:");
    Console.WriteLine(ex.Message);
}


// 5. Page 2 - size 2


Console.WriteLine("Page 2:");

foreach (Student s in studentStore.GetAll().Values.Page(2, 2))
{
    Console.WriteLine($"{s.Id} - {s.Name}");
}


// 6. FindById on List<Course>

List<Course> courses = new List<Course>
{
    new Course { Id = 1, Title = "C#", Price = 500 },
    new Course { Id = 2, Title = "ASP.NET Core", Price = 700 },
    new Course { Id = 3, Title = "SQL", Price = 400 }
};

Course findCourse = courses.FindById(2);

if (findCourse != null)
{
    Console.WriteLine("Found Course:");
    Console.WriteLine($"{findCourse.Id}{findCourse.Title}{findCourse.Price}");
}



// 7. Must NOT compile
// Store<string> stringStore = new Store<string>();
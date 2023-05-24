using Domain.DTOs;

var teacherService = new TeachersService();

var teacher = new teachersDTO()
{
    FirstName = "Safiya",
    LastName = "Dodojonova",
    EmailAddress = "Dodojonova@gmail.com",
    TeacherId = 14,
};
//Add(teacher);
 Show("Nigora");
void Show(string name)
{
    var teachers = teacherService.GetTeachers(name,null);
    Console.WriteLine("Id-----------FirstName------------LastName-------------Email");
    foreach (var teacher in teachers)
    {
        Console.WriteLine($"{teacher.TeacherId}-----------{teacher.FirstName}------------{teacher.LastName}-------------{teacher.EmailAddress}");
    }
}

void GetById(int id)
{
    var teacher = teacherService.GetTeacherById(id);
    Console.WriteLine($"{teacher.TeacherId}");
    Console.WriteLine($"{teacher.FirstName}");
    Console.WriteLine($"{teacher.LastName}");
}
GetById(12);

void Add(teachersDTO teacher)
{
    var result = teacherService.AddTeacher(teacher);
    Console.WriteLine(result.TeacherId);
}
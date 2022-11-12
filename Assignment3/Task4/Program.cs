using Task4;



Student student_obj = new Student("stu_first", "stu_second ", "stu@email.com");
Console.WriteLine(student_obj.Id + student_obj.FullName+ student_obj.Email + "\n");
student_obj.GenerateId();


Teacher teacher_obj = new Teacher("tea_first", "tea_second ", "tea@email.com");
Console.WriteLine(teacher_obj.Id + teacher_obj.FullName + teacher_obj.Email + "\n");
teacher_obj.GenerateId();


Admin admin_obj = new Admin("admin_first", "admin_second ", "admin@email.com");
Console.WriteLine(admin_obj.Id + admin_obj.FullName + admin_obj.Email + "\n");
admin_obj.GenerateId();
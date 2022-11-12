namespace Task4
{
    public class Student :Base
    {
        public Student(string firstName, string lastName, string email) : base(firstName, lastName, email)
    {

    }
    public override void GenerateId()
    {
        Id = "AD-" + Guid.NewGuid().ToString();
    }

}
}
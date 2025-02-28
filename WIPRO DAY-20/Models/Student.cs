namespace StudentApi.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Batch { get; set; }
        public DateTime JoiningDate { get; set; }
        public int Marks { get; set; }
    }
}

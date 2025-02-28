namespace DemoWebApi.Models
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

// CRUD operations on Student ent Entity
// Web Api > HTTP Service (It uses HTTP/HTTPS protocol)
// It uses HTTP Verbs to perform operations
// Get    > Getting data from web api
// Post   > Used to post / send data (Create)
// Put    > Edit data
// Delete > Delete Data
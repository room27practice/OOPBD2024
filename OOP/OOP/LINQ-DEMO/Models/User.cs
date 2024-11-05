namespace LINQ_DEMO.Models
{
    internal class User
    {
        public User()
        { }

        public User(int id, string fName, string lName) : this()
        {
            Id = id;
            FName = fName;
            LName = lName;
        }
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public List<Animal> Pets { get; set; }
    }
}
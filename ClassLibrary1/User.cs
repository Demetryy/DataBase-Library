namespace ClassLibrary1
{
    public class User
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Contacts { get; set; }
        
        public User(string name, string surname, string contacts)
        {
            Name = name;
            SurName = surname;
            Contacts = contacts;
        }
        
        public User(){}
    }

}

namespace OrnekProje.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; } = false;

        //public List<Contact> Contacts { get; set; }
    }
}

namespace CRUD_stuff.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"ID: {Id} - Name: {Name}";
        }
    }
}
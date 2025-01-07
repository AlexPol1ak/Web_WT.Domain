namespace Poliak_UI_WT.Domain.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public List<Phone> Phones { get; set; } = new List<Phone>();

        public Category() { }
        public Category(string name) : this()
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

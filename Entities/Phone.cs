using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliak_UI_WT.Domain.Entities
{
    public class Phone
    {
        public int PhoneId {  get; set; }
        public string Name {  get; set; }
        public string Model {  get; set; }
        public string? Description { get; set; } = null;
        public string? Image { get; set; } = null;
        public double? Price { get; set; } = null;

        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        public Phone() { }
        public Phone(string name, string model,
            string? description = null, string? image = null, double? price = null): this()
        {
            Name = name;
            Model = model;
            Description = description;
            Image = image;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} {Model}";
        }
    }
}

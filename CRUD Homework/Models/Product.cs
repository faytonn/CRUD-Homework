﻿namespace CRUD_stuff.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }


        public override string ToString()
        {
            return $"ID: {Id} - Name: {Name} - Price: {Price} - Category: {Category.Name}";
        }
    }

    
}
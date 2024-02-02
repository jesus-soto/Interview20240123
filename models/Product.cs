using System;
using System.ComponentModel.DataAnnotations;

public class Product{
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set; }
    }

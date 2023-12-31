﻿using System;

namespace CleanArch.Core.Models
{
    public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Barcode { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public DateTime Added { get; set; }
    public DateTime Modified { get; set; }
}
}

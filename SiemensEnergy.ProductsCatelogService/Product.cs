using System;
using System.Collections.Generic;

namespace SiemensEnergy.ProductsCatelogService;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public int Price { get; set; }

    public bool IsAvailable { get; set; }

    public string Category { get; set; } = null!;
}

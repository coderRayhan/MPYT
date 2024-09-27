namespace MPYT.Entities;

public class MenuItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; }
}

public class OrderReport
{
    public int Id { get; set; }
    public string CustomerName { get; set; }
    public string MenuItem { get; set; }
    public decimal Payment { get; set; }
    public string Status { get; set; }
}
namespace Revision.Data;

public class Product : IComparable<Product>
{
	public long ProductID { get; set; }
	public string ProductName { get; set; }
	public string Category { get; set; }
	public decimal UnitPrice { get; set; }
	public int UnitsInStock { get; set; }

	public int CompareTo(Product? other)
		=> this.UnitPrice.CompareTo(other?.UnitPrice);
		

	public override string ToString()
		=> $"ProductID:{ProductID},ProductName:{ProductName},Category{Category},UnitPrice:{UnitPrice},UnitsInStock:{UnitsInStock}";

}

public class Product02 : Product
{
	public int SerialNumber { get; set; }
}
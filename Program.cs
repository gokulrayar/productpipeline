// See https://aka.ms/new-console-template for more informatio

using Consoleproject;

List<Product> Products = new List<Product>()
{
new Product(){ Pname ="Iphone 13", Pprice="1,20000", brand="Apple",Mdate=new DateTime (day:12,month:11,year:2022),ExpDate=new DateTime (day:09,month:11,year:2035)},
new Product(){ Pname ="samsung s22",Pprice ="80,000",brand ="Samsung",Mdate=new DateTime (day:12,month:11,year:2022),ExpDate=new DateTime (day:09,month:11,year:2026)},
new Product(){ Pname ="realme gt",Pprice ="30,0000", brand="Android",Mdate=new DateTime (day:12,month:11,year:2022),ExpDate=new DateTime (day:09,month:11,year:2025)},



};
Console.WriteLine("Pname \t Pprice\t brand\t brand \t Mdate\t Expdate\t");

foreach (Product pro in Products)
{
    Console.Write(pro.Pname + "\t \t");
    Console.Write(pro.Pprice + "\t \t");
    Console.Write(pro.brand + "\t \t");
    Console.Write(pro.Mdate.ToLongDateString());
    Console.Write(pro.ExpDate.ToLongDateString());

}

using Task1;


Product p1 = new Product();
Console.WriteLine(p1.Name+p1.Price+p1.Description+p1.Color+ "\n");

Product p2 = new Product("OnlyName ");
Console.WriteLine(p2.Name+ p2.Price+ p2.Description+ p2.Color + "\n");

Product p3 = new Product("nameWithprice ",5.06);
Console.WriteLine(p3.Name+ p3.Price+ p3.Description+ p3.Color + "\n");

Product p4 = new Product("all ",5.06," notthing "," red");
Console.WriteLine(p4.Name+ p4.Price+ p4.Description+ p4.Color + "\n");
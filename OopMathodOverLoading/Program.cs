

using OOPMathodOverLoading;
OopMathodOverloadingProduct product1 = new OopMathodOverloadingProduct();


product1.Name = "Camera";
product1.Price = 30000;

//So here is the magic that that we see the our build in lagusase and ------------->> product1.CalculateDiscount()
//product1.Name.CalculateDiscount()

double varibale = product1.CalculateDiscount();
Console.WriteLine(varibale);




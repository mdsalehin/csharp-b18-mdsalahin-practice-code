//real life or world ecch and every object is independent
//declear object = class name + varibale  =  new agin class name ()

//so this in now constructor now  WaterBottle1 this is constructor 
WaterBottle1 bottle1 = new WaterBottle1("red",100);

//another object
WaterBottle1 bottle2 = new WaterBottle1("blue",150);

//mathod access now
bottle1.AddWater(30);
bottle2.AddWater(50);
bottle2.AddWater(30);

//print Property
Console.WriteLine("Water Amount:");
Console.WriteLine(bottle1.Propertywateramount);
Console.WriteLine(bottle2.Propertywateramount);
Console.WriteLine();

// Print capacity and color for bottle1
Console.WriteLine("Bottle 1:");
Console.WriteLine("Color: " + bottle1.Propertycolor);
Console.WriteLine("Capacity: " + bottle1.Capacity);
Console.WriteLine("Water Amount: " + bottle1.Propertywateramount);

// Print capacity and color for bottle2
Console.WriteLine("\nBottle 2:");
Console.WriteLine("Color: " + bottle2.Propertycolor);
Console.WriteLine("Capacity: " + bottle2.Capacity);
Console.WriteLine("Water Amount: " + bottle2.Propertywateramount);

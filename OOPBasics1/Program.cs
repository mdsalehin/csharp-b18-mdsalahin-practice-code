//declear object = class name + varibale  =  new agin class name ()
WaterBottle1 bottle1 = new WaterBottle1();

//real life or world ecch and every object is independent

//another object
WaterBottle1 bottle2 = new WaterBottle1();

//acces class element by object name dot

bottle1.capacity = 100;
bottle1.color = "red";

bottle2.capacity = 150;
bottle2.color = "blue";


//mathod access now

bottle1.AddWater(30);

bottle2.AddWater(50);
bottle2.AddWater(30);

//print

Console.WriteLine(bottle1.waterAmount);
Console.WriteLine(bottle2.waterAmount);
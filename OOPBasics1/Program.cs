//real life or world ecch and every object is independent
//declear object = class name + varibale  =  new agin class name ()

WaterBottle1 bottle1 = new WaterBottle1();

//another object

WaterBottle1 bottle2 = new WaterBottle1();

//acces class element by object name dot

bottle1.capacity = 100;
bottle1.color = "red";

bottle2.capacity = 150;
bottle2.color = "blue";

//this is not make sense capacity = 100; but water amount =300 ayjno property feature use kre thaki
//bottle1.waterAmount = 330;

//Using Property

bottle1.Propertywateramount = 300;

/*if bottle1.Propertywateramount = 100;<=100 then it was change the value
    this one is not the write things is only example purpose */ 




//mathod access now

bottle1.AddWater(30);

bottle2.AddWater(50);
bottle2.AddWater(30);

//print Property

Console.WriteLine(bottle1.Propertywateramount);
Console.WriteLine(bottle2.Propertywateramount);
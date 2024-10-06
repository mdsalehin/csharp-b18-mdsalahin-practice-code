//object declaration in c#
//object = (class name + varibale) = KeywordName-> (new then again class name )
//object = each and every iteam is indepandent.like a blueprint of class akta change krle oprtar kno change nai

//object declaration
/*WaterBottle bottle1 = new WaterBottle();
bottle1.capacity = 100;
bottle1.color = "red";
*/



//work_with_consturctor 
WaterBottle bottle1 = new WaterBottle("red",100);



/*ayta ki hoilo ayta kisu hoilo?? addwater to thaole thaaklaoi nah 
bottle1.waterAmount = 300;*/
//ayta solve korar jno lagbe property feature  and saterr and gater mathod

//using property but this is not varibale.
//bottle1.Propertywateramount = 300;

//mathod call
bottle1.AddWater(30);



/////////////////////////////////////////////////////////////////////////

//another object

/*WaterBottle bottle2 = new WaterBottle();
bottle2.capacity = 150;
bottle2.color = "blue";
*/

//work_with_consturctor 
WaterBottle bottle2 = new WaterBottle("blue",150);






//mathod call
bottle2.AddWater(50);
bottle2.AddWater(30);


//print
//Console.WriteLine(bottle1.waterAmount);
//Console.WriteLine(bottle2.waterAmount);

//print after property declaration
Console.WriteLine(bottle1.Propertywateramount);
Console.WriteLine(bottle2.Propertywateramount);



// Print capacity and color for bottle1
Console.WriteLine("Bottle 1:");
Console.WriteLine("Color: " + bottle1.Color);
Console.WriteLine("Capacity: " + bottle1.Capacity);
Console.WriteLine("Water Amount: " + bottle1.Propertywateramount);

// Print capacity and color for bottle2
Console.WriteLine("\nBottle 2:");
Console.WriteLine("Color: " + bottle2.Color);
Console.WriteLine("Capacity: " + bottle2.Capacity);
Console.WriteLine("Water Amount: " + bottle2.Propertywateramount);



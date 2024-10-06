//Encapsulation
//Access Modifier
//class toiri kora + access modifier ay 2tar mdhme encapsulation kora hoye thake.
//Encapsulation =  Class + Access Modifier.

//Access Modifier = private,protected,internal,public

class WaterBottle 
{
    private double capacity; //variable hoche = ki ache agolo ke consider krbo variable hisabe.
    private string color;   //variable hoche = information ba data.
    private double waterAmount;

    //decalaration Property avoid confilt of program.cs ar addwater to thaole thaaklaoi nah ayline

    // Property decalaration 
    public double Propertywateramount
    {
       // propety kintu data hold krtase nah data hold krtase (waterAmount)
        get
        {
            //deacler varibale
            return waterAmount;
        }
       private set
        {
            //aykhne wateramount ar value ta set krchi.
            if (value <= capacity)
            {
                waterAmount = value;
            }

        }

    }

    /* property means = mathod e mne korbo.property is one
    kinds of mathod.diffrence is there is no paramitter */




    //to_know_color_and_capacity_how_much_we_use another property

    public string Color
    {
        get
        {
            return color;
        }
    }
    public double Capacity
    {
        get
        {
            return capacity;
        }
    }


    //Constructor has no return type
    //Now Work With Constructor

  /*  class name and no return Type no another name allow on constructor.
        allow only class name in construtor*/

   // consturctor declearation
    public WaterBottle(string color, double ToAvoidThisWeUseDifferentNameOFCapacity)
    {
        this.color = color;
        capacity = ToAvoidThisWeUseDifferentNameOFCapacity;
    }



    public void AddWater(double amount) //mahtod hoche = ki korte pare.Action bujai mathod ke.
    {
        if(Propertywateramount + amount <= capacity)
        {
            Propertywateramount = Propertywateramount + amount;
        }       
    }

    public void ReleaseWater(double amount)
    {
        if(Propertywateramount < amount)
        {
            Propertywateramount = 0;
        }
        else
        {
            Propertywateramount -= amount;
        }  
    }

}

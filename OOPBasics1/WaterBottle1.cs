class WaterBottle1
{
    //variables
    private double capacity;
    private string color;
    private double waterAmount;
  
    /*  property means = mathod e mne korbo.property is one
        kinds of mathod.diffrence is there is no paramitter    
        To avoid Conflict we are using Property Feature So its one kind of varibale but
        diffrence is Property 1ST later is Capital */


    //using Property
    public double Propertywateramount
    {
        get
        {
            return waterAmount;
        }
        //Adding Access Modifier private 
        private set
        {
            if(value <= capacity )
            {
                waterAmount = value;
            }            
        }
    }

    //To Knew the Color and Capacity How Much We Use Another Property
    public string Propertycolor
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

    /*there is no return type in constructor.
     constructor always class ar nam onojai e hoye thake*/

    //Constructor
    public WaterBottle1(string color, double ToAvoidThisWeUseDifferentNameOFContructorcapacity)
    {
        this.color = color;
        capacity = ToAvoidThisWeUseDifferentNameOFContructorcapacity;
    }

    public void AddWater(double amount)
    {
        //akn set class ar vitor diya acces krte parbo but bahire thake ar use krte parbo nah.acces modifier ar jno

        if (Propertywateramount + amount <= capacity)
        {
            Propertywateramount  = Propertywateramount + amount;
        }       
    }
    public void ReleaseWater(double amount)
    {
        if(Propertywateramount  < amount)
        {
            Propertywateramount  = 0;
        }
        else
        {
            Propertywateramount  = Propertywateramount  - amount;
        }       
        
    }

}
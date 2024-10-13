class WaterBottle1
{
    //variables
    private double capacity;
    private string color;
    private double waterAmount;

    //Apply Auto Property   so this is using  Auto Property this is just for an example. 
    public double Weight { get; set; }

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
            if (value <= capacity)
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
            Propertywateramount = Propertywateramount + amount;
        }
    }
    public void ReleaseWater(double amount)
    {
        if (Propertywateramount < amount)
        {
            Propertywateramount = 0;
        }
        else
        {
            Propertywateramount = Propertywateramount - amount;
        }

    }
}


class WaterBottle1
{
    //variables
    public double capacity;
    public string color;
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
        set
        {
            if(value <= capacity )
            {
                waterAmount = value;
            }            
        }
    }
  

    public void AddWater(double amount)
    {
        if (waterAmount + amount <= capacity)
        {
            waterAmount = waterAmount + amount;
        }       
    }
    public void ReleaseWater(double amount)
    {
        if(waterAmount < amount)
        {
            waterAmount = 0;
        }
        else
        {
            waterAmount = waterAmount - amount;
        }       
        
    }

}
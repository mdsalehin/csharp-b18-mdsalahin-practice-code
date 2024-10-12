//Encapsulation
//Access Modifier
//class toiri kora + access modifier ay 2tar mdhme encapsulation kora hoye thake.
//Encapsulation =  Class + Access Modifier.
//Access Modifier = private,protected,internal,public


class WaterBottle1
{
    public double capacity;
    public string color;
    public double waterAmount;

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
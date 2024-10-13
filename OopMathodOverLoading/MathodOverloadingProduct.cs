//so we are implement now Mathod OverLoading.
/* Mathod Overloading Polymorfizim ar akta feature so.akoi name mathod thakbe but aykhne Parameter different hobe */
namespace OOPMathodOverLoading
{
    public class OopMathodOverloadingProduct
    {
        //Ami jdi Auto Property use nah kre varibale use krtam code lenth onk bashi hoto + ayta long turm ar jno use ful o nah.

        /*   private double defaultDiscount;
             private double DefaultDiscount;
           {
               get { return defaultDiscount; }
               set { defaultDiscount = value; }
           }
       */


        //UsinG Auto Property
        // private double DefaultDiscount { get; set; } = 10 ayvabe variable mto korae intaliza krte pari Property ke 

        private double DefaultDiscount { get; set; } = 10;  //auto property vitore vitore akta varibale declear kore nay.but ayta amra dkte pai nah    
        public double Price { get; set; }
        public string Name { get; set; }


        //New Fature TO Controll the acceess

        /// <summary>
        ///Calculate Discount WithOut A limit Salehin
        /// </summary>
        /// <returns></returns>


        //declearing mathod
        //Mathod OverLoading.
        public double CalculateDiscount()
        {
            return Price * DefaultDiscount / 100;
        }

        /// <summary>
        /// Calculate Discount using a maximum allowed discount
        /// </summary>
        /// <param name="maximumDiscount">The maximum allowed Discount Value MS7 </param>
        /// <returns></returns>


        //same name ar akta mathod thakeb but paramitter difference hobe.
        public double CalculateDiscount(int maximumDiscount)
        {
            double discount = Price * DefaultDiscount / 100;

            if (discount > maximumDiscount)
            {
                return maximumDiscount;
            }
            else
            {
                return discount;
            }

            //same kaj but using Tarnari Operator
            /* 
              return discount > maximumDiscount ? maximumDiscount : discount;
            */

            //AnotherWay 
            /* 
               return discount > maximumDiscount
                ? maximumDiscount
                : discount;
            */
        }

    }
}

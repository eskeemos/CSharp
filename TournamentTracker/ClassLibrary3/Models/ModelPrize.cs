using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class ModelPrize
    {
        public int ID { get; set; }
        public int PlaceNumber { get; set; }
        public string PlaceName { get; set; }
        public decimal PrizeAmount { get; set; }
        public double PrizePercentage { get; set; }
        public ModelPrize(string placeNumber, string placeName, string prizeAmount, string prizePercentage)
        {
            int placeNumberValid = 0;
            int.TryParse(placeNumber, out placeNumberValid);
            PlaceNumber = placeNumberValid;

            PlaceName = placeName;

            int prizeAmountValid = 0;
            int.TryParse(prizeAmount, out prizeAmountValid);
            PrizeAmount = prizeAmountValid;

            int prizePercentageValid = 0;
            int.TryParse(prizePercentage, out prizePercentageValid);
            PrizePercentage = prizePercentageValid;
        }
        public ModelPrize()
        {

        }
    }
}

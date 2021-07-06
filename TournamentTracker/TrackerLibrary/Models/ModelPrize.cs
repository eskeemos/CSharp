using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class ModelPrize
    {
        public int ID { get; set; }
        public int PlaceNumber { get; set; }
        public string PlaceName { get; set; }
        public int PrizeAmount { get; set; }
        public float PrizePercentage { get; set; }
        public ModelPrize(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValid = 0;
            int.TryParse(placeNumber, out placeNumberValid);
            PlaceNumber = placeNumberValid;

            int prizeAmountValid = 0;
            int.TryParse(prizeAmount, out prizeAmountValid);
            PrizeAmount = prizeAmountValid;

            int prizePercentageValid = 0;
            int.TryParse(prizePercentage, out prizePercentageValid);
            PrizePercentage = prizePercentageValid;
        }
    }
}

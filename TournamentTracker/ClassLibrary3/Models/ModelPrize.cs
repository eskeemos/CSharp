namespace TrackerLibrary.Models
{
    public class ModelPrize // REFACTORED
    {
        public int ID { get; set; }
        public int PlaceNumber { get; set; }
        public string PlaceName { get; set; }
        public decimal PrizeAmount { get; set; }
        public double PrizePercentage { get; set; }
        public ModelPrize(string placeNumber, string placeName, string prizeAmount, string prizePercentage)
        {
            int.TryParse(placeNumber, out int placeNumberValid);
            PlaceNumber = placeNumberValid;

            PlaceName = placeName;

            int.TryParse(prizeAmount, out int prizeAmountValid);
            PrizeAmount = prizeAmountValid;

            int.TryParse(prizePercentage, out int prizePercentageValid);
            PrizePercentage = prizePercentageValid;
        }
        public ModelPrize()
        {

        }
    }
}

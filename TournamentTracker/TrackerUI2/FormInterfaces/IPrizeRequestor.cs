using TrackerLibrary.Models;

namespace TrackerUI2
{
    public interface IPrizeRequestor // Refactored
    {
        void PrizeComplete(ModelPrize prize);
    }
}

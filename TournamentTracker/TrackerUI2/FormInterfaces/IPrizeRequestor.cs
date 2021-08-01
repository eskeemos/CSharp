using TrackerLibrary.Models;

namespace TrackerUI2
{
    public interface IPrizeRequestor // REFACTORED
    {
        void PrizeComplete(ModelPrize prize);
    }
}

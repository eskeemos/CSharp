using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI
{
    public partial class PrizeCreate : BaseSets
    {
        public PrizeCreate()
        {
            InitializeComponent();
        }

        private void bCreatePrize_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {

            }
            else
            {

            }
        }
        private bool ValidateForm()
        {
            int placeNumber = 0;
            bool placeNumberValid = int.TryParse(tbPlaceNumber.Text, out placeNumber);

            if (!placeNumberValid) return false;
            if (placeNumber < 1) return false;

            if (tbPlaceName.Text.Length == 0) return false;

            int prizeAmount = 0;
            float prizePercentage = 0;
            bool prizeAmountValid = int.TryParse(tbPlaceAmount.Text, out prizeAmount),
                 prizePercentageValid = float.TryParse(tbPrizePercentage.Text, out prizePercentage);

            if ((!prizeAmountValid)||(!prizePercentageValid)) return false;
            if ((prizeAmount <= 0)||(prizePercentage <= 0)||(prizePercentage > 100)) return false;
            
            return true;
        }
    }
}

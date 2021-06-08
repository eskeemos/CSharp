using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemHR.UserInterface.Extensions
{
    public static class ExtenionsMethod
    {
        public static void DateTimePickerValueChange(this DateTimePicker dtp)
        {
            dtp.Format = DateTimePickerFormat.Short;
        }
    }
}

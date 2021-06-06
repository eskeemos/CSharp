using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysetemHR.DataAccessLayer.Models.Dictionaries
{
    public class StatusModel : EntityModel
    {
        public new string Value { get; set; }
        public StatusModel(string value)
        {
            Value = value;
        }
        public override string ToString()
        {
            return Value;
        }

    }
}

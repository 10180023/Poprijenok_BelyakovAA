using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poprijenok_BelyakovAA
{
    public partial  class Agent
    {
        public override string ToString()
        {
            return Title;
        }

        public string LogoAgent()
        {
            if (Logo == null)
            {
                return "../../Img/picture.png";
            }
            else
            {
                return string.Format("../../agents", Logo);
            }
        }
    }
}

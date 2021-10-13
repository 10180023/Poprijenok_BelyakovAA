using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poprijenok_BelyakovAA.Model
{
    public partial  class Agent
    {
        public string LogoAgent => Logo == null ? "../../Img/picture.png" : Logo;
    }
}

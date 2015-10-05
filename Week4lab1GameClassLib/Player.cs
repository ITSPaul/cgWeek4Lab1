using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4lab1GameClassLib
{
    [Serializable]
    public class Player
    {
        public Guid playerID;
        public string GamerTag;
        public string UserName;
        public string FirstName;
        public string SecondName;
        public int XP;
        public int clientID;
    }

}

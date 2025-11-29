using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loups_Garoups_de_Thiercelieux_console.Classes
{
    public struct VoteData
    {
        public int vote;
        public int weight;

        public VoteData(int vote, int weight)
        {
            this.vote = vote;
            this.weight = weight;
        }

        public override string ToString()
        {
            string toString = string.Format($"vote : {vote}, weight : {weight}");
            return toString;
        }
    }
}

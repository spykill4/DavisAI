using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavisNLP
{
    /*
    Class for grouping words into more understandable (program-wise) groups
    */
    class GroupedWords
    {
        /*
        Enum to denote type of group
        */
        public enum GroupType
        {
            SUBJ // subject
            , PRED // predicate
            , NNPH // noun phrase
        }

        /*
        Children of this group
        */
        public GroupedWords[] subgroups;
    }
}

using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter_CriteriaPattern
{
    interface ICriteria
    {
        //returns and a list of person objects
        ArrayList meetCriteria(ArrayList persons);
    }

}

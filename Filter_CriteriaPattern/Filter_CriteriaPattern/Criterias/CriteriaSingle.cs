using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter_CriteriaPattern
{
    class CriteriaSingle : ICriteria
    {
        public ArrayList meetCriteria(ArrayList persons)
        {
            ArrayList singlePersons = new ArrayList();
            foreach (Person p in persons)
            {
                if (p.getMaritalStatus().Equals("single")) { singlePersons.Add(p); }
            }

            return singlePersons;
        }

    }
}

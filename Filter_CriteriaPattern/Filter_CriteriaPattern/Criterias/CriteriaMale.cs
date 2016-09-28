using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter_CriteriaPattern
{
    class CriteriaMale : ICriteria
    {
        public ArrayList meetCriteria(ArrayList persons)
        {
            ArrayList malePersons = new ArrayList();
            foreach(Person p in persons)
            {
                if (p.getGender().Equals("MALE")) { malePersons.Add(p); }
            }

            return malePersons;
        }
    }
}

using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter_CriteriaPattern
{
    class CriteriaFemale : ICriteria
    {
        public ArrayList meetCriteria(ArrayList persons)
        {
            ArrayList feMalePersons = new ArrayList();
            foreach (Person p in persons)
            {
                if (p.getGender().Equals("female")) { feMalePersons.Add(p); }
            }

            return feMalePersons;
        }
    }
}
    


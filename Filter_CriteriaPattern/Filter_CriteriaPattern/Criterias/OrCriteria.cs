using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter_CriteriaPattern.Criterias
{
    class OrCriteria
    {
        private ICriteria criteria;
        private ICriteria otherCriteria;

        public OrCriteria(ICriteria criteria, ICriteria otherCriteria)
        {
            this.criteria = criteria;
            this.otherCriteria = otherCriteria;
        }

        public ArrayList meetCriteria(ArrayList persons)
        {
            ArrayList firstCriteriaItems = criteria.meetCriteria(persons);
            ArrayList otherCriteriaItems = otherCriteria.meetCriteria(persons);

            foreach (Person p in otherCriteriaItems)
            {
                if (!firstCriteriaItems.Contains(p))
                {
                    firstCriteriaItems.Add(p);
                }
            }

            return firstCriteriaItems;
        }
    }
    
}

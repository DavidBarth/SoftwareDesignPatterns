using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter_CriteriaPattern
{
    class AndCriteria : ICriteria
    {

        private ICriteria criteria;
        private ICriteria otherCriteria;

        //constructor
        public AndCriteria(ICriteria criteria, ICriteria otherCriteria)
        {
            this.criteria = criteria;
            this.otherCriteria = otherCriteria;

        }

        public ArrayList meetCriteria(ArrayList persons)
        {
            ArrayList firstCriteriaPersons = criteria.meetCriteria(persons);
            return otherCriteria.meetCriteria(firstCriteriaPersons);
        }
           
    }
}

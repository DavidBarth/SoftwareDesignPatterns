using Filter_CriteriaPattern.Criterias;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Filter_CriteriaPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList persons = new ArrayList();
            persons.Add(new Person("Robert", "male", "single"));
            persons.Add(new Person("Tammy", "female", "married"));
            persons.Add(new Person("Eugene", "male", "married"));
            persons.Add(new Person("Diana", "female", "single"));
            persons.Add(new Person("Mike", "male", "single"));
            persons.Add(new Person("Sophie", "female", "single"));

            ICriteria male = new CriteriaMale();
            ICriteria female = new CriteriaFemale();
            ICriteria single = new CriteriaSingle();
            ICriteria singleMale = new AndCriteria(single, male);
            ICriteria singleOrFemale = new OrCriteria(single, female);

            Console.WriteLine("Males: ");
            printPersons(male.meetCriteria(persons));

            Console.WriteLine("Females: ");
            printPersons(female.meetCriteria(persons));

            Console.WriteLine("Single males: ");
            printPersons(singleMale.meetCriteria(persons));

            Console.WriteLine("Single females: ");
            printPersons(singleOrFemale.meetCriteria(persons));

            Console.ReadKey();
        }

        public static void printPersons(ArrayList persons)
        {
            foreach(Person p in persons)
            {
                
               Console.WriteLine("Person name: {0} | Gender: {1} | Status: {2}", p.getName(), p.getGender(), p.getMaritalStatus());
            }
        }
    }
}

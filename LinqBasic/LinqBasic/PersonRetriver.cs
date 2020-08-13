using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqBasic.Abstract;
namespace LinqBasic
{
    public class PersonRetriver : IPersonRetriver
    {
        public IEnumerable<int> GetMalesId(IEnumerable<Person> persons)
        {
            return persons.Where(person => person.PersonGender == Gender.Male)
                .Select(person => person.Id);
        }

        public IEnumerable<Person> GetOddIds(IEnumerable<Person> persons)
        {
            return persons.Where(person => person.Id %2 == 1);
        }

        public IEnumerable<Person> OrderById(IEnumerable<Person> persons)
        {
            return persons.OrderByDescending(person => person.Id);
        }
    }
}

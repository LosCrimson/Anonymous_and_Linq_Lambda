using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Lambda.Task1
{
    public class NumberListService
    {
        public List<int> numberList = new List<int> 
        { 1, 56, 836, 25, 45, 85};

        public List<int> numberListSquaredUsingSelect = new List<int>();

        public List<int> numberListPositiveNegative = new List<int>
        { 1, -56, 836, -25, -45, 85, 10, 5, -8, 4, -4, 6, 7, 2, -1};

        public List<int> numberListPositive = new List<int>();

        public List<int> numberListPositiveLessThanTen = new List<int>();

        public List<int> numberListAscendingOrder = new List<int>();

        public List<int> numberListDescendingOrder = new List<int>();

        //using linq find bigest number 

        public List<Person> persons = new List<Person> 
        {
            new Person("Lukas", 55),
            new Person("Daina", 35),
            new Person("Aurimas", 48),
            new Person("Ieva", 68),
            new Person("Jona", 13),
            new Person("Tauras", 91),
        };

        public List<int> personsListNames = new List<int>();

        public List<int> personsListAge = new List<int>();

        // descending order by age

        public List<int> personsListNamesStartLetterA = new List<int>();

        public List<int> personsListAbove40SortName = new List<int>();
    }
}

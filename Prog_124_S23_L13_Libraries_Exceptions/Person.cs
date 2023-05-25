using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L13_Libraries_Exceptions
{
    internal class Person
    {

        string _firstName;
        string _lastName;

        // Constructor
        public Person(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public Person(string firstName)
        {
            Console.WriteLine($"We have constructed a person: {_firstName}");
        }

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }

        // Destructor
        // Tilde ~
        // A Destructor is AUTOMATICALLY CALLED, when the object is queued up for garbage collection
        ~Person()
        {
            Console.WriteLine($"The Destructor was called: {_firstName}");          
        } // Destructor()

    }
}

using Exception_learn.Models;
using System.Security.Cryptography.X509Certificates;

namespace Exception_learn
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Person person = CreatePerson();
            //Console.WriteLine(person.Name);

            do
            {
                Console.WriteLine("Please enter Name:");
                string name = Console.ReadLine();

                try
                {
                    Person person = new Person(name);
                    Console.WriteLine(person.Name);
                    break;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (true);

        }

        private static Person CreatePerson()
        {
            Console.WriteLine("Please enter Name:");
            string name = Console.ReadLine();
            try
            {
                Person person = new Person(name);
                return person;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return CreatePerson();
            }

        }

        
    }
}

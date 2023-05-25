using MyClassLibrary;


namespace Prog_124_S23_L13_Libraries_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Class Libraries
            // We need to connect our class library to our application
            // Add your dependency for your class library
            // Add the using
            // Use like normal
            List<Vehicle> _vehicles = new List<Vehicle>();
            _vehicles.Add(new Land("Bertha"));
            _vehicles.Add(new Sea("SSLetzSea"));
            _vehicles.Add(new Air("Moiz"));

            foreach (Vehicle vehicles in _vehicles)
            {
                Console.WriteLine(vehicles);
            }


            // Exceptions

            // Deconstructors
            // Destructors


        }

        public void DestructorExample()
        {

            for (int i = 0; i < 100000; i++)
            {
                new Person("Will" + i);
            }
        }
    }
}

using System;

namespace InterfaceSegregation
{
    public class Arquitect : IActivities
    {
        public void Test()
        {
            throw new ArgumentException();
        }

        public void Plan()
        {
            throw new ArgumentException();
        }

        public void Comunicate()
        {
            throw new ArgumentException();
        }


        public void Design()
        {
            Console.WriteLine("I'm designing new futures");
        }

        public void Develop()
        {
            Console.WriteLine("I'm developing the functionalities required");
        }
    }
}
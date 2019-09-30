using System;

namespace excercises_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Dodo dodo = new Dodo();

            dodo.Age = 10;
            dodo.Name = "Peter";
            dodo.Extinct = true;

            dodo.Speak();
        }
    }
}

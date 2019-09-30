using System;

namespace excercises_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Dodo dodo = new Dodo(10, "Karl", false);
            dodo.Speak();

            dodo.Age = 10;
            dodo.Name = "Peter";
            dodo.Extinct = true;

            dodo.Speak();
        }
    }
}

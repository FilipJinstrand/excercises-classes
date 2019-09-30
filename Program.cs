using System;

namespace excercises_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Dodo dodo = new Dodo();

            dodo.age = 10;
            dodo.name = "Peter";
            dodo.extinct = true;

            dodo.Speak();
        }
    }
}

using System;

namespace excercises_classes
{
    class Dodo
    {
        public int age;
        public string name;
        public bool extinct;

        private string extinctMessage;



        public void Speak(){

            if (extinct)
            {
                extinctMessage = "jag är utdöd";
            }
            else
            {
                extinctMessage = "jag lever!";
            }

            Console.WriteLine("Jag är " + age + " gammal, jag heter " + name + ", och " + extinctMessage);
        }
    }
}
using System;

namespace excercises_classes
{
    class Dodo
    {
        private int age;
        private string name;
        private bool extinct;

        private string extinctMessage;

        public Dodo(int ConAge, string ConName, bool ConExtinct){
            age = ConAge;
            name = ConName;
            extinct = ConExtinct;
        }


        public int Age{
            get{
                return age;
            }
            set{
                age = value;
            }
        }

        public string Name{
            get{
                return name;
            }
            set{
                name = value;
            }
        }

        public bool Extinct{
            get{
                return extinct;
            }
            set{
                extinct = value;
            }
        }



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
namespace OODemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDE ide = new IDE();
            LangCSharp cs = new LangCSharp();
            LangJava java = new LangJava();
            LangC c = new LangC();

            ide.CS = cs;
            ide.Java = java;
            ide.C = c;

            ide.StartWork();


        }
    }

    class IDE
    {
        //LangCSharp cs = new LangCSharp();

        public LangCSharp CS { get; set; }
        public LangC C { get; set; }
        public LangJava Java { get; set; }


        public void StartWork()
        {
            Console.WriteLine(CS.GetName());
            Console.WriteLine(CS.GetUnit());
            Console.WriteLine(CS.GetParadigm());
            Console.WriteLine("---------------------");
            Console.WriteLine(Java.GetName());
            Console.WriteLine(Java.GetUnit());
            Console.WriteLine(Java.GetParadigm());
            Console.WriteLine("---------------------");
            Console.WriteLine(C.GetName());
            Console.WriteLine(C.GetUnit());
            Console.WriteLine(C.GetParadigm());
            Console.WriteLine("---------------------");
        }

    }


    class LangCSharp
    {
        public string GetName()
        {
            return "C Sharp";
        }

        public string GetUnit()
        {
            return "Class";
        }

        public string GetParadigm()
        {
            return "Object Oriented";
        }
    }

    class LangC
    {
        public string GetName()
        {
            return "C Lang";
        }

        public string GetUnit()
        {
            return "Function";
        }

        public string GetParadigm()
        {
            return "Procedure Oriented";
        }
    }

    class LangJava
    {
        public string GetName()
        {
            return "Java";
        }

        public string GetUnit()
        {
            return "Class";
        }

        public string GetParadigm()
        {
            return "Object Oriented";
        }
    }


}

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
            Python py = new Python();


            //ILanguage l = new ILanguage();
            //ObjectOriented oo = new ObjectOriented();

            ILanguage il = new LangCSharp();

            //ide.CS = cs;
            //ide.Java = java;
            //ide.C = c;

            ide.Languages.Add(cs);
            ide.Languages.Add(java);
            ide.Languages.Add(c);
            ide.Languages.Add(py);

            ide.StartWork();


        }
    }

    class IDE // OCP
    {
        //LangCSharp cs = new LangCSharp();

        //public LangCSharp CS { get; set; }
        //public LangC C { get; set; }
        //public LangJava Java { get; set; }

        //public List<ILanguage> Languages = new List<ILanguage>();
        public List<ILanguage> Languages { get; set; } = new List<ILanguage>();

        public void StartWork()
        {
            foreach (ILanguage language in Languages)
            {
                Console.WriteLine(language.GetName());
                Console.WriteLine(language.GetUnit());
                Console.WriteLine(language.GetParadigm());
                Console.WriteLine("---------------------");
            }


        }

    }


    interface ILanguage
    {
        string GetName();
        string GetUnit();
        string GetParadigm();
    }


    abstract class ObjectOriented : ILanguage
    {
        abstract public string GetName();
        //{
        //    throw new NotImplementedException();
        //}

        public string GetParadigm()
        {
            return "Object Oriented";
        }

        public string GetUnit()
        {
            return "Classes";
        }
    }

    class LangCSharp : ObjectOriented // Generalization - Realization - IS-A
    {
        override public string GetName()
        {
            return "C Sharp";
        }


    }

    class LangC : ILanguage
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

    class LangJava : ObjectOriented
    {
        override public string GetName()
        {
            return "Java";
        }


    }

    class Python : ObjectOriented
    {
        override public string GetName()
        {
            return "Python";
        }


    }

    public class JavaScript : ILanguage
    {
    }
}

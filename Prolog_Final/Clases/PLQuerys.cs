using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SbsSW.SwiPlCs;

namespace Prolog_Final.Clases
{
    class PLQuerys
    {
        private static PLQuerys instance;
        public static PLQuerys Instance
        {
          get 
             {
              if (instance == null)
                           {
                             instance = new PLQuerys();
                           }
         return instance;
             }
        }

        private PLQuerys()
        {
            
        }
        public void Prolog_Connection()
        {
            Environment.SetEnvironmentVariable("SWI_HOME_DIR", @"C:\\Program Files (x86)\\swipl");
            Environment.SetEnvironmentVariable("Path", @"C:\\Program Files (x86)\\swipl");
            Environment.SetEnvironmentVariable("Path", @"C:\\Program Files (x86)\\swipl\bin");
            String[] param = { @"C:\Users\Hector\Desktop\Prolog_Final\examen-final.pl" };
            PlEngine.Initialize(param);

        }

        public int P_Score = 0;
        public int Cpu_Score = 0;
        public int Get_Category(string Categoria)
        {
            var q = new PlQuery("categoria(X,"+Categoria+",Y,Z)");
            foreach (PlQueryVariables v in q.SolutionVariables)
            {
                return Convert.ToInt32(v["Z"].ToString());
            }
            return 0;
            
        }

        public string Get_Question(string Name_Category, string puntaje)
        {
            
            List<string>  Question = new List<string>();
            var q = new PlQuery("pregunta(X,"+Name_Category+","+puntaje+")");
            foreach(PlQueryVariables v in q.SolutionVariables)
            {
                return v["X"].ToString();
            }
            return null;
        }
        
        
        public void Get_Option()
        {

        }

        public string Answer(string Categoria,string Pregunta,string Answer)
        {
                var q = new PlQuery("respuesta("+Pregunta+","+Categoria+",Y,X)");
                foreach (PlQueryVariables v in q.SolutionVariables)
                {
                    
                    if(Answer.Equals(v["Y"].ToString()))
                    {
                        return "correcto";
                    }
                    else
                    {
                        return "incorrecta";
                    }
                }
                
            return "Entre aqui";
        }

        public int Point_Answer(string Categoria, string Pregunta)
        {
            var q = new PlQuery("respuesta(" + Pregunta + "," + Categoria + ",Y,X)");
            foreach (PlQueryVariables v in q.SolutionVariables)
            {

                    return P_Score = Convert.ToInt32(v["X"].ToString());

            }

            return 0;
            
        }
        public string Get_MachineAnswer(string Estado)
        {
            var Machine = new PlQuery("jugandoconlamaquina("+Estado+",X)");
            foreach (PlQueryVariables v in Machine.SolutionVariables)
            {
               
                return v["X"].ToString();
            }
            return "entre aqui";
        }
        public void Get_NoOption()
        {

        }
    }
}

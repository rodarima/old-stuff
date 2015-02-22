using System.Text.RegularExpressions;
using System;
namespace Utils
{
    class Html
    {
        static public bool ExistePersonaEnHTML(string code)
        {
            int N_Personas = Regex.Matches(code, @"user_item_(?<user_id>(\d)*) class=").Count;
            if(N_Personas>0)return true;
            return false;
        }
    }
    class User
    {
        public static int get_num_users(string code)
        {
            string num = Regex.Match(code, @"<SPAN class=result>\((?<num_amigos>(\d)*) resultados\) </SPAN>").Groups["num_amigos"].Value;
            if (num != "")
            {
                int n = Convert.ToInt32(num);
                return n;
            }
            return 0;
        }
        public static int get_num_pages(int num_amigos)
        {
            double pages = (double)num_amigos / 10;
            int intpages = num_amigos / 10;

            if (pages - intpages != 0.0) { return intpages + 1; }
            return intpages;
        }



    }
}

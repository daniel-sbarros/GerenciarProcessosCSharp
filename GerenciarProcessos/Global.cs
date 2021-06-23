using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarProcessos
{
    public class Global
    {
        public static string DbName { get; set; } = "dclp.db";
        public static string Navegador 
        {
            get { return @"C:\Program Files\BraveSoftware\Brave-Browser\Application\brave.exe"; }
        }

        public static string Hoje
        {
            get { return (DateTime.Now.Day > 10 ? $"{DateTime.Now.Day}" : $"0{DateTime.Now.Day}") + "/" + (DateTime.Now.Month > 10 ? $"{DateTime.Now.Month}" : $"0{DateTime.Now.Month}") + "/" + DateTime.Now.Year; } 
        }
    }
}

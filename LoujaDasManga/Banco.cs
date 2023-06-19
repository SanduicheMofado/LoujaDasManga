using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoujaDasManga
{
    public class Banco
    {
        public static string Conexao
        {
            get
            {
                return "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\thiago.fscanabarro\\source\\repos\\LoujaDasManga\\aLouja.mdf;Integrated Security=True;Connect Timeout=30";
            }
        }
    }
}

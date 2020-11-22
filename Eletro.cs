using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appf1
{
    public class Eletro
    {
        private string modelo, marca;
        private double potencia,kwh;
        private Boolean mes;

        public Eletro(string mo, string ma, double p, Boolean m)
        {
            mes = m;
            modelo = mo;
            marca = ma;
            potencia = p;

        }

        public string calcularkwh(string tempo)
        {
                if (mes == true)
                {   
                    kwh = Math.Round((potencia / 1000) * (Double.Parse(tempo) / 60) * 30, 2);
                    return kwh.ToString();
                }
                    kwh = Math.Round((potencia / 1000) * (Double.Parse(tempo) / 60), 2);
                    return kwh.ToString();
        }

        public string gasto(string preco)
        {
                    return Math.Round(Double.Parse(preco) * kwh,2).ToString();
        }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.UCB.Framework.Util
{
    /// <summary>
    /// Classe responsável por tudo sobre combustível.
    /// Gasolina, Alcool, Diesel, Bio...
    /// </summary>
    public class Combustivel
    {
        /// <summary>
        /// Método que calcula se compensa abastecer com
        /// gasolina ou álcool.
        /// </summary>
        /// <param name="_valorGasolina">double</param>
        /// <returns>double</returns>
        public double calcularGasolinaEAlcool(double _valorGasolina)
        {
            return _valorGasolina * 0.70;
        }
    }
}

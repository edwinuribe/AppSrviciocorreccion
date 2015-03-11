using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppServicioEntregaPaquete.Modelo
{
    public class TwoDayPac : Package
    {

        #region "Atributos"
        private double cuotafija;
         #endregion

        #region "Propiedades"
       
        /// <summary>
        /// Establece o retorna el costo por cada gramo 
        /// </summary>
        public double CuotaFija
        {
            get { return cuotafija; }
            set { cuotafija = value; }
        }
        #endregion
  
        #region "Constructores"
        ///<summary>
        ///Contructor por defecto  de Package
        ///</summary>
        public TwoDayPac()
        {
           
            this.cuotafija =4.500 ;
        }

        ///<summary>
        ///Contructor de inicialización TwoDayPac
        ///</summary>
        ///<param name="cuotafija"> Cuota Fija</param>
       
        ///
        public TwoDayPac ( double cuotafija  )
        {
            this.cuotafija = cuotafija;
            
            
        }
        #endregion

        #region "Métodos Sobre Escritos"
        /// <summary>
        /// Retorna el valor del objeto representado en una cadena
        /// </summary>
        public override string ToString()
        {
            return "\n=============================================\n" +
                     
                     "Cuota Fija:  " + this.cuotafija;

        }

        /// <summary>
        /// Método que compara dos objectos
        /// </summary>
        public override bool Equals(object obj)
        {
            TwoDayPac o = (TwoDayPac)obj;
            bool result = false;

            if ((this.cuotafija == o.cuotafija))
                
                result = true;

            return result;
        }

        /// <summary>
        /// Devuelve la identificación del objecto
        /// </summary>
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        /// <summary>
        /// calcula el costo del envio 
        /// </summary>
        public double calculateCost(double costoasociado)
        {



            costoasociado = ((this.costogramo * this.pesokg)+this.cuotafija);
            return costoasociado;
        }


                #endregion
    }
}
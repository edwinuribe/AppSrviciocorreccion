using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppServicioEntregaPaquete.Modelo
{
    public class OvernightPackage : Package
    {

         #region "Atributos"

         private double costoentreganocturno;

         #endregion

         #region "Propiedades"
       
        /// <summary>
        /// Establece o retorna el costo por cada gramo 
        /// </summary>
         public double CostoEntregaNocturno
        {
            get { return costoentreganocturno; }
            set { costoentreganocturno = value; }
        }
        #endregion
  
         #region "Constructores"
        ///<summary>
        ///Contructor por defecto  de Package
        ///</summary>
        public OvernightPackage()
        {

            this.costoentreganocturno = 5000;
        }

        ///<summary>
        ///Contructor de inicialización TwoDayPac
        ///</summary>
        ///<param name="cuotafija"> Cuota Fija</param>
       
        ///
        public OvernightPackage(double costoentreganocturno)
        {
            this.costoentreganocturno = costoentreganocturno;
            
            
        }
        #endregion

         #region "Métodos Sobre Escritos"
        /// <summary>
        /// Retorna el valor del objeto representado en una cadena
        /// </summary>
        public override string ToString()
        {
            return "\n=============================================\n" +

                     "Cuota Fija:  " + this.costoentreganocturno;

        }

        /// <summary>
        /// Método que compara dos objectos
        /// </summary>
        public override bool Equals(object obj)
        {
            OvernightPackage o = (OvernightPackage)obj;
            bool result = false;

            if ((this.costoentreganocturno == o.costoentreganocturno))
                
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



            costoasociado = ((this.costogramo * this.pesokg) + this.cuotafija);
            return costoasociado;
        }






        #endregion

    }
}
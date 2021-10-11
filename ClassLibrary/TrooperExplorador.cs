using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTroopers
{
    public class TrooperExplorador : Trooper
    {
        #region Campos
        private string vehiculo;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor que inicializa el atributo "esClon" como falso, el vehiculo el ingresado y el blaster el modelo EC17
        /// </summary>
        /// <param name="vehiculo">Vehiculo del Trooper explorador</param>
        public TrooperExplorador(string vehiculo) : base()
        {
            this.Vehiculo = vehiculo;
            this.armamento = Blaster.EC17;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad abstracta de Tipo, retorna string con descripcion del Trooper
        /// </summary>
        public override string Tipo { get { return "Soldado de exploración"; } }

        /// <summary>
        /// Propiedad que valida que el texto no sea vacio (""). De serlo, asignara a vehiculo "Indefinido"
        /// </summary>
        public string Vehiculo
        {
            get { return this.vehiculo; }
            set
            {
                if (value == "")
                    this.vehiculo = "Indefinido";
                else
                    this.vehiculo = value;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Retorna la informacion del soldado con el formato deseado, mas la info del vehiculo
        /// </summary>
        /// <returns>String con la Informacion del Trooper y vehiculo</returns>
        public override string InfoTroopers()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(base.InfoTroopers());
            sb.AppendFormat($" – Vehículo: {this.Vehiculo}\n");

            return sb.ToString();
        }
        #endregion


    }
}

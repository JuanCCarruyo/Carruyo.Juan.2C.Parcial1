using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTroopers
{
    /// <summary>
    /// Enum del modelo de Blaster de las Tropas
    /// </summary>
    public enum Blaster
    {
        E11,
        EC17,
        DLT19
    }
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public abstract class Trooper
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    {
        #region Campos
        protected Blaster armamento;
        protected bool esClon;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor que inicializa el atributo "esClon" como falso
        /// </summary>
        protected Trooper()
        {
            this.esClon = false;
        }

        /// <summary>
        /// Constructor que inicializa el atributo "esClon" como falso y el blaster el ingresado
        /// </summary>
        /// <param name="armamento">Enum del modelo de blaster</param>
        protected Trooper(Blaster armamento): this()
        {
            this.armamento = armamento;
        }

        /// <summary>
        /// Constructor que crea un Trooper con el blaster, y estado clonado como el ingresado
        /// </summary>
        /// <param name="armamento">Enum del modelo de blaster</param>
        /// <param name="esClon">Bool con el status del Trooper (si es clonado o no)</param>
        protected Trooper(Blaster armamento, bool esClon) : this(armamento)
        {
            this.esClon = esClon;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad de Blaster de solo lectura
        /// </summary>
        public Blaster Armamento { get { return this.armamento; } }

        /// <summary>
        /// Propiedad del status de clonacion del Trooper
        /// </summary>
        public bool EsClon 
        {
            get { return this.esClon; }
            set { this.esClon = value; }
        }

        /// <summary>
        /// Propiedad abstracta de Tipo
        /// </summary>
        public abstract string Tipo { get;}
        #endregion

        #region Sobrecarga
        /// <summary>
        /// Sobrescritura del Metodo "Equals", retorna verdadero si ambos objectos son del mismo tipo.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>TRUE si ambos objetos son del tipo TYPE</returns>
        public override bool Equals(object obj)
        {
            if (this.GetType() == obj.GetType())
                return true;

            return false;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Retorna la informacion del soldado con un formato especifico ("[Tipo] armado con [Armamento], [SI/NO] es clone)
        /// </summary>
        /// <returns>String con la Informacion del Trooper</returns>
        public virtual string InfoTroopers()
        {
            StringBuilder sb = new StringBuilder();
            string cloneStatus = "NO";
            if (this.EsClon)
                cloneStatus = "";

            sb.AppendFormat($"{this.Tipo} armado con {this.Armamento}, {cloneStatus} es clone.\n");

            return sb.ToString();
        }
        #endregion
    }
}

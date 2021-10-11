using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTroopers
{
    public class TrooperAsalto : Trooper
    {
        #region Constructores
        /// <summary>
        /// Constructor que inicializa el atributo "esClon" como verdadero y el blaster el ingresado
        /// </summary>
        /// <param name="armamento">Enum del modelo de blaster</param>
        public TrooperAsalto(Blaster armamento) : base(armamento)
        {
            this.EsClon = true;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad abstracta de Tipo, retorna string con descripcion del Trooper
        /// </summary>
        public override string Tipo { get { return "Comando para misiones de infiltración"; } }
        #endregion
    }
}

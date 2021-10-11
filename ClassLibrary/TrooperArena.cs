using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTroopers
{
    public class TrooperArena : Trooper
    {
        #region Constructores
        /// <summary>
        /// Constructor que inicializa el atributo "esClon" como falso y el blaster el ingresado
        /// </summary>
        /// <param name="armamento">Enum del modelo de blaster</param>
        public TrooperArena(Blaster armamento) : base(armamento)
        {
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad abstracta de Tipo, retorna string con descripcion del Trooper
        /// </summary>
        public override string Tipo { get { return "Soldados de asalto de terrenos desérticos"; } }
        #endregion
    }
}

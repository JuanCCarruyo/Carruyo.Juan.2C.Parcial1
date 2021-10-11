using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTroopers
{
    public class EjercitoImperial
    {
        #region Campos
        private int capacidad;
        private List<Trooper> troopers;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor que instancia la lista de Troopers
        /// </summary>
        private EjercitoImperial()
        {
            this.troopers = new List<Trooper>();
        }
        /// <summary>
        /// Constructor que instancia la lista de Troopers, ademas de la capacidad del ejercito
        /// </summary>
        /// <param name="capacidad"></param>
        public EjercitoImperial(int capacidad) : this()
        {
            this.capacidad = capacidad;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Retorna la lista de soldados del Ejercito Imperial
        /// </summary>
        public List<Trooper> Troopers
        {
            get { return this.troopers; }
        }
        #endregion

        #region Sobrecarga
        /// <summary>
        /// Sobrecarga de operador + que agrega un Trooper al Ejercito Imperial, si hay lugar
        /// </summary>
        /// <param name="ejercito">Ejercito Imperial</param>
        /// <param name="soldado">Trooper del Ejercito Imperial</param>
        /// <returns>El ejercito modificado</returns>
        public static EjercitoImperial operator +(EjercitoImperial ejercito, Trooper soldado)
        {
            if(ejercito.capacidad > 0)
            {
                ejercito.Troopers.Add(soldado);
                ejercito.capacidad--;
            }
            
            return ejercito;
        }

        /// <summary>
        /// Sobrecarga de operador - que elimina el primer Trooper del mismo tipo del ejercito imperial
        /// </summary>
        /// <param name="ejercito">Ejercito Imperial</param>
        /// <param name="soldado">Trooper del Ejercito Imperial</param>
        /// <returns>El ejercito modificado</returns>
        public static EjercitoImperial operator -(EjercitoImperial ejercito, Trooper soldado)
        {
            foreach (Trooper t in ejercito.Troopers)
            {
                if (t.Equals(soldado))
                {
                    ejercito.Troopers.RemoveAt(ejercito.Troopers.IndexOf(t));
                    ejercito.capacidad++;
                    break;
                }
            }

            return ejercito;
        }
        #endregion
    }
}

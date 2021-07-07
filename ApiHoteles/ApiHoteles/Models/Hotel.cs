using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHoteles.Models
{
    public class Hotel
    {
        [Key]
        public int idHotel { get; set; }

        public string NameHotel { get; set; }

        public char Categoria { get; set; }

        public decimal Precio { get; set; }

        #region Imagenes

        public string General { get; set; }
                
        public string Habitacion { get; set; }

        public string Cama { get; set; }

        #endregion

        public string Calificacion { get; set; }
    }
}

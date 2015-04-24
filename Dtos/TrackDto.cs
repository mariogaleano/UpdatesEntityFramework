
using System;
using System.ComponentModel.DataAnnotations;

namespace Dtos
{
    /// <summary>
    /// Clase que representa un Dto de la clase Track
    /// </summary>
    public class TrackDto : BaseModel
    {
        private string _composer;
        public Int32 TrackId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El nombre es requerido"), MinLength(5, ErrorMessage = "El nombre debe tener más de 5 carácteres.")]
        public string Name { get; set; }

        //public Int32 MediaTypeId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El compositor es requerido")]
        [MinLength(2, ErrorMessage = "El compositor debe tener más de 2 carácteres.")]
        public String Composer
        {
            get { return _composer; }
            set
            {
                _composer = value;
                SetProperty(ref _composer, value);
            }
        }

        public Int32 Milliseconds { get; set; }
        public Decimal UnitPrice { get; set; }


    }
}
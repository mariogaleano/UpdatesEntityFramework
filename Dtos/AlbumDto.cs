
using System;

namespace Dtos
{
    /// <summary>
    /// Clase que representa un Dto de la clase Album
    /// </summary>
    public class AlbumDto
    {
        public Int32   AlbumId {get; set;}
        public String   Title {get; set;}
        public Int32   ArtistId {get; set;}
    }
}
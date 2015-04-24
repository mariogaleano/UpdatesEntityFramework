
using System;

namespace Dtos
{
    /// <summary>
    /// Clase que representa un Dto de la clase InvoiceLine
    /// </summary>
    public class InvoiceLineDto
    {
        public Int32   InvoiceLineId {get; set;}
        public Int32   InvoiceId {get; set;}
        public Int32   TrackId {get; set;}
        public Decimal   UnitPrice {get; set;}
        public Int32   Quantity {get; set;}
   
    }
}
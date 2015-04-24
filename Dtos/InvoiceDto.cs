
using System;

namespace Dtos
{
    /// <summary>
    /// Clase que representa un Dto de la clase Invoice
    /// </summary>
    public class InvoiceDto
    {
        public Int32   InvoiceId {get; set;}
        public Int32   CustomerId {get; set;}
        public DateTime   InvoiceDate {get; set;}
        public String   BillingAddress {get; set;}
        public String   BillingCity {get; set;}
        public String   BillingState {get; set;}
        public String   BillingCountry {get; set;}
        public String   BillingPostalCode {get; set;}
        public Decimal   Total {get; set;}
   
    }
}
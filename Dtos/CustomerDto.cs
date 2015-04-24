
using System;

namespace Dtos
{
    /// <summary>
    /// Clase que representa un Dto de la clase Customer
    /// </summary>
    public class CustomerDto
    {
        public Int32   CustomerId {get; set;}
        public String   FirstName {get; set;}
        public String   LastName {get; set;}
        public String   Company {get; set;}
        public String   Address {get; set;}
        public String   City {get; set;}
        public String   State {get; set;}
        public String   Country {get; set;}
        public String   PostalCode {get; set;}
        public String   Phone {get; set;}
        public String   Fax {get; set;}
        public String   Email {get; set;}
   
    }
}
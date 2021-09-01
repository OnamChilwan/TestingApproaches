using System;

namespace Book.Api.Models
{
    public class BookReservationRequest
    {
        public string ISBN { get; set; }
        
        public string MembershipNumber { get; set; }

        public DateTimeOffset ReturnDate { get; set; }
    }
}
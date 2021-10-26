using System;

namespace Domain
{
    public class Activity
    {
        // Guid - ID which can be generated from te server side or we can generate this from client side
        // Adventage of using Guid is that if we do create the ID on the client side, then we don't have to wait for our database server to generate the ID for us and send it back to us. We can do it all inside the client.
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Category { get; set;  }
        public string City { get; set; }
        public string Venue { get; set; }
    }
}
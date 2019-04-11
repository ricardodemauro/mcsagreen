using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebGreetingBook.Models
{
    public class Greeting
    {
        public int Id { get; set; }

        public string Message { get; set; }

        public string Sender { get; set; }
    }
}

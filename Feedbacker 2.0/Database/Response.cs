using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedbacker_2._0.Database
{
    internal class Response
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }

        public Assignment Assignment { get; set; }

        public Response()
        {

        }

        public Response(int Id, string Name, string Message, Assignment assignment)
        {
            this.Id = Id;
            this.Name = Name;
            this.Message = Message;
            Assignment = assignment;
        }
    }
}

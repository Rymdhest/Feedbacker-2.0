using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedbacker_2._0.Database
{
    internal class Assignment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Position { get; set; }
        public Course Course { get; set; }

        public BindingList<Response> Responses { get; set; }

        public Assignment()
        {
            Responses = new BindingList<Response>();
        }

        public Assignment(int Id, string Name, string Description, int position, Course course)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            Position = position;
            Course = course;
            Responses = new BindingList<Response>();
        }
    }
}

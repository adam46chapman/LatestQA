using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace QAProject.Data
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        public int ParentId { get; set; }

        [MinLength(1), MaxLengthAttribute(160)]
        public string Title { get; set; }

        [MinLength(1), MaxLengthAttribute(250)]
        public string Body { get; set; }

        public DateTime PostDate { get; set; }
    }
}

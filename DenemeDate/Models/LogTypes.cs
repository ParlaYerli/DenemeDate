using System;
using System.Collections.Generic;

namespace DenemeDate.Models
{
    public partial class LogTypes
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public string Name { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace DenemeDate.Models
{
    public partial class Logs
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int UserId { get; set; }
        public int LogTypeId { get; set; }
        public string Description { get; set; }
    }
}

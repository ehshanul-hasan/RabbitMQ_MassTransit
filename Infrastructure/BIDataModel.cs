using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class BIDataModel
    {
        public int ID { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.UtcNow;
        public string Type { get; set; }
        public string Message { get; set; }
        public bool IsCompleted { get; set; }
    }
}

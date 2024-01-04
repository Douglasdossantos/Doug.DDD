using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doug.Domain.Entities
{
    public abstract class BaseEntity<TPK>
    {
        public TPK Id { get; set; }
    }
}

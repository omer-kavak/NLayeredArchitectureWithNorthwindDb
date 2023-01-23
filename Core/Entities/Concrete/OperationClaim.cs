using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class OperationClaim : IEntity
    {
        public int ClaimID { get; set; }
        public string ClaimName { get; set; }
    }
}

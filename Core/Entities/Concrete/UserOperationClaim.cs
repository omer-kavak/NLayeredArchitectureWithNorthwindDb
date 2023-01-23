using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class UserOperationClaim : IEntity
    {
        public int UserClaimID { get; set; }
        public int UserID { get; set; }
        public int OperationClaimID { get; set; }
    }
}

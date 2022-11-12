using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task8
{
    public class Member
    {
        public string membershipId { get; private set; }
        public string Name { get; private set; }
        public DateTime MembershipExpirationDate { get; private set; }





        public Member()
        {
            membershipId = Guid.NewGuid().ToString();
        }
    }
}

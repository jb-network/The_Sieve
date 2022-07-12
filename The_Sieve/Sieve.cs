using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Sieve
{
    public class Sieve
    {
        private Func<int, bool> UserSelection;

        public Sieve(Func<int, bool> UserChoice)
        {
            UserSelection = UserChoice;
        }
        public bool IsGood(int UserProvidednumber)
        {
            return UserSelection(UserProvidednumber);
        }
    }
}
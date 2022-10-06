using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Model
{
    public abstract class Actor : IActor
    {
        #region Properties
        public string FirstName { get; set; }

        public string LastName { get; set; }
        #endregion

        #region Constructors
        public Actor(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return "First Name : " + FirstName
                + "\nLast Name : " + LastName;
        }

        public abstract void MessageReceived();
        #endregion
    }
}

/* I4SWD Hand In 1 by Group 7 (Frederik, John, Mark and Tonni) */

using System.Collections.Generic;
using Infrastructure;

namespace AppLogic
{
    public class AppCalls
    {
        public int ValidateInput(ref Dictionary<string,string> input)
        {
            var containsInput = new DBUtil().RequestInput(ref input);

            if (!containsInput)
            {
                // The DB did not contain the user or password for the user.
                // Take action according to this.

                return 0;
            }
            else
            {
                // The DB did contain the user and the password assigned to it.
                // Login is successful, so switch app window to Main Menu.

                return 1;
            }
        }
    }
}

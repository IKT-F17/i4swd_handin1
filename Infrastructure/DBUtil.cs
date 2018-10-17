using System.Collections.Generic;
using System.Linq;
using DomainModel;

namespace Infrastructure
{
    public class DBUtil
    {
        private Dictionary<string, string> tempDb = new Dictionary<string, string>();

        private readonly User _newUser;

        public DBUtil()
        {
            _newUser = new User()
            {
                UserId = 0,
                UserName = "",
                UserPw = "",
            };
        }

        public bool RequestInput(ref Dictionary<string, string> input)
        {
            tempDb.Add("Admin", "1234");

            // OBS. At this point it became clear to us that using a Dictionary to store user input wasn't very practical.
            var inputKey = input.Keys.ToArray();
            var inputValue = input.Values.ToArray();
            var key = inputKey[0];
            var value = inputValue[0];

            // Find out if Dictionary contains key and output it's value for the found key to a variable?
            tempDb.TryGetValue(key, out var dbValue);

            return value == dbValue;

            // Username was not in DB.
        }


        public void ReadUserFromDb(ref User user)
        {
            // call another function that uses an interface, so we can fake an sql database with a c# dictionary.
        }

        //private SqlConnection OpenConnection
        //{
        //    get
        //    {
        //        var connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ContactCatalogDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True");

        //        connection.Open();

        //        return connection;
        //    }
        //}

    }
}

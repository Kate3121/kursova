using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Курсова
{
    internal class UserManager
    {
        private const string FilePath = "nameuser.txt";

        public static List<User> LoadUsers()
        {
            var users = new List<User>();
            if (!File.Exists(FilePath)) return users;

            foreach (var line in File.ReadAllLines(FilePath))
            {
                var parts = line.Split(';');
                if (parts.Length == 3)
                    users.Add(new User(parts[0], parts[1], parts[2]));
            }
            return users;
        }

        public static void SaveUsers(List<User> users)
        {
            var lines = users.Select(u => $"{u.Name};{u.Password};{u.Access}");
            File.WriteAllLines(FilePath, lines);
        }
    }
}

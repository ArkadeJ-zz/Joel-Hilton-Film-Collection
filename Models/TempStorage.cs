using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Joel_Hilton_Film_Collection.Models
{
    public class TempStorage
    {
        private static List<Movies> Database = new List<Movies>();

        public static IEnumerable<Movies> Films => Database;

        public static void AddMovie(Movies production)
        {
            Database.Add(production);
        }
    }
}

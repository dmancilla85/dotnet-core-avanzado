
using System;
using System.Collections.Generic;

namespace DependencyInjection
{
    public class Database : IDatabase
    {
        public long Ticks { get; set; }

        public Database()
        {
            Ticks = DateTime.Now.Ticks;
        }

        public void Create()
        {
            // conectar a db
        }

        public IEnumerable<string> GetProducts()
        {
            return new[] { "Naranja", "Yogurth", "Queso" };
        }
    }
}

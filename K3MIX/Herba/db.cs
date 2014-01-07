using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Herba
{
    class db
    {
        private static db instanca;
        private string stringKonekcija;
        private NpgsqlConnection konekcija;

        private db()
        {
            stringKonekcija = "Server=localhost;Port=5432;Database=Herbalife_db;User Id=postgres;password=mposedi;";
            try
            {
                konekcija = new NpgsqlConnection(stringKonekcija);
                konekcija.Open();
            }
            catch (Exception er)
            {
                //neuspjesno
            }

        }

        public static db Instanca
        {
            get
            {
                if (instanca == null)
                {
                    instanca = new db();
                }
                return instanca;
            }

        }

        public string Stringkonekcija
        {
            get { return stringKonekcija; }
            private set { stringKonekcija = value; }
        }
        public NpgsqlConnection Konekcija
        {
            get { return konekcija; }
            private set { konekcija = value; }
        }

        public NpgsqlDataReader DohvatiDataReader(string sqlUpit)
        {
            NpgsqlCommand command = new NpgsqlCommand(sqlUpit, Konekcija);

            return command.ExecuteReader();
        }

        

        public int IzvrsiUpit(string sqlUpit)
        {
            NpgsqlCommand command = new NpgsqlCommand(sqlUpit, Konekcija);
            return command.ExecuteNonQuery();
        }

    }
}

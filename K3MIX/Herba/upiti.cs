using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Herba
{//RADI
    class upiti
    {
        public static string id = "1";
        public static string role = "S";

        public static void AzurirajOsobnePodatke(string ime, string prezime, string email, string telefon, string username, string password)
        {

            string sql = string.Format(@"UPDATE ""Korisnik"" SET ""Ime""='{0}',""Prezime""='{1}',""Email""='{2}',""Broj_telefona""='{3}',""Username""='{4}',""Password""='{5}'",
                ime, prezime, email, telefon, username, password, id);
            db.Instanca.IzvrsiUpit(sql);
            return;

        }
         
        public static NpgsqlDataReader DohvatiOsobnePodatke()
        {

            string sql = @"SELECT*FROM ""Korisnik"" WHERE ""ID_korisnik""='" +id+"';";
            return db.Instanca.DohvatiDataReader(sql);


        }

        public static void BrisiMjeru(string id)
        {
            string sql = string.Format(@"DELETE FROM ""Korisnik_mjere"" WHERE ""ID_korisnik""='{0}';", id);//11:23 pogledat dal se zabunio u vezi where-a?
            db.Instanca.IzvrsiUpit(sql);
            return;
        }

        public static NpgsqlDataReader DohvatiSveMjereKorisnika(string id)
        {

            string sql = string.Format(@"SELECT*FROM ""Korisnik_mjere"" WHERE ""ID_korisnik""='{0}';", id);
            return db.Instanca.DohvatiDataReader(sql);
        }
        public static void DodajMjere(string id, string tezina, string masti, string dob, string struk)
        {

            string sql = string.Format(@"INSERT INTO ""Korisnik_mjere"" (""ID_korisnik"",""Tezina"",""Udio_masti"",""Metabolicka_dob"",""Struk"",""Datum"") VALUES"
                + @"('{0}','{1}','{2}','{3}','{4}','{5}');", id,tezina,masti,dob,struk,DateTime.Now.ToShortDateString());
            db.Instanca.IzvrsiUpit(sql);
        }



        public static void AzurirajMjere(string id, string tezina,string masti,string dob,string struk) 
        {

            string sql =string.Format(@"UPDATE ""Korisnik_mjere"" SET ""Tezina""='{0}',""Udio_masti""='{1}',"
            + @"""Metabolicka_dob""='{2}',""Struk""='{3}',""Datum""='{4}' WHERE ""ID_mjere""='{5}';",
            tezina, masti, dob, struk,DateTime.Now.ToShortDateString(),id);
            db.Instanca.IzvrsiUpit(sql);
        }

        public static NpgsqlDataReader DohvatiMjereKorisnika(string id)
        {

            string sql = string.Format(@"SELECT*FROM ""Korisnik_mjere"" WHERE ""ID_korisnik""='{0}' AND ""Datum"">='{1}';", 
                id, "01." + DateTime.Now.Month + "." + DateTime.Now.Year);
            return db.Instanca.DohvatiDataReader(sql);
        }
        public static bool ProvjeriLogin(string username, string password)
        {
            string sql = string.Format(@"SELECT*FROM ""Korisnik"" WHERE ""Username""='{0}' AND ""Password""='{1}'", username, password);
            NpgsqlDataReader dr = db.Instanca.DohvatiDataReader(sql);
            if (dr.HasRows)
            {
                dr.Close();
                dr.Dispose();
                return true;
            }
            dr.Close();
            dr.Dispose();
            return false;
        }

        public static void DodajKorisnika(string ime, string prezime, string email, string telefon, string username, string password)
        {
            string sql = string.Format (@"INSERT INTO ""Korisnik"" (""Ime"",""Prezime"",""Email"",""Broj_telefona"",""role"",""Username"",""Password"") VALUES"+
                    "('{0}','{1}','{2}','{3}','K','{4}','{5}');",ime,prezime,email,telefon,username,password);
            db.Instanca.IzvrsiUpit(sql);
            return;
        }

        public static NpgsqlDataReader DohvatiSveKorisnike()
        {
            string sql = string.Format(@"SELECT*FROM ""Korisnik"" WHERE ""ID_korisnik""<>'{0}';", id);
            return db.Instanca.DohvatiDataReader(sql);
        }
    }
}

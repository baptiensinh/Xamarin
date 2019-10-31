using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BT3
{
    public class database
    {
        string folder = System.Environment.GetFolderPath
            (System.Environment.SpecialFolder.Personal);
        public bool CreateDatabase()
        {
            try
            {
                using (var connection = new SQLiteConnection
                    (System.IO.Path.Combine(folder, "hoa.db")))
                {
                    connection.CreateTable<LoaiHoa>();
                    connection.CreateTable<Hoa>();
                    return true;
                }
            }
            catch (SQLiteException )
            {
                return false;
            }
        }
        public bool Insertloai(LoaiHoa loai)
        {
            try
            {
                using (var connection = new
                    SQLiteConnection(System.IO.Path.Combine(folder, "hoa.db")))
                {
                    connection.Insert(loai);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {            
                return false;
            }
        }
        public List<LoaiHoa> SelectLoaiHoa()
        {
            try
            {
                using (var connection = new SQLiteConnection
                    (System.IO.Path.Combine(folder, "hoa.db")))
                {
                    return connection.Table<LoaiHoa>().ToList();
                }
            }
            catch (SQLiteException)
            {
                return null;
            }
        }
        public bool InsertHoa(Hoa hoa)
        {
            try
            {
                using(var connection=new SQLiteConnection
                    (System.IO.Path.Combine(folder, "hoa.db")))
                {
                    connection.Insert(hoa);
                    return true;
                }
            }
            catch (SQLiteException)
            {
                return false;
            }
        }
        public List<Hoa> SelectHoa()
        {
            try
            {
                using(var connection=new SQLiteConnection
                    (System.IO.Path.Combine(folder, "hoa.db")))
                {
                    return connection.Table<Hoa>().ToList();
                }
            }
            catch (SQLiteException)
            {
                return null;
            }
        }
    }
}

using SQLite;
namespace BT3
{
    public class Hoa
    {
        [PrimaryKey,AutoIncrement]
        public int Mahoa { get; set; }
        public string Tenhoa { get; set; }
        public int Maloai { get; set; }
        public int Gia { get; set; }
        public string Image { get; set; }
        public string Ghichu { get; set; }
    }
}
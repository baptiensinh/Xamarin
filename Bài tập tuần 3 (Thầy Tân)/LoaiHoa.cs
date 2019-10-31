using SQLite;
namespace BT3
{
    public class LoaiHoa
    {
        [PrimaryKey, AutoIncrement]
        public int Maloai { get; set; }
        public string Tenloai { get; set; }
        public string Image { get; set; }
    }
}
namespace HotelApi.Data
{
    public class Country
    {
        public Country()
        {
            Hotels = new HashSet<Hotel>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }

        public virtual ICollection<Hotel> Hotels { get; set; }
    }
}

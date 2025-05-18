namespace MagicVilla_API.DataEntity
{
    public class Villa
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public string Details { get; set; } 
        public double Rate { get; set; }
        public int SQFT { get; set; }
        public int Occupancy { get; set; }
        public string ImageUrl  { get; set; }
        public string Amenity  { get; set; }
        public DateTime CreateAt  { get; set; }
        public DateTime UpdatedAt  { get; set; }
    }
}

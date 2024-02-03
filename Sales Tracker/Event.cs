namespace Sales_Tracker
{
    public abstract class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime EventDate { get; set; }
        public double FlatCost { get; set; }
        public List<TicketBatch> Batches { get; set; }
        public abstract List<Seller> GetSellers();

        // TODO city
    }

    public class SingleCityEvent : Event
    {
        public City City { get; set; }
        public override List<Seller> GetSellers()
        {
            return City.Sellers;
        }
    }

    public class MultiCityEvent : Event
    {
        public List<City> Cities { get; set;}
        public override List<Seller> GetSellers()
        {
            List<Seller> l = new List<Seller>();
            foreach (City c in Cities)
            {
                l.AddRange(c.Sellers);
            }
            return l;
        }
    }
}

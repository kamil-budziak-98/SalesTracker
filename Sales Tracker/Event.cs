namespace Sales_Tracker
{
    public class Event
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime EventDate { get; set; }
        public double FlatCost { get; set; }
        public List<TicketBatch> Batches { get; set; }

        // TODO city
    }
}

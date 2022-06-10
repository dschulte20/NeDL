namespace GuitarApi.Models
{
    public class GuitarItem
    {
        public long Id { get; set; }
        public string Brand { get; set; }
        public bool Collected { get; set; }
        public string Color { get; set; } // The secret field needs to be hidden from this app,
                                            // but an administrative app could choose to expose it.
    }
}

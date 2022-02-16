namespace FirstAPI.Models
{
    public class Customer :IComparable<Customer>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(Customer? other)
        {
            return this.Id.CompareTo(other.Id);
        }
    }
}

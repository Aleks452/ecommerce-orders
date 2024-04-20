namespace Orders.dtos
{
    public class ShoppingCheckoutDTO
    {
        public string UserName { get; set; }
        public int UserId { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string CountryCode { get; set; }
        public string DepartmentCode { get; set; }
        public string CityCode { get; set; }
        public string Address { get; set; }
        public decimal SubtotalPrice { get; set; }
        public decimal TotalTaxes { get; set; }
        public decimal TotalPrice { get; set; }
        public int PaymentId { get; set; }
    }
}

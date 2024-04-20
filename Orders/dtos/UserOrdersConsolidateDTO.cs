namespace Orders.dtos
{
    public class UserOrdersConsolidateDTO
    {
        public int OrderId {  get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public string CityCode { get; set; }
        public string CityName { get; set;}
        public string Address { get; set; }
        public decimal SubtotalPrice { get; set; }
        public decimal TotalTaxes { get; set; }
        public decimal TotalPrice { get; set; }
        public int PaymentId {  get; set; }
        public string PaymentType { get; set; }
        public int TrackingId {  get; set; }
        public string TrackingType { get; set;}


    }
}

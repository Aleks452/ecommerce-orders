using Microsoft.AspNetCore.Mvc;
using Mysqlx.Crud;
using Orders.dtos;
using Orders.Entities;
using Orders.Exceptions;
using System.Data;
using System.Data.Entity;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;

namespace Orders.Services
{
    public class OrderService : IOrderService
    {
        private readonly ApplicationDbContext _context;

        public OrderService(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }

        public async Task<IEnumerable<UserOrdersConsolidateDTO>> GetOrdersAsync(int userId)
        {   
            try { 
            // Put personalizated query to get client information
            var result =  (from _Order in _context.Orders
                                join _Location in _context.Locations on new { _Order.CountryCode, _Order.DepartmentCode, _Order.CityCode }
                                equals new { _Location.CountryCode, _Location.DepartmentCode, _Location.CityCode }
                                join _Payment in _context.Payments on _Order.PaymentId equals _Payment.PaymentId
                                join _Tracking in _context.Trackings on _Order.TrackingId equals _Tracking.TrackingId
                                where _Order.UserId == userId
                                select new UserOrdersConsolidateDTO {
                                    OrderId = _Order.OrderId,
                                    UserId = _Order.UserId,
                                    UserName = _Order.UserName,
                                    Email = _Order.Email,
                                    ContactNumber = _Order.ContactNumber,
                                    CountryCode = _Order.CountryCode,
                                    CountryName = _Location.CountryName,
                                    DepartmentCode = _Order.DepartmentCode,
                                    DepartmentName = _Location.DepartmentName,
                                    CityCode = _Order.CityCode,
                                    CityName = _Location.CityName,
                                    Address = _Order.Address,
                                    SubtotalPrice = _Order.SubtotalPrice,
                                    TotalTaxes = _Order.TotalTaxes,
                                    TotalPrice = _Order.TotalPrice,
                                    PaymentId = _Order.PaymentId,
                                    PaymentType = _Payment.PaymentType,
                                    TrackingId = _Order.TrackingId,
                                    TrackingType = _Tracking.TrackingType
                                }).ToList();

            if (result.Count == 0)
            {
                throw new NoDataFoundException();
            }

            return (result);
            }

            catch (DataException ex)
            {
                throw new InternalErrorException(ex.Message);
    }
}

        public async Task<bool> AddOrderAsync(ShoppingCheckoutDTO shoppingCheckoutDTO)
        {
            try
            {   
                // setting values to add to order table
                var order = new OrderEntity
                {
                    UserId = shoppingCheckoutDTO.UserId,
                    UserName = shoppingCheckoutDTO.UserName,
                    Email = shoppingCheckoutDTO.Email,
                    ContactNumber = shoppingCheckoutDTO.ContactNumber,
                    CountryCode = shoppingCheckoutDTO.CountryCode,
                    DepartmentCode = shoppingCheckoutDTO.DepartmentCode,
                    CityCode = shoppingCheckoutDTO.CityCode,
                    Address = shoppingCheckoutDTO.Address,
                    SubtotalPrice = shoppingCheckoutDTO.SubtotalPrice,
                    TotalTaxes = shoppingCheckoutDTO.TotalTaxes,
                    TotalPrice = shoppingCheckoutDTO.TotalPrice,
                    PaymentId = shoppingCheckoutDTO.PaymentId,
                    TrackingId = 1
                    
                };

                // add info in a table
                _context.Orders.Add(order);
                await _context.SaveChangesAsync();
                return true;
            } catch (Exception ex)
            {
                throw new InternalErrorException(ex.Message);
            }

        }
    }
}

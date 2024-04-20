using Microsoft.EntityFrameworkCore;
using Orders.dtos;
using Orders.Entities;
using Orders.Exceptions;
using System.Data;

namespace Orders.Services
{
    public class ShoppingCarService : IShoppingCarService
    {
        private readonly ApplicationDbContext _context;

        public ShoppingCarService(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }

        public async Task<IEnumerable<ShoppingCarTotalDTO>> GetCustomDataAsync(int userId, int statusId)
        {
            try
            {
                // Put personalizated query to get client information
                var result = await (from _User in _context.Users
                                    join _Shopping in _context.Shopping_car on _User.UserId equals _Shopping.UserId
                                    join _Locations in _context.Locations on new { _User.CountryCode, _User.DepartmentCode, _User.CityCode }
                                    equals new { _Locations.CountryCode, _Locations.DepartmentCode, _Locations.CityCode }
                                    where _User.UserId == userId && _Shopping.StatusId == statusId
                                    group new { _User, _Shopping, _Locations } by _User.UserId into grouped
                                    select new ShoppingCarTotalDTO
                                    {
                                        UserId = grouped.Key,
                                        UserName = grouped.Select(x => x._User.UserName).FirstOrDefault(),
                                        Email = grouped.Select(x => x._User.Email).FirstOrDefault(),
                                        ContactNumber = grouped.Select(x => x._User.ContactNumber).FirstOrDefault(),
                                        CountryCode = grouped.Select(x => x._User.CountryCode).FirstOrDefault(),
                                        CountryName = grouped.Select(x => x._Locations.CountryName).FirstOrDefault(),
                                        DepartmentCode = grouped.Select(x => x._User.DepartmentCode).FirstOrDefault(),
                                        DepartmentName = grouped.Select(x => x._Locations.DepartmentName).FirstOrDefault(),
                                        CityCode = grouped.Select(x => x._User.CityCode).FirstOrDefault(),
                                        CityName = grouped.Select(x => x._Locations.CityName).FirstOrDefault(),
                                        Address = grouped.Select(x => x._User.Address).FirstOrDefault(),
                                        SubtotalPrice = grouped.Sum(x => x._Shopping.ProductPrice - x._Shopping.ProductTaxes),
                                        TotalTaxes = grouped.Sum(x => x._Shopping.ProductTaxes),
                                        TotalPrice = grouped.Sum(x => x._Shopping.ProductPrice)
                                    }).ToListAsync();

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

    }
}
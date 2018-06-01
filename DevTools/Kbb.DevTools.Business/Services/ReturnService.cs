using AutoMapper;
using AutoMapper.QueryableExtensions;
using Kbb.DevTools.DAL;
using Kbb.DevTools.Domain.Contracts;
using Kbb.DevTools.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kbb.DevTools.Business.Services
{
    public class ReturnService : IReturnService
    {
        private readonly IMapper _mapper;

        public ReturnService(IMapper mapper)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            
            // TODO: should i be injecting the DB context here? Feels like 
            //  i should be using UOW and Repos so everything injects cleanly.....
            // consult Google & SO :-) 
        }

        public IEnumerable<Return> GetAll()
        {
            var returns = new List<Return>();
            using (var db = new DevToolsContext())
            {
                returns = db.Returns
                        .AsNoTracking()
                        .Include(r => r.BillingAddress)
                        .Include(r => r.ShippingAddress)
                        .Include(r => r.Customer)
                        .ProjectTo<Return>() // REMINDER: Automapper ease of use ;-)
                        .ToList();



                // TODO: delete this after i am more confident in the DAL and likely moved to UoW.
                // TODO: test FKs... TESTED: no lazy loading is occur. 
                // Tested explicitly with vars; VS debugger is misleading and seems to fire queries in the background to show a full UI
                // NOTE: both addresses are loaded in off of a single .Include(BillingAddress);.. might want to look into generated queries
                //try
                //{
                //    var tester = db.Returns
                //            //.Include(r => r.BillingAddress)
                //            .Include(r => r.Customer)
                //            .ToList();
                //    var cust = tester.First().Customer;
                //    var another = db.Returns
                //            //.Include(r => r.BillingAddress)
                //            //.Include(r => r.Customer)
                //            .ToList();
                //    var biller = another.First().BillingAddress;
                //    var shippr = another.First().ShippingAddress;
                //    var third = db.Returns
                //            .Include(r => r.BillingAddress)
                //            .Include(r => r.Customer)
                //            .ToList();
                //    var billingRight = third.First().BillingAddress;
                //    var shouldStillBeNullShipping = third.First().ShippingAddress;
                //}
                //catch(Exception testing)
                //{
                //    var todo = testing;
                //}
            }
            return returns;
        }
    }
}

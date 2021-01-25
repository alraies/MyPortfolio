using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.Entities;
using Web.ViewModels;

namespace Web.Contollers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork<Owner> _owner;
        private readonly IUnitOfWork<PortfoiloItem> _portfolioitems;

        public HomeController(IUnitOfWork<Owner> owner,
            IUnitOfWork<PortfoiloItem> portfolioitems)
        {
           _owner = owner;
          _portfolioitems = portfolioitems;
        }
        public IActionResult Index()
        {
            var homeviewmodel = new HomeVewModel
            {
                Owner = _owner.Entity.GetAll().First(),
                PortfolioItems = _portfolioitems.Entity.GetAll().ToList()
            };
          return View(homeviewmodel);
        }
    }
}

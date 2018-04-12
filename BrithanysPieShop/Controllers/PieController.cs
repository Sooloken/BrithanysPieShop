using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BrithanysPieShop.Models;
using BrithanysPieShop.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BrithanysPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICatagoryRepository _catagoryRepository;

        public PieController (IPieRepository pieRepository, ICatagoryRepository catagoryRepository)
        {
            _pieRepository = pieRepository;
            _catagoryRepository = catagoryRepository;
        }

        public ViewResult List()
        {
            PieListViewModel pieListViewModel = new PieListViewModel();
            pieListViewModel.Pies = _pieRepository.Pies;

            return View(pieListViewModel);
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
              
            return View();
        }
    }
}

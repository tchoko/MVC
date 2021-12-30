using AutoMapper;
using GestStore.Models;
using GestStore.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using AspNetCoreHero.ToastNotification.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestStore.Controllers
{
    public class ClientController : Controller
    {
        private readonly ILogger<ClientController> _logger;
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly INotyfService _notifyService;
        public ClientController(ILogger<ClientController> logger, ApplicationDbContext dbContext, IMapper mapper,
            INotyfService notifyService)
        {
            _logger = logger;
            _dbContext = dbContext;
            _mapper = mapper;
            _notifyService = notifyService;
        }
       
        public IActionResult Index()
        {
            var clients = _dbContext.Clients.ToList();
            var viewModels = new List<ClientViewModel>();
            foreach (var client in _dbContext.Clients)
               viewModels.Add(_mapper.Map<ClientViewModel> (client));

                return View(viewModels);
        }
        public IActionResult Create()
        {
            return RedirectToAction("Edit");
        }
        public IActionResult Edit()
        {
            return View();
        }
        

        [HttpPost]
        public ActionResult SaveClient(ClientViewModel item)
        {
            _logger.LogTrace($"Received model with ID {item.ClientID}");
            var client = new ClientViewModel()
            {
                ClientID = item.ClientID,
                Nom = item.Nom,
                Prenom = item.Prenom,
                Cp = item.Cp,
                Localite = item.Localite,
                Rue = item.Rue,
                Numero = item.Numero,
                Tel = item.Tel
            };
            _dbContext.Add(client);
            _dbContext.SaveChanges();

            
            return RedirectToAction("Index");
        }
    }
}

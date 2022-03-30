using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AutoMapper;
using EstacionamentoH.MVC.ViewModels;
using EstacionamentoH.Domain.Entities;
using EstacionamentoH.Application.Interfaces;

namespace EstacionamentoH.MVC.Controllers
{
    public class EstacionamentosController : Controller
    {
        private readonly IEstacionamentoAppService _estacionamentoAppService;

        public EstacionamentosController(IEstacionamentoAppService estacionamentoAppService)
        {
            _estacionamentoAppService = estacionamentoAppService;
        }

        public ActionResult Index()
        {
            var estacionamentoViewModel = Mapper.Map<IEnumerable<Estacionamento>, IEnumerable<EstacionamentoViewModel>>(_estacionamentoAppService.GetAll());
            return View(estacionamentoViewModel);
        }

        public ActionResult Details(int id)
        {
            var estacionamento = _estacionamentoAppService.GetById(id);
            var estacionamentoViewModel = Mapper.Map<Estacionamento, EstacionamentoViewModel>(estacionamento);
            return View(estacionamentoViewModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EstacionamentoViewModel estacionamento)
        {
            if (ModelState.IsValid)
            {
                var estacionamentoDomain = Mapper.Map<EstacionamentoViewModel, Estacionamento>(estacionamento);
                _estacionamentoAppService.Add(estacionamentoDomain);
                return Redirect("Estacionamentos/Index");
            }
            return View(estacionamento);
        }

        public ActionResult Edit(int id)
        {
            var estacionamento = _estacionamentoAppService.GetById(id);
            var estacionamentoViewModel = Mapper.Map<Estacionamento, EstacionamentoViewModel>(estacionamento);
            return View(estacionamentoViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EstacionamentoViewModel estacionamento)
        {
            if (ModelState.IsValid)
            {
                var estacionamentoDomain = Mapper.Map<EstacionamentoViewModel, Estacionamento>(estacionamento);
                _estacionamentoAppService.Update(estacionamentoDomain);
                return Redirect("Estacionamentos/Index");
            }
            return View(estacionamento);
        }

        public ActionResult Delete(int id)
        {
            var estacionamento = _estacionamentoAppService.GetById(id);
            var estacionamentoViewModel = Mapper.Map<Estacionamento, EstacionamentoViewModel>(estacionamento);
            return View(estacionamentoViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var estacionamento = _estacionamentoAppService.GetById(id);
            _estacionamentoAppService.Remove(estacionamento);
            return Redirect("Estacionamentos/Index");
        }
    }
}

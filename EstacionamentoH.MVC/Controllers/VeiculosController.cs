using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AutoMapper;
using EstacionamentoH.MVC.ViewModels;
using EstacionamentoH.Domain.Entities;
using EstacionamentoH.Application.Interfaces;

namespace EstacionamentoH.MVC.Controllers
{
    public class VeiculosController : Controller
    {
        private readonly IVeiculoAppService _veiculoAppService;

        public VeiculosController(IVeiculoAppService veiculoAppService)
        {
            _veiculoAppService = veiculoAppService;
        }

        public ActionResult Index()
        {
            var veiculoViewModel = Mapper.Map<IEnumerable<Veiculo>, IEnumerable<VeiculoViewModel>>(_veiculoAppService.GetAll());
            return View(veiculoViewModel);
        }

        public ActionResult Details(int id)
        {
            var veiculo = _veiculoAppService.GetById(id);
            var veiculoViewModel = Mapper.Map<Veiculo, VeiculoViewModel>(veiculo);
            return View(veiculoViewModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VeiculoViewModel veiculo)
        {
            if (ModelState.IsValid)
            {
                var veiculoDomain = Mapper.Map<VeiculoViewModel, Veiculo>(veiculo);
                _veiculoAppService.Add(veiculoDomain);
                return Redirect("Veiculos/Index");
            }
            return View(veiculo);
        }

        public ActionResult Edit(int id)
        {
            var veiculo = _veiculoAppService.GetById(id);
            var veiculoViewModel = Mapper.Map<Veiculo, VeiculoViewModel>(veiculo);
            return View(veiculoViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(VeiculoViewModel veiculo)
        {
            if (ModelState.IsValid)
            {
                var veiculoDomain = Mapper.Map<VeiculoViewModel, Veiculo>(veiculo);
                _veiculoAppService.Update(veiculoDomain);
                return Redirect("Veiculos/Index");
            }
            return View(veiculo);
        }

        public ActionResult Delete(int id)
        {
            var veiculo = _veiculoAppService.GetById(id);
            var veiculoViewModel = Mapper.Map<Veiculo, VeiculoViewModel>(veiculo);
            return View(veiculoViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var veiculo = _veiculoAppService.GetById(id);
            _veiculoAppService.Remove(veiculo);
            return Redirect("Veiculos/Index");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AutoMapper;
using EstacionamentoH.MVC.ViewModels;
using EstacionamentoH.Domain.Entities;
using EstacionamentoH.Application.Interfaces;

namespace precoH.MVC.Controllers
{
    public class PrecosController : Controller
    {
        private readonly IPrecoAppService _precoAppService;

        public PrecosController(IPrecoAppService precoAppService)
        {
            _precoAppService = precoAppService;
        }

        public ActionResult Index()
        {
            var precoViewModel = Mapper.Map<IEnumerable<Preco>, IEnumerable<PrecoViewModel>>(_precoAppService.GetAll());
            return View(precoViewModel);
        }

        public ActionResult Details(int id)
        {
            var preco = _precoAppService.GetById(id);
            var precoViewModel = Mapper.Map<Preco, PrecoViewModel>(preco);
            return View(precoViewModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PrecoViewModel preco)
        {
            if (ModelState.IsValid)
            {
                var precoDomain = Mapper.Map<PrecoViewModel, Preco>(preco);
                _precoAppService.Add(precoDomain);
                return Redirect("Precos/Index");
            }
            return View(preco);
        }

        public ActionResult Edit(int id)
        {
            var preco = _precoAppService.GetById(id);
            var precoViewModel = Mapper.Map<Preco, PrecoViewModel>(preco);
            return View(precoViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PrecoViewModel preco)
        {
            if (ModelState.IsValid)
            {
                var precoDomain = Mapper.Map<PrecoViewModel, Preco>(preco);
                _precoAppService.Update(precoDomain);
                return Redirect("Precos/Index");
            }
            return View(preco);
        }

        public ActionResult Delete(int id)
        {
            var preco = _precoAppService.GetById(id);
            var precoViewModel = Mapper.Map<Preco, PrecoViewModel>(preco);
            return View(precoViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var preco = _precoAppService.GetById(id);
            _precoAppService.Remove(preco);
            return Redirect("Precos/Index");
        }
    }
}

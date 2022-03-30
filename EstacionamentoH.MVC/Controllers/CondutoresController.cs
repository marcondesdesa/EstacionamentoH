using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AutoMapper;
using EstacionamentoH.MVC.ViewModels;
using EstacionamentoH.Domain.Entities;
using EstacionamentoH.Application.Interfaces;

namespace EstacionamentoH.MVC.Controllers
{
    public class CondutoresController : Controller
    {
        private readonly ICondutorAppService _condutorAppService;

        public CondutoresController(ICondutorAppService condutorAppService)
        {
            _condutorAppService = condutorAppService;
        }

        public ActionResult Index()
        {
            var condutorViewModel = Mapper.Map<IEnumerable<Condutor>, IEnumerable<CondutorViewModel>>(_condutorAppService.GetAll());
            return View(condutorViewModel);
        }

        public ActionResult Details(int id)
        {
            var condutor = _condutorAppService.GetById(id);
            var condutorViewModel = Mapper.Map<Condutor, CondutorViewModel>(condutor);
            return View(condutorViewModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CondutorViewModel condutor)
        {
            if (ModelState.IsValid)
            {
                var condutorDomain = Mapper.Map<CondutorViewModel, Condutor>(condutor);
                _condutorAppService.Add(condutorDomain);
                return Redirect("Condutores/Index");
            }  
            return View(condutor);
        }

        public ActionResult Edit(int id)
        {
            var condutor = _condutorAppService.GetById(id);
            var condutorViewModel = Mapper.Map<Condutor, CondutorViewModel>(condutor);
            return View(condutorViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CondutorViewModel condutor)
        {
            if (ModelState.IsValid)
            {
                var condutorDomain = Mapper.Map<CondutorViewModel, Condutor>(condutor);
                _condutorAppService.Update(condutorDomain);
                return Redirect("Condutores/Index");
            }
            return View(condutor);
        }

        public ActionResult Delete(int id)
        {
            var condutor = _condutorAppService.GetById(id);
            var condutorViewModel = Mapper.Map<Condutor, CondutorViewModel>(condutor);
            return View(condutorViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var condutor = _condutorAppService.GetById(id);
            _condutorAppService.Remove(condutor);
            return Redirect("Condutores/Index");
        }
    }
}

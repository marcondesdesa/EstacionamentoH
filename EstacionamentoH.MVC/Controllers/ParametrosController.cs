using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AutoMapper;
using EstacionamentoH.MVC.ViewModels;
using EstacionamentoH.Domain.Entities;
using EstacionamentoH.Application.Interfaces;


namespace EstacionamentoH.MVC.Controllers
{
    public class ParametrosController : Controller
    {
        private readonly IParametroAppService _parametroAppService;

        public ParametrosController(IParametroAppService parametroAppService)
        {
            _parametroAppService = parametroAppService;
        }
        public ActionResult Index()
        {
            var parametroViewModel = Mapper.Map<IEnumerable<Parametro>, IEnumerable<ParametroViewModel>>(_parametroAppService.GetAll());
            return View(parametroViewModel);
        }

        public ActionResult Details(int id)
        {
            var parametro = _parametroAppService.GetById(id);
            var parametroViewModel = Mapper.Map<Parametro, ParametroViewModel>(parametro);
            return View(parametroViewModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ParametroViewModel parametro)
        {
            if (ModelState.IsValid)
            {
                var parametroDomain = Mapper.Map<ParametroViewModel, Parametro>(parametro);
                _parametroAppService.Add(parametroDomain);
                return Redirect("Parametros/Index");
            }
            return View(parametro);
        }

        public ActionResult Edit(int id)
        {
            var parametro = _parametroAppService.GetById(id);
            var parametroViewModel = Mapper.Map<Parametro, ParametroViewModel>(parametro);
            return View(parametroViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ParametroViewModel parametro)
        {
            if (ModelState.IsValid)
            {
                var parametroDomain = Mapper.Map<ParametroViewModel, Parametro>(parametro);
                _parametroAppService.Update(parametroDomain);
                return Redirect("Parametros/Index");
            }
            return View(parametro);
        }

        public ActionResult Delete(int id)
        {
            var parametro = _parametroAppService.GetById(id);
            var parametroViewModel = Mapper.Map<Parametro, ParametroViewModel>(parametro);
            return View(parametroViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var parametro = _parametroAppService.GetById(id);
            _parametroAppService.Remove(parametro);
            return Redirect("Parametros/Index");
        }
    }
}

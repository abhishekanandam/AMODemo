using AutoMapper;
using Microsoft.AspNet.Identity.Owin;
using MVCReview.Models;
using MVCReview.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCReview.Controllers
{
    public class JqueryDataTablesController : Controller
    {
        DBModel DbContext = new DBModel();
        // GET: JqueryDataTables
        public ActionResult Index()
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Models.Context.Asset, Models.Asset>();

            });
            IMapper mapper = mapperConfig.CreateMapper();
            List<Models.Asset> assetLst = new List<Models.Asset>();
            var assetDBList = DbContext.Assets.ToList();

            if(assetDBList.Any())
            {
                foreach (var asset in assetDBList)
                {
                    var mappedAsset = mapper.Map<Models.Context.Asset, Models.Asset>(asset);
                    assetLst.Add(mappedAsset);
                }
            }

            return View(assetLst);
        }
    }
}
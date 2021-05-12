using Caminhao.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caminhao.Interface
{
    public interface ICaminhao
    {     
        public IActionResult Index();
        public ActionResult Create();//get
        public ActionResult Create(Models.Caminhao tB_Caminhao);//post
        public ActionResult Details(Guid? id);//get
        public ActionResult Edit(Guid? id);//get
        public ActionResult Edit(Models.Caminhao tB_Caminhao);//post
        public ActionResult Delete(Guid? id);//get
        public ActionResult DeleteConfirmed(Guid id);//post

    }
}

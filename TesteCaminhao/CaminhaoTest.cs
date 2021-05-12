using System;
using System.Collections.Generic;
using System.Text;
using Caminhao.Interface;
using Caminhao.Models;
using Microsoft.AspNetCore.Mvc;

namespace TesteCaminhao
{
    public class CaminhaoTest : ICaminhao
    {
        private readonly List<Caminhao.Models.Caminhao> _caminhao;
        public CaminhaoTest()
        {
            _caminhao = new List<Caminhao.Models.Caminhao>()
            {
                new Caminhao.Models.Caminhao()
                {
                    Nome = "Teste automático 1",
                    Modelo = "FH",
                    AnoFabricacao = 2021,
                    AnoModelo = 2021,                    
                },
                new Caminhao.Models.Caminhao()
                {
                    Nome = "Teste automático 2",
                    Modelo = "FM",
                    AnoFabricacao = 2021,
                    AnoModelo = 2022,
                },
                new Caminhao.Models.Caminhao()
                {
                    Nome = "Teste automático 3",
                    Modelo = "EE",
                    AnoFabricacao = 2021,
                    AnoModelo = 2021,
                },
                new Caminhao.Models.Caminhao()
                {
                    Nome = "Teste automático 4",
                    Modelo = "FH",
                    AnoFabricacao = 2022,
                    AnoModelo = 2021,
                },
                new Caminhao.Models.Caminhao()
                {
                    Nome = "Teste automático 5",
                    Modelo = "FM",
                    AnoFabricacao = 2021,
                    AnoModelo = 2020,
                },
                new Caminhao.Models.Caminhao()
                {
                    Nome = "Teste automático 6",
                    Modelo = "FF",
                    AnoFabricacao = 2020,
                    AnoModelo = 2023,
                }
            };

        }
        public ActionResult Create()
        {
            throw new NotImplementedException();
        }

        public ActionResult Create(Caminhao.Models.Caminhao tB_Caminhao)
        {
            throw new NotImplementedException();
        }

        public ActionResult Delete(Guid? id)
        {
            throw new NotImplementedException();
        }

        public ActionResult DeleteConfirmed(Guid id)
        {
            throw new NotImplementedException();
        }

        public ActionResult Details(Guid? id)
        {
            throw new NotImplementedException();
        }

        public ActionResult Edit(Guid? id)
        {
            throw new NotImplementedException();
        }

        public ActionResult Edit(Caminhao.Models.Caminhao tB_Caminhao)
        {
            throw new NotImplementedException();
        }

        public IActionResult Index()
        {
            throw new NotImplementedException();
        }
    }
}

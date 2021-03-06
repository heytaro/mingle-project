﻿using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingleApp.Model
{
        public class Encontro
        {
            private int id;
            public  Usuario administrador;
            public String titulo { get; set; }
            public String local { get; set; }
            public String descricao { get; set; }
            public GeoCoordinate coordenadas { get; set; }
            public DateTime horaData { get; set; }
            public List<Usuario> convidados { get; set; }


            public Encontro()
            {

                titulo = descricao = local = "";
                coordenadas = new GeoCoordinate();
                horaData = new DateTime();
                convidados = new List<Usuario>();
            }
            public Encontro(int id)
            {
                this.id = id;
                titulo = descricao = local = "";
                coordenadas = new GeoCoordinate();
                horaData = new DateTime();
                convidados = new List<Usuario>();
            }

            public Encontro(int pId, String pTitulo, String pDescricao, String pLocal, GeoCoordinate pCoord, DateTime pHoraData)
            {
                id = pId;
                titulo = pTitulo;
                descricao = pDescricao;
                local = pLocal;
                coordenadas = pCoord;
                horaData = pHoraData;
            }
        }

    }


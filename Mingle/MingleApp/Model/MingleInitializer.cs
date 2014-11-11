using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace MingleApp.Model
{
    public class MingleInitializer
    {
        //ISSO É PROS AMIGOS DO MAINUSER

        public List<Usuario> CreateUsers()
        {

            List<Usuario> lstRetorno = new List<Usuario>();
            Usuario u1 = new Usuario(1);
            u1.nome = "Ana Albuquerque";
            u1.email = "a@gmail.com";
            u1.senha = "a123";
            u1.Telefone = "9324242";
            u1.addCaronaScore();
            u1.addEncontroScore();
            u1.addFotoScore();
            u1.addAtrasoScore();
            u1.addCaronaScore();
            u1.addEncontroScore();
            u1.addFotoScore();
            lstRetorno.Add(u1);

            Usuario u2, u3, u4, u5;
            u2 = new Usuario(2);
            u2.nome = "Yasmim Libório";
            u2.email = "y@gmail.com";
            u2.senha = "y123";
            u2.addAtrasoScore();
            u2.addAtrasoScore();
            u2.addAtrasoScore();
            u2.addCaronaScore();
            u2.addEncontroScore();
            u2.addFotoScore();
            u2.addAtrasoScore();
            u2.addCaronaScore();
            u2.addEncontroScore();
            u2.addFotoScore();
            lstRetorno.Add(u2);

            u3 = new Usuario(3);
            u3.nome = "Nathália Oliveira";
            u3.email = "n@gmail.com";
            u3.senha = "n123";
            u3.addCaronaScore();
            u3.addEncontroScore();
            u3.addFotoScore();
            u3.addCaronaScore();
            u3.addEncontroScore();
            lstRetorno.Add(u3);


            u4 = new Usuario(4);
            u4.nome = "Camila Smith";
            u4.email = "c@gmail.com";
            u4.senha = "c123";
            u4.addCaronaScore();
            u4.addEncontroScore();
            u4.addFotoScore();
            u4.addCaronaScore();
            u4.addEncontroScore();
            u4.addEncontroScore();
            u4.addEncontroScore();
            u4.addEncontroScore();
            lstRetorno.Add(u4);


            u5 = new Usuario(5);
            u5.nome = "Giovanna Oliveira";
            u5.email = "g@gmail.com";
            u5.senha = "g123";
            u5.addCaronaScore();
            u5.addEncontroScore();
            u5.addFotoScore();
            u5.addEncontroScore();
            u5.addEncontroScore();
            u5.addAtrasoScore();
            u5.addAtrasoScore();
            lstRetorno.Add(u5);

            Usuario user = new Usuario(6);
            user.nome = "Florence Welsh";
            user.email = "f@email.com";
            user.senha = "f123";
            //user.encontros = CreateEncontros();
            user.addEncontroScore();
            user.addFotoScore();
            user.addCaronaScore();
            user.addEncontroScore();
            lstRetorno.Add(user);

            Encontro e = new Encontro(0);
            e.titulo = "Pizzaria projeto";
            e.descricao = "Pizzaria com o pessoal do projeto";
            e.local.nome = "Mr. Pizzo";
            e.horaData = new DateTime(2014, 10, 26, 16, 30, 0);
            e.convidados.Add(u2);
            e.convidados.Add(u3);
            e.administrador = u1;
            u1.encontros.Add(e);
            u2.encontros.Add(e);
            u3.encontros.Add(e);

            e = new Encontro(1);
            e.titulo = "FDS Projeto";
            e.descricao = "Reunião pra fazer as coisas";
            e.local.nome = "Casa da Camila";
            e.horaData = new DateTime(2014, 10, 30, 18, 30, 0);
            e.administrador = u2;
            u2.encontros.Add(e);
            e.convidados.Add(u4);
            e.convidados.Add(user);
            e.convidados.Add(u1);
            u1.encontros.Add(e);
            u4.encontros.Add(e);
            user.encontros.Add(e);

            e = new Encontro(2);
            e.titulo = "Paintball";
            e.descricao = "Foi tudo ideia da Girina";
            e.local.nome = "Paintball";
            e.horaData = new DateTime(2014, 11, 14, 20, 30, 0);
            e.administrador = u5;

            e = new Encontro(3);
            e.titulo = "Cinema";
            e.descricao = "Testando um evento de vdd no aplicativo";
            e.local.nome = "Cinépolis Ponta Negra";
            e.horaData = new DateTime(2014, 11, 24, 15, 0, 0);
            e.administrador = u4;
            u4.encontros.Add(e);
            e.convidados.Add(u1);
            e.convidados.Add(u2);
            e.convidados.Add(u3);
            e.convidados.Add(u5);
            e.convidados.Add(user);
            u1.encontros.Add(e);
            u2.encontros.Add(e);
            u3.encontros.Add(e);
            u5.encontros.Add(e);
            user.encontros.Add(e);

            
            return lstRetorno;
        }

        public List<Encontro> CreateEncontros() {

            List<Encontro> lstRetorno = new List<Encontro>();
            DateTime dt = new DateTime();
            Encontro e = new Encontro(0);
            e.convidados = CreateUsers();
            e.titulo = "Pizzaria projeto";
            e.descricao = "Pizzaria com o pessoal do projeto";
            e.local.nome = "Mr. Pizzo";
          // e.horaData.Add(new TimeSpan(-15, 5, 12, 3));
            lstRetorno.Add(e);

            e = new Encontro(1);
            e.convidados = CreateUsers();
            e.titulo = "FDS Projeto";
            e.descricao = "Reunião pra fazer as coisas";
            e.local.nome = "Casa da Camila";
            //e.horaData = dt.Add(new TimeSpan(-5, -4, 33, 11));
            lstRetorno.Add(e);

            e = new Encontro(2);
            e.convidados = CreateUsers();
            e.titulo = "Paintball";
            e.descricao = "Foi tudo ideia da Girina";
            e.local.nome = "Paintball";
            //e.horaData = dt.Add(new TimeSpan(-30, -16, -55, 0));
            lstRetorno.Add(e);

            e = new Encontro(3);
            e.convidados = CreateUsers();
            e.titulo = "Cinema";
            e.descricao = "Testando um evento de vdd no aplicativo";
            e.local.nome = "Cinépolis Ponta Negra";
            //e.horaData = dt.Add(new TimeSpan(50, 44, 13, 9));
            lstRetorno.Add(e);

            e = new Encontro(4);
            e.convidados = CreateUsers();
            e.titulo = "Aniversário!";
            e.descricao = "É aniversário de alguém em algum lugar, eu acho";
            e.local.nome = "Playarte Manauara";
            //e.horaData = dt.Add(new TimeSpan(17, 0, 0, 0));
            lstRetorno.Add(e);

            return lstRetorno;
        }

    }
}

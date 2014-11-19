using System;
using System.Collections.Generic;
using System.Device.Location;
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
            u1.nome = "Amanda Costa";
            u1.email = "amanda@gmail.com";
            u1.senha = "a123";
            u1.Telefone = "(92)9145-0043";
            u1.fotoPerfil = "/Images/ProfilePictures/u1.jpg";
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
            u2.email = "yasmim.liborio@gmail.com";
            u2.Telefone = "(92)8819-7315";
            u2.senha = "y123";
            u2.fotoPerfil = "/Images/ProfilePictures/u2.png";
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
            u3.email = "nath_larissa14@gmail.com";
            u3.Telefone = "(92)9122-3318";
            u3.fotoPerfil = "/Images/ProfilePictures/u3.jpg";
            u3.senha = "n123";
            u3.addCaronaScore();
            u3.addEncontroScore();
            u3.addFotoScore();
            u3.addCaronaScore();
            u3.addEncontroScore();
            lstRetorno.Add(u3);


            u4 = new Usuario(4);
            u4.nome = "Camila Smith";
            u4.email = "camilasmith@gmail.com";
            u4.Telefone = "(92)9942-1954";
            u4.senha = "c123";
            u4.fotoPerfil = "/Images/ProfilePictures/u4.jpg";
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
            u5.email = "geo._oliveira@gmail.com";
            u5.Telefone = "(92)8122-3345";
            u5.senha = "g123";
            u5.fotoPerfil = "/Images/ProfilePictures/u5.jpg";
            u5.addCaronaScore();
            u5.addEncontroScore();
            u5.addFotoScore();
            u5.addEncontroScore();
            u5.addEncontroScore();
            u5.addAtrasoScore();
            u5.addAtrasoScore();
            lstRetorno.Add(u5);

            Usuario u6 = new Usuario(6);
            u6.nome = "Olga Leão";
            u6.email = "OlgaLeao@email.com";
            u6.Telefone = "(92)8111-0023";
            u6.fotoPerfil = "/Images/ProfilePictures/u6.jpg";
            u6.senha = "f123";
            u6.addEncontroScore();
            u6.addFotoScore();
            u6.addCaronaScore();
            u6.addEncontroScore();
            lstRetorno.Add(u6);

            return lstRetorno;
        }

        public List<Encontro> CreateEncontros() {

            List<Encontro> lstRetorno = new List<Encontro>();
            Encontro e = new Encontro(0);
            e.convidados = CreateUsers();
            e.titulo = "Pizzaria projeto";
            e.descricao = "Pizzaria com o pessoal do projeto";
            e.local = "Mr. Pizzo";
            e.horaData.AddYears(2014);
            e.horaData.AddMonths(5);
            e.horaData.AddDays(9);
            e.horaData.Add(new TimeSpan(17, 30, 00));
            lstRetorno.Add(e);

            e = new Encontro(1);
            e.convidados = CreateUsers();
            e.titulo = "FDS Projeto";
            e.descricao = "Reunião pra fazer as coisas";
            e.local = "Casa da Camila";
            e.horaData.AddYears(2014);
            e.horaData.AddMonths(6);
            e.horaData.AddDays(17);
            e.horaData.Add(new TimeSpan(8, 00, 00));
            lstRetorno.Add(e);

            e = new Encontro(2);
            e.convidados = CreateUsers();
            e.titulo = "Paintball";
            e.descricao = "Foi tudo ideia da Girina";
            e.local = "Paintball";
            e.horaData.AddYears(2014);
            e.horaData.AddMonths(6);
            e.horaData.AddDays(19);
            e.horaData.Add(new TimeSpan(15, 30, 00));
            lstRetorno.Add(e);

            e = new Encontro(3);
            e.convidados = CreateUsers();
            e.titulo = "Cinema";
            e.descricao = "Anabelle, sessão de 16:15";
            e.local = "Shopping Ponta Negra";
            e.horaData.AddYears(2014);
            e.horaData.AddMonths(9);
            e.horaData.AddDays(3);
            e.horaData.Add(new TimeSpan(15, 00, 00));
            lstRetorno.Add(e);

            e = new Encontro(4);
            e.convidados = CreateUsers();
            e.titulo = "Aniversário!";
            e.descricao = "É aniversário de alguém em algum lugar, eu acho";
            e.local = "Shopping Manauara";
            e.horaData.AddYears(2014);
            e.horaData.AddMonths(10);
            e.horaData.AddDays(22);
            e.horaData.Add(new TimeSpan(19, 00, 00));
            lstRetorno.Add(e);

            return lstRetorno;
        }

        public Usuario createMainUser()
        {
            Usuario mingleUser = new Usuario();
            mingleUser.nome = "Ana Albuquerque";
            mingleUser.Telefone = "(92)9984-5762";
            mingleUser.email = "a@gmail.com";
            mingleUser.senha = "a123";
            mingleUser.amigos = this.CreateUsers();
            mingleUser.atrasoScore = 200;
            mingleUser.fotoScore = 900;
            mingleUser.encontros = this.CreateEncontros();
            mingleUser.fotoPerfil = "/Images/ProfilePictures/soudessas.png";
            return mingleUser;
        }

        public List<Local> createLocais()
        {
            List<Local> listaEstaticaDeLocais = new List<Local>();

            listaEstaticaDeLocais.Add(new Local(new GeoCoordinate(-3.130278, -60.023333), "Mr. Pizzo"));
            listaEstaticaDeLocais.Add(new Local(new GeoCoordinate(-3.134785, -60.016241), "Casa da Camila"));
            listaEstaticaDeLocais.Add(new Local(new GeoCoordinate(-3.135899, -60.016803),"Paintball"));
            listaEstaticaDeLocais.Add(new Local(new GeoCoordinate (-3.071632, -59.981144), "Shopping Ponta Negra"));
            listaEstaticaDeLocais.Add(new Local(new GeoCoordinate(-3.134311, -60.022693), "Shopping Manauara"));
            listaEstaticaDeLocais.Add(new Local(new GeoCoordinate(-3.048847, -60.033249), "Casa da Yasmim"));

            return listaEstaticaDeLocais;
        }

    }
}

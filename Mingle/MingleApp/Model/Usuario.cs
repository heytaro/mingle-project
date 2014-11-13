using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using MingleApp;
using System.Windows;

namespace MingleApp.Model
{
    public class Usuario
    {

        private int id;
        //App thisApp = Application.Current as App;
        public String nome {get; set;}
        public String sexo;
        public String email;
        public String senha ;
        public String Telefone;
        public String fotoPerfil;
        public int encontroScore;
        public int fotoScore;
        public int caronaScore;
        public int atrasoScore;
        public List<Usuario> amigos;
        public List<Encontro> encontros;
        public List<Image> fotos;
        public int nEncontros = 0;
        public int nAtrasos = 0;
        public int nFotos = 0;


        public int posicao;
        //CONSTRUTOR NAT (FALTA O QUE FAZER COM O ID)
        public Usuario()
        {
           /* encontroScore = 0;
            fotoScore = 0;
            atrasoScore = 0;
            caronaScore = 0;
            amigos = new List<Usuario>();
            encontros = new List<Encontro>();
            fotos = new List<Image>();*/

            nome = String.Empty;
            email = String.Empty;
            encontroScore = 0;
            fotoScore = 0;
            atrasoScore = 0;
            caronaScore = 0;
            amigos = new List<Usuario>();
            encontros = new List<Encontro>();
            fotos = new List<Image>();
            fotoPerfil = String.Empty;

        }

        //CONSTRUTOR ANA (COM ID POR PARÂMETRO)
        public Usuario(int pId)
        {
            id = pId;
            amigos = new List<Usuario>();
            encontros = new List<Encontro>();
            fotos = new List<Image>();
        }

        //GET ID
        public int getId()
        {
            return id;
        }

        public String getNome() { return this.nome; }

        public int getScore() { return this.caronaScore + this.encontroScore + this.fotoScore - this.atrasoScore; }
        public int getFotoScore() { return this.fotoScore; }
        public int getAtrasoScore() { return this.atrasoScore; }
        public int getCaronaScore() { return this.caronaScore; }
        public int getEncontroScore() { return this.encontroScore; }

        public List<Encontro> getEncontros() { return this.encontros; }

        public void addFotoScore()
        {
            this.fotoScore += 50;
        }

        public void addEncontroScore()
        {
            this.encontroScore += 1000;
        }

        public void addCaronaScore()
        {
            this.caronaScore += 400;
        }

        public void addAtrasoScore()
        {
            this.atrasoScore += 500;
        }
    }
}

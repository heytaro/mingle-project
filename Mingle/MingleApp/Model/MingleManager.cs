using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MingleApp.View;

namespace MingleApp.Model
{
    public class MingleManager
    {
       
        public List<Usuario> mingleUsers;
        public List<Local> mingleLocals;
        public Usuario currentUser;
        public Encontro novoEncontro;
        public List<Local> listaLocais;

        public MingleManager()
        {  
            MingleInitializer mi = new MingleInitializer();
            mingleUsers = new List<Usuario>();
            this.mingleUsers = mi.CreateUsers();
            App thisApp = Application.Current as App;
            currentUser = null;
            novoEncontro = new Encontro();
        }

        //método que retorna a lista de emails do Mingle
        public List<String> getEmails()
        {
            List<String> retorno = new List<String>();
            foreach (Usuario u in this.mingleUsers)
            {
                retorno.Add(u.email);
            }
            return retorno;
        }

        public List<Usuario> getMingleUsers()
        {
            return this.mingleUsers;
        }

        public int getUserListSize()
        {
            return this.mingleUsers.Count;
        }

        public Usuario getUser(int index)
        {
            return mingleUsers[index];
        }

        public void addUser(Usuario user)
        {
            mingleUsers.Add(user);
        }

        public List<Usuario> rankingGeral()
        {
            List<Usuario> retorno = new List<Usuario>();
            retorno = mingleUsers;
            for (int i = 0; i < retorno.Count - 1; i++)
            {
                for (int j = i + 1; j < retorno.Count; j++)
                {
                    if (retorno[i].getScore() < retorno[j].getScore())
                    {
                        Usuario aux;
                        aux = retorno[i];
                        retorno[i] = retorno[j];
                        retorno[j] = aux;
                    }
                }
            }
            return retorno;
        }

        public List<Usuario> rankingFoto()
        {
            List<Usuario> retorno = mingleUsers;
            for (int i = 0; i < retorno.Count - 1; i++)
            {
                for (int j = i + 1; j < retorno.Count; j++)
                {
                    if (retorno[i].getFotoScore() < retorno[j].getFotoScore())
                    {
                        Usuario aux;
                        aux = retorno[i];
                        retorno[i] = retorno[j];
                        retorno[j] = aux;
                    }
                    else
                    {
                        if (retorno[i].getFotoScore() == retorno[j].getFotoScore())
                        {
                            if (retorno[i].getScore() < retorno[j].getScore())
                            {
                                Usuario aux;
                                aux = retorno[i];
                                retorno[i] = retorno[j];
                                retorno[j] = aux;
                            }
                        }
                    }
                }
            }
            return retorno;
        }

        public List<Usuario> rankingAtraso()
        {
            List<Usuario> retorno = mingleUsers;
            for (int i = 0; i < retorno.Count - 1; i++)
            {
                for (int j = i + 1; j < retorno.Count; j++)
                {
                    if (retorno[i].getAtrasoScore() < retorno[j].getAtrasoScore())
                    {
                        Usuario aux;
                        aux = retorno[i];
                        retorno[i] = retorno[j];
                        retorno[j] = aux;
                    }
                    else
                    {
                        if (retorno[i].getAtrasoScore() == retorno[j].getAtrasoScore())
                        {
                            if (retorno[i].getScore() < retorno[j].getScore())
                            {
                                Usuario aux;
                                aux = retorno[i];
                                retorno[i] = retorno[j];
                                retorno[j] = aux;
                            }
                        }
                    }
                }
            }
            return retorno;
        }
        public List<Usuario> rankingEncontro()
        {
            List<Usuario> retorno = mingleUsers; for (int i = 0; i < retorno.Count - 1; i++)
            {
                for (int j = i + 1; j < retorno.Count; j++)
                {
                    if (retorno[i].getEncontroScore() < retorno[j].getEncontroScore())
                    {
                        Usuario aux;
                        aux = retorno[i];
                        retorno[i] = retorno[j];
                        retorno[j] = aux;
                    }
                    else
                    {
                        if (retorno[i].getEncontroScore() == retorno[j].getEncontroScore())
                        {
                            if (retorno[i].getScore() < retorno[j].getScore())
                            {
                                Usuario aux;
                                aux = retorno[i];
                                retorno[i] = retorno[j];
                                retorno[j] = aux;
                            }
                        }
                    }
                }
            }
            return retorno;
        }
        public List<Usuario> rankingCarona()
        {
            List<Usuario> retorno = mingleUsers;
            for (int i = 0; i < retorno.Count - 1; i++)
            {
                for (int j = i + 1; j < retorno.Count; j++)
                {
                    if (retorno[i].getCaronaScore() < retorno[j].getCaronaScore())
                    {
                        Usuario aux;
                        aux = retorno[i];
                        retorno[i] = retorno[j];
                        retorno[j] = aux;
                    }
                    else
                    {
                        if (retorno[i].getCaronaScore() == retorno[j].getCaronaScore())
                        {
                            if (retorno[i].getScore() < retorno[j].getScore())
                            {
                                Usuario aux;
                                aux = retorno[i];
                                retorno[i] = retorno[j];
                                retorno[j] = aux;
                            }
                        }
                    }
                }
            }
            return retorno;
        }


        private void fonteDeDados()
        {
            Usuario u = new Usuario();
            u.nome = "Yasmim Liborio";
            u.addAtrasoScore();
            u.addAtrasoScore();
            u.addAtrasoScore();
            u.addCaronaScore();
            u.addEncontroScore();
            u.addFotoScore();
            u.addAtrasoScore();
            u.addCaronaScore();
            u.addEncontroScore();
            u.addFotoScore();
            mingleUsers.Add(u);
            u = new Usuario();
            u.nome = "Ana Albuquerque";
            u.addCaronaScore();
            u.addEncontroScore();
            u.addFotoScore();
            u.addAtrasoScore();
            u.addCaronaScore();
            u.addEncontroScore();
            u.addFotoScore();
            mingleUsers.Add(u);
            u = new Usuario();
            u.nome = "Nathália Oliveira";
            u.addCaronaScore();
            u.addEncontroScore();
            u.addFotoScore();
            u.addCaronaScore();
            u.addEncontroScore();
            mingleUsers.Add(u);
            u = new Usuario();
            u.nome = "Nathália Oliveira";
            u.addCaronaScore();
            u.addEncontroScore();
            u.addFotoScore();
            u.addCaronaScore();
            u.addEncontroScore();
            u.addEncontroScore();
            u.addEncontroScore();
            u.addEncontroScore();
            mingleUsers.Add(u);
            u = new Usuario();
            u.nome = "Giovanna Oliveira";
            u.addCaronaScore();
            u.addEncontroScore();
            u.addFotoScore();
            u.addEncontroScore();
            u.addEncontroScore();
            u.addAtrasoScore();
            u.addAtrasoScore();
            mingleUsers.Add(u);
        }
    }
}

using Notas_app.Modelos;
using SQLite;
using System;
using System.Collections.Generic;

namespace Notas_app.Servicos
{
    public class Servico_DB
    {
        SQLiteConnection con;
        public string Status_Message { get; set; }
        
        public Servico_DB(string DataBase)
        {
            if (DataBase == null) DataBase = App.DataBase;
            con = new SQLiteConnection(DataBase);
            con.CreateTable<Modelo_nota>();
        }

        public void Inserir(Modelo_nota nota)
        {
            try
            {
                if (string.IsNullOrEmpty(nota.Titulo))
                    throw new Exception("Titulo da nota não informado");
                if (string.IsNullOrEmpty(nota.Corpo))
                    throw new Exception("Corpo da nota não informado");
                int result=con.Insert(nota);
                if (result != 0) 
                   Status_Message=string.Format("{0} registro adicionado, Nota: {} ",result,nota.Titulo);    
                else
                    Status_Message = string.Format("Registro não foi adicionado!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Modelo_nota> Listar()
        {
            List<Modelo_nota> lista = new List<Modelo_nota>();
            try
            {
                lista = con.Table<Modelo_nota>().ToList();
                Status_Message = "Listagem das notas";

            }
            catch (Exception)
            {
                throw;
            }
            return lista;
        }
        public void Alterar(Modelo_nota nota)
        {
            try
            {
                if (string.IsNullOrEmpty(nota.Titulo))
                    throw new Exception("Titulo da nota não informado");
                if (string.IsNullOrEmpty(nota.Corpo))
                    throw new Exception("Corpo da nota não informado");
                if (nota.Id == 0) throw new Exception("Id da nota não informado");
                int result=con.Update(nota);
                Status_Message = string.Format("{0} registro alterado!", result);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Apagar(int id)
        {
            try
            {
                int result= con.Table<Modelo_nota>().Delete(r=>r.Id == id);
                Status_Message = string.Format("{0} registro deletados!", result);
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        public List<Modelo_nota> Localizar(string titulo)
        {
            List<Modelo_nota> lista = new List<Modelo_nota>();
            try
            {
                var resp = from p in con.Table<Modelo_nota>() where p.Titulo.ToLower().Contains(titulo.ToLower()) select p;
                lista = resp.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }
        public List<Modelo_nota> Localizar(string Titulo, Boolean favorito)
        {
            List<Modelo_nota> lista = new List<Modelo_nota>();
            try
            {
                var resp = from p in con.Table<Modelo_nota>() where p.Titulo.ToLower().Contains(Titulo.ToLower()) && p.Favorito == favorito select p;
                lista = resp.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }
        public Modelo_nota Ler_nota(int id)
        {
            Modelo_nota modelo = new Modelo_nota();

            try
            {
                modelo = con.Table<Modelo_nota>().First(n => n.Id == id);
            }
            catch (Exception)
            {

                throw;
            }
            return modelo;
        }
    }
}

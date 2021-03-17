using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Biblioteca_DIO
{
    public class Serie : EntidadeBase
    {
        public Genero Genero { get; private set; }
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public int Ano { get; private set; }
        public double AvaliacaoImdb { get; private set; }
        public int ClassificacaoEtaria { get; private set; }
        public bool Excluido { get; private set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano, double avaliacaoImdb, int classificacaoEtaria)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.AvaliacaoImdb = avaliacaoImdb;
            this.ClassificacaoEtaria = classificacaoEtaria;
        }

        public void Alterar(Genero genero,
            string titulo,
            string descricao,
            int ano,
            double avaliacaoImdb,
            int classificacaoEtaria)
        {
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.AvaliacaoImdb = avaliacaoImdb;
            this.ClassificacaoEtaria = classificacaoEtaria;
        }

        public override string ToString()
        {
            return
                $"-------------------------------------------------------------------------------------------- \n" +
                $"Id: {Id} | Genero: {this.Genero} | Titulo: {this.Titulo} |  Ano: {this.Ano} \n" +
                $"Avaliação IMDB: {this.AvaliacaoImdb.ToString("F2", CultureInfo.InvariantCulture)} | Classificação étaria: {this.ClassificacaoEtaria} \n" +
                $" Descrição: {this.Descricao}  \n" +
                $"--------------------------------------------------------------------------------------------";

        }
    }
}
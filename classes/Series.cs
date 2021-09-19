namespace cadastroSeries
{
    public class Series : EntidadeBase
    {
        //Atributos
        private Genero Genero { get, set, }
        private string Titulo { get, set, }
        private string Descricao { get, set, }
        private Int Ano { get, set, }


        //Métodos
        public Series[int id, Genero genero, string titulo, string descricao, int ano]
        {
            this.Id = id;
            this.genero = genero;
            this.Titulo = titulo;
            this.descricao = descricao;
            this.Ano = ano;
        }

        public override string ToString()
        {
            //Environment NewLine
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano: " + this.Ano + Environment.NewLine;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }

    }
}

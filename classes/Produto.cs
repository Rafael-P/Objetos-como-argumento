namespace Objetos_como_argumentos.classes
{
    public class Produto
    {
        //atributos
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        
        //metodos contrutores
        public Produto(){

        }

        public Produto(int _codigo, string _nome, float _preco){
            this.Codigo = _codigo;
            this.Nome = _nome;
            this.Preco = _preco;
        }


    }
}
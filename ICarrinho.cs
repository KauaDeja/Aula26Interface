namespace Aula26Interface
{
    public interface ICarrinho
    {       
         void Adicionar(Produto produto);

         void Deletar(Produto produto);
         void Ler();
         void Alterar(int Codigo, Produto _produtoAlterado);

         void MostrarTotal(){
            
         }
    
    }
}
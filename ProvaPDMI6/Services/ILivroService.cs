using ProvaPDMI6.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPDMI6.Services
{
    public interface ILivroService
    {
        Task InitializeAsync();
        Task<List<Livro>> ListarLivros();
        Task<Livro> ListarLivroPorId(int id);
        Task<int> AdicionarLivro(Livro book);
        Task<int> AtualizarLivro(Livro book);
        Task<int> DeletarLivro(Livro book);
    }
}

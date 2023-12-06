using ProvaPDMI6.Data;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPDMI6.Services
{
    public class LivroService : ILivroService
    {
        private SQLiteAsyncConnection _dbConexao;
        public async Task InitializeAsync()
        {
            await SetUpDb();
        }

        private async Task SetUpDb()
        {
            if (_dbConexao == null)
            {
                string dbPath =
                Path.Combine(FileSystem.Current.AppDataDirectory, "clientdb.db3");
                _dbConexao = new SQLiteAsyncConnection(dbPath);
                await _dbConexao.CreateTableAsync<Livro>();
            }
        }

        public async Task<int> AdicionarLivro(Livro book)
        {
            return await _dbConexao.InsertAsync(book);
        }

        public async Task<int> DeletarLivro(Livro book)
        {
            return await _dbConexao.DeleteAsync(book);
        }
        public async Task<int> AtualizarLivro(Livro book)
        {
            return await _dbConexao.UpdateAsync(book);
        }

        public async Task<Livro> ListarLivroPorId(int id)
        {
            var aluno = await _dbConexao.QueryAsync<Livro>($"Select * From { nameof(Livro) } where Id = { id } ");
            return aluno.FirstOrDefault();
        }

        public async Task<List<Livro>> ListarLivros()
        {
            return await _dbConexao.Table<Livro>().ToListAsync();
        }

        
    }
}

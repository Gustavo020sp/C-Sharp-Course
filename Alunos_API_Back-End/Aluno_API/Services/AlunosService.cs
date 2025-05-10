using Aluno_API.Context;
using Aluno_API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Aluno_API.Services
{
    public class AlunosService : IAlunosService
    {
        private readonly AppDbContext _context;

        public AlunosService(AppDbContext context)
        {
            _context = context;
        }

        //Implementação dos métodos para consultas e registros no banco de dados//
        public async Task<IEnumerable<Aluno>> GetAlunosAsync()
        {
            try
            {
                return await _context.Alunos.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<Aluno> GetAlunoAsync(int id)
        {
            var aluno = await _context.Alunos.FindAsync(id);
            return aluno;
        }
        public async Task<IEnumerable<Aluno>> GetAlunosByNomeAsync(string nome)
        {
            IEnumerable<Aluno> alunos;
            if (!string.IsNullOrWhiteSpace(nome))
            {
                alunos = await _context.Alunos.Where(n => n.Nome == nome).ToListAsync();
            }
            else
            {
                alunos = await GetAlunosAsync();
            }
            return alunos;
        }

        //Metodos CRUD
        public async Task CreateAlunoAsync(Aluno aluno)
        {
            _context.Add(aluno);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAlunoAsync(Aluno aluno)
        {
            _context.Remove(aluno);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAlunoAsync(Aluno aluno)
        {
            _context.Update(aluno);
            await _context.SaveChangesAsync();
        }
    }
}

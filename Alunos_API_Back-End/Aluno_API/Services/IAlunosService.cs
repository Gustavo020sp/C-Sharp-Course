using Aluno_API.Entities;

namespace Aluno_API.Services
{
    public interface IAlunosService
    {
        //busca genérica
        Task<IEnumerable<Aluno>> GetAlunosAsync();

        //busca por ID
        Task<Aluno> GetAlunoAsync(int  id);

        //busca por nome
        Task<IEnumerable<Aluno>> GetAlunosByNomeAsync(string nome);

        //criar um novo aluno
        Task CreateAlunoAsync(Aluno aluno);

        //deletar aluno
        Task DeleteAlunoAsync(Aluno aluno);

        //update aluno
        Task UpdateAlunoAsync(Aluno aluno);

    }
}

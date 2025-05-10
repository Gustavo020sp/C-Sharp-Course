using Aluno_API.Entities;
using Aluno_API.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aluno_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    //[Produces("application/json")]
    public class AlunosController : ControllerBase
    {
        //injeção de dependência 
        private readonly IAlunosService alunosService;

        public AlunosController(IAlunosService alunosService)
        {
            this.alunosService = alunosService;
        }

        //METODOS GET

        //ENDPOINT lista alunos
        [HttpGet]
        public async Task<ActionResult<IAsyncEnumerable<Aluno>>> GetAlunos()
        {
            try
            {
                var alunos = await alunosService.GetAlunosAsync();
                return Ok(alunos);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao obter alunos");
            }
        }

        //ENDPOINT aluno id
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Aluno>> GetAluno(int id)
        {
            try
            {
                var aluno = await alunosService.GetAlunoAsync(id);

                if (aluno == null)
                {
                    return NotFound($"Não existe o aluno com id {id}");
                }

                return Ok(aluno);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao obter aluno por id");
            }
        }

        //ENDPOINT aluno nome
        [HttpGet("AlunoPorNome")]
        public async Task<ActionResult<Aluno>> GetAlunosByNome([FromQuery] string nome)
        {
            try
            {
                var aluno = await alunosService.GetAlunosByNomeAsync(nome);

                if (!aluno.Any())
                {
                    return NotFound($"Não existe o aluno com o nome {nome}");
                }

                return Ok(aluno);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao obter aluno por nome");
            }
        }

        //METODOS POST
        [HttpPost]
        public async Task<ActionResult> Create(Aluno aluno)
        {
            try
            {
                await alunosService.CreateAlunoAsync(aluno);

                //retorna 201(recurso recem-criado)
                CreatedAtRoute(nameof(GetAluno), new { id = aluno.Id }, aluno);

                return Ok(aluno);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var aluno = await alunosService.GetAlunoAsync(id);

                if (aluno != null)
                {
                    await alunosService.DeleteAlunoAsync(aluno);
                    return Ok($"Aluno com id {id} deletado com sucesso!");                   
                }
                else
                {
                    return NotFound("Não existe o aluno com os critérios informados");
                }
                
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Edit(int id, [FromBody] Aluno aluno)
        {
            try
            {               
                if(aluno.Id == id)
                {
                    await alunosService.UpdateAlunoAsync(aluno);
                }
                else
                {
                    return BadRequest("dados inconsistntes");
                }

                return Ok($"Aluno com id = {id} foi atualizado com sucesso!");
            }
            catch
            {
                return BadRequest();
                //teste
            }
        }
    }
}

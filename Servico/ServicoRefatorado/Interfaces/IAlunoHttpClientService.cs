using web_renderizacao_server_side.Models;

namespace mvc_desafio21dias_api_gestao_razor.Servico.ServicoRefatorado.Interfaces
{
    public interface IAlunoHttpClientService : IHttpClientService<Aluno>
    {
         //contrato especializado para Aluno
    }
}
using web_renderizacao_server_side.Models;

namespace mvc_desafio21dias_api_gestao_razor.Servico.ServicoRefatorado.Interfaces
{
    public interface IMaterialHttpClientService : IHttpClientService<Material>
    {
         //contrato especializado para materiais
    }
}
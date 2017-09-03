using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gerador.Models;

namespace Gerador.Models
{
    public sealed class TableToClass
    {

        /// <summary>
        /// Configurar as tabelas do banco com o nome dos objetos a sererm gerado na aplicacao bem como seus namespaces.
        /// <NomeProjeto>.Data (camada de acesso a dados)
        /// <NomeProjeto>.Domain (camada de dominio ou negocios)
        /// <NomeProjeto>.WebUI (camada de apresentacao)
        /// </summary>
        public Dictionary<String, ModelConfig> GetTableMapper()
        {
            var Storage = new Dictionary<String, ModelConfig>();

            /// tabelas do banco 
            Storage.Add("USUARIO", new ModelConfig() { ClassName = "Usuario", NameSpaceDto = "HarpiaGed.Data", NameSpaceMapper = "HarpiaGed.Data", NameSpaceDomain = "HarpiaGed.Domain", NameSpaceService = "HarpiaGed.Service", CreateController = false });
      
            return (Storage);
        }
    }
}

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

            Storage.Add("IMAGEM",     new ModelConfig() { ClassName = "Image", NameSpaceDto = "HarpiaGed.Recognition.Data", NameSpaceMapper = "HarpiaGed.Recognition.Data", NameSpaceDomain = "HarpiaGed.Recognition.Domain", NameSpaceService = "HarpiaGed.Recognition.Service", CreateController = false });
            Storage.Add("IMAGEM_OCR", new ModelConfig()  { ClassName = "ImageOcr", NameSpaceDto = "HarpiaGed.Recognition.Data", NameSpaceMapper = "HarpiaGed.Recognition.Data", NameSpaceDomain = "HarpiaGed.Recognition.Domain", NameSpaceService = "HarpiaGed.Recognition.Service", CreateController = false });
            
            return (Storage);
        }
    }
}

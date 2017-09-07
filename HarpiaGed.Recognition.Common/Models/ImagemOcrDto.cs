using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HarpiaGedOcr.Common
{
    /// <summary>
    /// Nao alterar essa classe pois ela é o objeto identico a tabela do banco de dados.
    /// </summary>
    [Table("imagem_ocr")]
    public class ImagemOcrDto
    {
        [Key]
        public System.Int32 ID_IMAGEM_OCR { get; set; }
        public System.Int32 ID_IMAGEM { get; set; }
        public System.String DESCRICAO { get; set; }
        public System.Int32 VERTICE_TOP { get; set; }
        public System.Int32 VERTICE_LEFT { get; set; }
        public System.Int32 VERTICE_RIGHT { get; set; }
        public System.Int32 VERTICE_BOTTOM { get; set; }
    }
}


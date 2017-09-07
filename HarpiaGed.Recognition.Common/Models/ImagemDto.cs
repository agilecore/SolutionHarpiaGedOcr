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
    [Table("imagem")]
    public class ImagemDto
    {
        [Key]
        public System.Int32 ID_IMAGEM { get; set; }
        public System.String DPIX { get; set; }
        public System.String DPIY { get; set; }
        public System.String PPIX { get; set; }
        public System.String PPIY { get; set; }
        public System.String WIDTH { get; set; }
        public System.String HEIGHT { get; set; }
        public System.String PIXEL_FORMAT { get; set; }
        public System.String EXTENSION { get; set; }
        public System.String MEGAPIXEL { get; set; }
        public System.String FILE_SIZE { get; set; }
        public System.String INTERPOLACAO { get; set; }
        public System.DateTime DT_ENTRADA { get; set; }
        public System.String QUALIDADE { get; set; }
        public System.String DOCUMENTO { get; set; }
        public System.String STATUS { get; set; }
    }
}


using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarpiaGed.Recognition
{
    public class ImageAnnotation
    {
        /// <summary>
        /// Retorna objeto size contendo altura e largura da image.
        /// </summary>
        public Size size { get; set; }

        public string Size { get; set; }

        /// <summary>
        /// Largura da image em pixel.
        /// </summary>
        public Int32 Width { get; set; }

        /// <summary>
        /// Altura da image em pixel.
        /// </summary>
        public Int32 Height { get; set; }

        /// <summary>
        /// A resolução horizontal, em pixels por polegada, desta imagem.
        /// </summary>
        public float HorizontalResolution { get; set; }
        
        /// <summary>
        /// Pontos por polegadas em X (horizontal)
        /// </summary>
        public string DpiX { get; set; }

        /// <summary>
        /// Pontos por polegadas em Y (vertical)
        /// </summary>
        public string DpiY { get; set; }

        /// <summary>
        /// A resolução vertical, em pixels por polegada, desta imagem.
        /// </summary>
        public float VerticalResolution { get; set; }

        /// <summary>
        /// Expecifica o formato de arquivo de image.
        /// </summary>
        public String ImageFormat { get; set; }


        /// <summary>
        /// Dimensao física da imagem
        /// </summary>
        public String PhisicalDimension { get; set; }
        
        /// <summary>
        /// Dimensao física em largura
        /// </summary>
        public String PhisicalDimensionWidth { get; set; }
        
        /// <summary>
        /// Dimensao física em altura
        /// </summary>
        public String PhisicalDimensionHeight { get; set; }

        /// <summary>
        /// The horizontal resolution, in pixels per inch, of this Image.
        /// </summary>
        public String HorizondalResolution { get; set; }

        /// <summary>
        /// The vertical resolution, in pixels per inch, of this Image.
        /// </summary>
        public String VeritcalResolution { get; set; }

        /// <summary>
        /// Especifica o formato dos dados de cores para cada pixel na imagem.
        /// </summary>
        public String PixelFormatType { get; set; }
        
        /// <summary>
        /// Pegar dados de grafismo da imagem.
        /// </summary>
        public Graphics GraphicsImage { get; set; }
        
        /// <summary>
        /// Define a variedade de cores que compõem uma paleta de cores referente a image. As cores são em ARGB de 32 bits.
        /// </summary>
        public ColorPalette Palette { get; set; }

        /// <summary>
        /// Define a imagem em um array de bytes.
        /// </summary>
        public byte[] ImageByte { get; set; }

        /// <summary>
        /// Obtém ou define um objeto que fornece dados adicionais sobre a imagem
        /// </summary>
        public object Tag { get; set; }

        /// <summary>
        /// Proporção de tela de uma imagem bidimensional ("aspect ratio" em inglês) é a relação matemática entre as suas duas dimensões, em geral obtida pela divisão entre as medidas da largura e da altura.
        /// </summary>
        public decimal AspectRadio { get; set; }

        /// <summary>
        /// Determina como os valores intermediarios entre dois pontos sao calculados.
        /// [NearestNeighbor] - Especifica a interpolação de vizinho mais próximo.
        /// [Bilinear] - Especifica a interpolação bilinear. Este modo não é adequado para encolher uma imagem abaixo de 50% do tamanho original
        /// [HighQualityBilinear] - Especifica interpolação bilinear de alta qualidade. O préfiltrado é realizado para garantir um encolhimento de alta qualidade.
        /// [Bicubic] - Especifica a interpolação bicúbica. Nenhum pré-filtrado é feito. Este modo não é adequado para encolher uma imagem abaixo de 25% do tamanho original.
        /// [HighQualityBicubic] - Especifica a interpolação bicúbica de alta qualidade. O préfiltrado é realizado para garantir um encolhimento de alta qualidade. Este modo produz imagens de alta qualidade transformadas.
        /// </summary>
        public string Interpolacao { get; set; }

        public string Megapixel { get; set; }

        /// <summary>
        /// Define suavização da imagem.
        /// [AntiAlias] Especifica uma renderização suavizada.
        /// [Default] Não especifica uma suavização.
        /// [HighQuality] Especifica uma renderização suavizada.
        /// [HighSpeed] Não especifica uma suavização.
        /// [Invalid] Especifica um modo inválido.
        /// [None] Não especifica uma suavização.
        /// </summary>
        public SmoothingMode SmoothingMode { get; internal set; }

    }
}

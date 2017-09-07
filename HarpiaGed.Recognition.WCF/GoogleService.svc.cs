using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using HarpiaGed.Recognition.WCF.Interface;
using Google.Cloud.Vision.V1;
using System.Configuration;
using System.IO;
using System.ServiceModel.Activation;

namespace HarpiaGed.Recognition.WCF
{

    /// <summary>
    /// Exemplo basico : https://cloud.google.com/vision/docs/detecting-text
    /// </summary>
    [AspNetCompatibilityRequirements(RequirementsMode=AspNetCompatibilityRequirementsMode.Allowed)]
    public class GoogleService : IGoogleService
    {
        internal String output { get; set; }
        internal String googleCredential { get; set; }
        internal ImageAnnotatorClient clienteService { get; set; }

        /// <summary>
        /// Construtor padrão.
        /// </summary>
        public GoogleService() { Initializer(); }

        #region " Métodos que recebem stream "

        /// <summary>
        /// A detecção de texto do documento executa o reconhecimento óptico de caracteres.Esse recurso detecta texto de documento denso em uma imagem.
        /// </summary>
        public List<ImageProcessPage> DetectDocumentText(System.IO.Stream fileStream)
        {
            try
            {
                var image = Google.Cloud.Vision.V1.Image.FromStream(fileStream);

                ImageAnnotatorClient client = ImageAnnotatorClient.Create();
                TextAnnotation text = client.DetectDocumentText(image);
                ImageProcessPage imageProcessPage;
                ImageProcessPageParagraphs imageProcessPageParagraphs;
                List<ImageProcessPage> imageProcessPageCollection = new List<ImageProcessPage>();

                // para cada pagina detecta blocos de textos.
                foreach (var page in text.Pages)
                {
                    imageProcessPage = new ImageProcessPage();

                    // para cada bloco de texto.
                    foreach (var block in page.Blocks)
                    {
                        imageProcessPageParagraphs = new ImageProcessPageParagraphs();
                        
                        foreach (var paragraph in block.Paragraphs)
                        {
                            // pega as coordenadas do paragrafo.
                            foreach (var coordenate in paragraph.BoundingBox.Vertices)
                            {
                                imageProcessPageParagraphs.Coordenates.Add(new ImageProcessCoordenate
                                {
                                    X = coordenate.X, // Coordenada na horizontal
                                    Y = coordenate.Y  // Coordenada na vertical
                                });
                            }

                            foreach (var word in paragraph.Words)
                            {
                                var phrase = new StringBuilder();
                                phrase.Append(word.Symbols.Select(x => x.Text) + " ");
                                imageProcessPageParagraphs.Phrase = phrase.ToString();                                
                            }
                        }
                    }

                    imageProcessPageCollection.Add(imageProcessPage);
                }

                return (imageProcessPageCollection);

            }
            catch (AnnotateImageException e)
            {
                //AnnotateImageResponse response = e.Response;
                //return (response.Error);
                throw new FaultException(e.Response.ToString());
            }
        }

        /// <summary>
        /// O recurso propriedades da imagem detecta os atributos gerais da imagem.
        /// </summary>
        private object DetectImageProperties(System.IO.Stream fileStream)
        {
            try
            {                
                var image    = Google.Cloud.Vision.V1.Image.FromStream(fileStream);
                var response = clienteService.DetectImageProperties(image);
                return response;
            }
            catch (AnnotateImageException e)
            {
                //AnnotateImageResponse response = e.Response;
                //return (response.Error);
                throw new FaultException(e.Response.ToString());
            }
        }

        /// <summary>
        /// A detecção de texto executa o reconhecimento óptico de caracteres. Detecta e extrai texto em uma imagem com suporte para uma ampla gama de idiomas. Ele também possui identificação automática de idioma.
        /// </summary>
        public List<ImageProcess> DetectText(System.IO.Stream fileStream)
        {
            try
            {                
                var image      = Google.Cloud.Vision.V1.Image.FromStream(fileStream);
                var response   = clienteService.DetectText(image).ToList();
                var collection = new List<ImageProcess>();

                // Verificacao se encontrou alguma descricao OCR.
                if ((response.Count > 0) || (response != null))
                {
                    // Para cada descricao encontrada na image pelo OCR do Google
                    foreach (var item in response)
                    {
                        var imageProcess        = new ImageProcess();

                        imageProcess.Score      = item.Score;               
                        imageProcess.Confidence = item.Confidence;
                        imageProcess.Locale     = item.Locale;
                        imageProcess.Describe   = item.Description;

                        foreach (var coordenate in item.BoundingPoly.Vertices)
                        {
                            imageProcess.Coordenates.Add(new ImageProcessCoordenate
                            {
                                X = coordenate.X, // Coordenada na horizontal
                                Y = coordenate.Y  // Coordenada na vertical
                            });
                        }

                        collection.Add(imageProcess);
                    }
                }              

                return collection;
            }
            catch (AnnotateImageException e)
            {
                //AnnotateImageResponse response = e.Response;
                //return (response.Error);
                throw new FaultException(e.Response.ToString());
            }
        }

        /// <summary>
        /// A detecção da Web detecta referências da Web para uma imagem
        /// </summary>
        private object DetectWebInformation(System.IO.Stream fileStream)
        {
            try
            {
                var image    = Google.Cloud.Vision.V1.Image.FromStream(fileStream);
                var response = clienteService.DetectWebInformation(image);

                return response;
            }
            catch (AnnotateImageException e)
            {
                //AnnotateImageResponse response = e.Response;
                //return (response.Error);
                throw new FaultException(e.Response.ToString());
            }
        }

        /// <summary>
        /// Detecção de rosto detecta várias faces dentro de uma imagem, juntamente com os atributos faciais chave associados, como o estado emocional ou o uso de bones, chapeus, gorros etc. O reconhecimento facial não é suportado.
        /// </summary>
        private object DetectFaces(System.IO.Stream fileStream)
        {
            try
            {
                var image    = Google.Cloud.Vision.V1.Image.FromStream(fileStream);
                var response = clienteService.DetectFaces(image).ToList();

                // ----------------------------------------
                // somente para conhecimento
                // -----------------------------------------
                //foreach (var item in response.ToList())
                //{ 
                //    //item.AngerLikelihood;         // Probabilidade de raiva
                //    //item.BlurredLikelihood;       // Probabilidade de borrão 
                //    //item.DetectionConfidence;     // Probabilidade de confiança 
                //    //item.HeadwearLikelihood       // Probabilidade vestuario na cabeca 
                //    //item.JoyLikelihood;           // Probabilidade de alegria
                //    //item.LandmarkingConfidence;   // Probabilidade Marca de terra
                //    //item.SorrowLikelihood         
                //}

                return response;
            }
            catch (AnnotateImageException e)
            {
                //AnnotateImageResponse response = e.Response;
                //return (response.Error);
                throw new FaultException(e.Response.ToString());
            }
        }

        /// <summary>
        /// Detecta rótulos para uma única imagem, como exemplo documento, folder, impresso, ticket etc.
        /// </summary>
        public List<ImageProcessLabels> DetectLabels(System.IO.Stream fileStream)
        {
            try
            {
                var image      = Google.Cloud.Vision.V1.Image.FromStream(fileStream);
                var response   = clienteService.DetectLabels(image).ToList();
                var collection = new List<ImageProcessLabels>();

                if (response.Count > 0)
                {
                    foreach (var item in response)
                    {
                        var imageProcessLabels      = new ImageProcessLabels();
                        imageProcessLabels.Describe = item.Description;
                        imageProcessLabels.Locale   = item.Locale;

                        collection.Add(imageProcessLabels);
                    }                    
                }

                return collection;
            }
            catch (AnnotateImageException e)
            {
                //AnnotateImageResponse response = e.Response;
                //return (response.Error);
                throw new FaultException(e.Response.ToString());
            }
        }

        /// <summary>
        /// Landmark Detection detecta estruturas populares naturais e artificiais dentro de uma imagem.
        /// </summary>
        public List<ImageProcessLandMarks> DetectLandmarks(System.IO.Stream fileStream)
        {
            try
            {
                var image = Google.Cloud.Vision.V1.Image.FromStream(fileStream);
                var response = clienteService.DetectLandmarks(image).ToList();
                var collection = new List<ImageProcessLandMarks>();

                if (response.Count > 0)
                {
                    foreach (var item in response)
                    {
                        var imageProcessLandMarks = new ImageProcessLandMarks();
                        imageProcessLandMarks.Describe = item.Description;

                        foreach (var localizationLatLng in item.Locations)
                        {
                            imageProcessLandMarks.Locations = new ImageProcessLocalization()
                            {
                                latitude  = localizationLatLng.LatLng.Latitude, // Coordenadas da localizacao do local detectado na imagem.
                                longitude = localizationLatLng.LatLng.Longitude // Coordenadas da localizacao do local detectado na imagem.
                            };

                            collection.Add(imageProcessLandMarks);
                        }  
                    }
                }

                return collection;                
            }
            catch (AnnotateImageException e)
            {
                //AnnotateImageResponse response = e.Response;
                //return (response.Error);
                throw new FaultException(e.Response.ToString());
            }
        }

        /// <summary>
        /// Execute a detecção e anotação de imagens para um lote (lote) de imagens.
        /// </summary>
        private object DetectAnnotateImagesInBatch(List<System.IO.Stream> fileStreamCollection)
        {
            try
            {
                var collectionAnnotateImageRequest = new List<AnnotateImageRequest>();
                BatchAnnotateImagesResponse response = new BatchAnnotateImagesResponse();

                foreach (Stream item in fileStreamCollection)
                {
                    var image = Google.Cloud.Vision.V1.Image.FromStream(item);
                    var request = new AnnotateImageRequest
                    {
                        Image = image,
                        Features = { new Feature { Type = Feature.Types.Type.TextDetection } }
                    };

                    collectionAnnotateImageRequest.Add(request);
                }

                response = clienteService.BatchAnnotateImages(collectionAnnotateImageRequest);

                return (response);
            }
            catch (AnnotateImageException e)
            {
                //AnnotateImageResponse response = e.Response;
                //return (response.Error);
                throw new FaultException(e.Response.ToString());
            }
            //catch (AggregateException e)
            //{
            //    foreach (AnnotateImageException innerException in e.InnerExceptions)
            //    {
            //        return (innerException.Response.Error);
            //    }
            //}
        }

        /// <summary>
        /// Detecta cores dominantes em geral da imagem.
        /// </summary>
        public List<ImageProcessColor> DetectPredominantColor(System.IO.Stream fileStream) {

            try
            {
                var image = Google.Cloud.Vision.V1.Image.FromStream(fileStream);
                var response = clienteService.DetectImageProperties(image);
                var imageProcessColorCollection = new List<ImageProcessColor>();

                if ((response.DominantColors.Colors.Count > 0) || (response.DominantColors != null))
                {
                    foreach (var item in response.DominantColors.Colors)
                    {

                        var imageProcessColor = new ImageProcessColor();

                        imageProcessColor.Blue = item.Color.Blue;   //Padrao RGBA (Red,Green,Blue,Alpha) sendo que Alpha pode ser float Nullable<>.
                        imageProcessColor.Red = item.Color.Red;     //Padrao RGBA (Red,Green,Blue,Alpha) sendo que Alpha pode ser float Nullable<>.
                        imageProcessColor.Green = item.Color.Green; //Padrao RGBA (Red,Green,Blue,Alpha) sendo que Alpha pode ser float Nullable<>.
                        imageProcessColor.Alpha = item.Color.Alpha; //Padrao RGBA (Red,Green,Blue,Alpha) sendo que Alpha pode ser float Nullable<>.
                        imageProcessColor.PixelFraction = item.PixelFraction;
                        imageProcessColor.Score = item.Score;

                        imageProcessColorCollection.Add(imageProcessColor);
                    }
                }

                return (imageProcessColorCollection);
            }
            catch (AnnotateImageException e)
            {
                //AnnotateImageResponse response = e.Response;
                //return (response.Error);
                throw new FaultException(e.Response.ToString());
            }

        }

        #endregion

        /// <summary>
        /// Inicializador do objeto particular.
        /// </summary>
        internal void Initializer()
        {
            try
            {
                // Esses parametros por primeiro pois sao as credenciais de autenticacao
                // do Google.Cloud.Vision.
                this.googleCredential = ConfigurationManager.AppSettings["credential"];
                Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", this.googleCredential);

                this.output = ConfigurationManager.AppSettings["output"];
                this.clienteService = Google.Cloud.Vision.V1.ImageAnnotatorClient.Create();
            }
            catch (AnnotateImageException e)
            {
                throw new FaultException(e.Response.ToString());
            }
        }

    }
}

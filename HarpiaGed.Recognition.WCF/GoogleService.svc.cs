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

namespace HarpiaGed.Recognition.WCF
{

    /// <summary>
    /// Exemplo basico : https://cloud.google.com/vision/docs/detecting-text
    /// </summary>
    public class GoogleService : IGoogleService
    {
        internal string output { get; set; }
        internal string googleCredential { get; set; }
        internal void Initializer()
        {
            this.output = ConfigurationManager.AppSettings["output"];
            this.googleCredential = ConfigurationManager.AppSettings["credential"];
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", this.googleCredential);
        }
        public GoogleService() { Initializer(); }


        #region " Métodos que recebem stream "

        /// <summary>
        /// Document Text Detection performs Optical Character Recognition. This feature detects dense document text in an image.
        /// </summary>
        public object DetectDocumentText(System.IO.Stream fileStream)
        {
            try
            {
                var client   = Google.Cloud.Vision.V1.ImageAnnotatorClient.Create();
                var image    = Google.Cloud.Vision.V1.Image.FromStream(fileStream);
                var response = client.DetectDocumentText(image);

                return response;
            }
            catch
            {
                return (null);
            }
        }

        /// <summary>
        /// The Image Properties feature detects general attributes of the image, such as dominant color.
        /// </summary>
        public object DetectImageProperties(System.IO.Stream fileStream)
        {
            try
            {                
                var image    = Google.Cloud.Vision.V1.Image.FromStream(fileStream);
                var client   = Google.Cloud.Vision.V1.ImageAnnotatorClient.Create();
                var response = client.DetectImageProperties(image);
                return response;
            }
            catch
            {
                return (null);
            }
        }

        /// <summary>
        /// Text Detection performs Optical Character Recognition. It detects and extracts text within an image with support for a broad range of languages. It also features automatic language identification.
        /// </summary>
        public object DetectText(System.IO.Stream fileStream)
        {
            try
            {                
                var image    = Google.Cloud.Vision.V1.Image.FromStream(fileStream);
                var client   = Google.Cloud.Vision.V1.ImageAnnotatorClient.Create();
                var response = client.DetectText(image).ToList();

                return response;
            }
            catch (Exception ex)
            {
                return (ex.Message);
            }
        }

        /// <summary>
        /// Web Detection detects Web references to an image.
        /// </summary>
        public object DetectWebInformation(System.IO.Stream fileStream)
        {
            try
            {
                var image    = Google.Cloud.Vision.V1.Image.FromStream(fileStream);
                var client   = Google.Cloud.Vision.V1.ImageAnnotatorClient.Create();
                var response = client.DetectWebInformation(image);

                return response;
            }
            catch
            {
                return (null);
            }
        }

        /// <summary>
        /// Face Detection detects multiple faces within an image along with the associated key facial attributes such as emotional state or wearing headwear. Facial Recognition is not supported.
        /// </summary>
        public object DetectFaces(System.IO.Stream fileStream)
        {
            try
            {
                var image    = Google.Cloud.Vision.V1.Image.FromStream(fileStream);
                var client   = Google.Cloud.Vision.V1.ImageAnnotatorClient.Create();
                var response = client.DetectFaces(image).ToList();

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
            catch
            {
                return (null);
            }
        }

        /// <summary>
        /// Detects labels for a single image.
        /// </summary>
        public object DetectLabels(System.IO.Stream fileStream)
        {
            try
            {
                var image    = Google.Cloud.Vision.V1.Image.FromStream(fileStream);
                var client   = Google.Cloud.Vision.V1.ImageAnnotatorClient.Create();
                var response = client.DetectLabels(image).ToList();

                return response;
            }
            catch
            {
                return (null);
            }
        }
        
        /// <summary>
        /// Landmark Detection detects popular natural and man-made structures within an image.
        /// </summary>
        public object DetectLandmarks(System.IO.Stream fileStream)
        {
            try
            {
                var image = Google.Cloud.Vision.V1.Image.FromStream(fileStream);
                var client = Google.Cloud.Vision.V1.ImageAnnotatorClient.Create();
                var response = client.DetectLandmarks(image).ToList();

                return response;
            }
            catch
            {
                return (null);
            }
        }

        #endregion



    }
}

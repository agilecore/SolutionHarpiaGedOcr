using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Http;
using Google.Apis.Services;
using Google.Cloud.Vision.V1;
using Google.Apis.Json;

namespace HarpiaGed.Recognition
{
    public class OcrGoogle
    {
        internal string output { get; set; }
        internal string googleCredential { get; set; }
        internal void Initializer()
        {
            this.output = ConfigurationManager.AppSettings["output"];
            this.googleCredential = ConfigurationManager.AppSettings["credential"];
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", this.googleCredential);
        }
        public OcrGoogle(string fileToRecognize)
        {
            Initializer();
        }

        internal TextAnnotation DetectDocumentText(string fileToRecognize)
        {
            var client   = ImageAnnotatorClient.Create();
            var image    = Google.Cloud.Vision.V1.Image.FromFile(fileToRecognize);
            var response = client.DetectDocumentText(image);

            return (response);
        }

        internal ImageProperties DetectImageProperties(string fileToRecognize)
        {
            var client = ImageAnnotatorClient.Create();
            var image = Google.Cloud.Vision.V1.Image.FromFile(fileToRecognize);
            var response = client.DetectImageProperties(image);

            return (response);
        }

        internal List<EntityAnnotation> DetectText(string fileToRecognize)
        {
            var client = ImageAnnotatorClient.Create();
            var image = Google.Cloud.Vision.V1.Image.FromFile(fileToRecognize);
            var response = client.DetectText(image).ToList();

            return (response);
        }

        internal WebDetection WebDetectionSingleImage(string fileToRecognize)
        {
            var client = ImageAnnotatorClient.Create();
            var image = Google.Cloud.Vision.V1.Image.FromFile(fileToRecognize);
            var response = client.DetectWebInformation(image);

            return (response);
        }


    }



















}

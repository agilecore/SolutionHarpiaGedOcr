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
    public class OcrGoogle {
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
        public TextAnnotation DetectDocumentText(string fileToRecognize)
        {
            try
            {
                var client = ImageAnnotatorClient.Create();
                var image = Google.Cloud.Vision.V1.Image.FromFile(fileToRecognize);
                var response = client.DetectDocumentText(image);
                return response;
            }
            catch (Exception ex)
            {
                return (null);
            }
        }
        public ImageProperties DetectImageProperties(string fileToRecognize)
        {
            try
            {
                var client = ImageAnnotatorClient.Create();
                var image = Google.Cloud.Vision.V1.Image.FromFile(fileToRecognize);
                var response = client.DetectImageProperties(image);
                return response;
            }
            catch
            {
                return (null);
            }
        }
        public List<EntityAnnotation> DetectText(string fileToRecognize)
        {
            try
            {
                var client = ImageAnnotatorClient.Create();
                var image = Google.Cloud.Vision.V1.Image.FromFile(fileToRecognize);
                var response = client.DetectText(image).ToList();
                return response;
            }
            catch
            {
                return (null);
            }
        }
        public WebDetection WebDetectionSingleImage(string fileToRecognize)
        {
            try
            {
                var client = ImageAnnotatorClient.Create();
                var image = Google.Cloud.Vision.V1.Image.FromFile(fileToRecognize);
                var response = client.DetectWebInformation(image);
                return response;
            }
            catch
            {
                return (null);
            }            
        }
        public List<FaceAnnotation> DetectFaces(string fileToRecognize)
        {
            try
            {
                var client = ImageAnnotatorClient.Create();
                var image = Google.Cloud.Vision.V1.Image.FromFile(fileToRecognize);
                var response = client.DetectFaces(image).ToList();
                return response;
            }
            catch
            {
                return (null);
            }
        }
    }



















}

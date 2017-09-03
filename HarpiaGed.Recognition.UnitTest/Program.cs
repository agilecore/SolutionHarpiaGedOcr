using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarpiaGed.Recognition.Estructure;
using System.Threading;
using System.Diagnostics;

namespace HarpiaGed.Recognition.UnitTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            WriteHeader();
            Inicialize();
            ReadFromConsole();
        }

        static void Inicialize()
        {
            //CarregaImage01();
            //CarregaImage02();
            //CarregaImage03();
            //CarregaImage04();
            //CarregaImage05();
            //CarregaImage06();
            //CarregaImage07();
            //CarregaImage08();
            //CarregaImage09();
            //CarregaImage10();
            ChamaServico();
        }

        static void CarregaImage01()
        {
            WriteToConsole(String.Empty);
            WriteToConsole("-----------------------------------------------------------------------------");
            WriteToConsole("Image 1 ");
            WriteToConsole("-----------------------------------------------------------------------------");
            
            var diretoryImage = @"C:\Users\rodrigo.fernandes\Documents\GitHub\SolutionHarpiaGedOcr\HarpiaGed.Recognition.UnitTest\Upload\1.jpg";
            var infoImage = new InfoImage(diretoryImage)._imageAnnotation;

            WriteToConsole("Aspect Rate:..................... " + infoImage.AspectRadio.ToString());
            WriteToConsole("Ponto por Polegada (DpiX):....... " + infoImage.DpiX.ToString());
            WriteToConsole("Ponto por Polegada (DpiY):....... " + infoImage.DpiY.ToString());
            WriteToConsole("Largura:......................... " + infoImage.Width + "px");
            WriteToConsole("Altura:.......................... " + infoImage.Height + "px");
            WriteToConsole("Formato de Pixel:................ " + infoImage.PixelFormatType);
            WriteToConsole("Formato de Image:................ " + infoImage.ImageFormat);
            WriteToConsole("Tamanho:......................... " + infoImage.Size);
            WriteToConsole("Largura Física:.................. " + infoImage.PhisicalDimensionWidth);
            WriteToConsole("Altura Física:................... " + infoImage.PhisicalDimensionHeight);
            WriteToConsole("Horizondal Resolution:........... " + infoImage.HorizondalResolution);
            WriteToConsole("Vertical Resolution:............. " + infoImage.VeritcalResolution);
            WriteToConsole("Modo Interpolacao:............... " + infoImage.Interpolacao);
            WriteToConsole("Megapixel:....................... " + infoImage.Megapixel);

        }

        static void CarregaImage02()
        {
            WriteToConsole(String.Empty);
            WriteToConsole("-----------------------------------------------------------------------------");
            WriteToConsole("Image 2 ");
            WriteToConsole("-----------------------------------------------------------------------------");

            var diretoryImage = @"C:\Users\rodrigo.fernandes\Documents\GitHub\SolutionHarpiaGedOcr\HarpiaGed.Recognition.UnitTest\Upload\2.jpg";
            var infoImage = new InfoImage(diretoryImage)._imageAnnotation;

            WriteToConsole("Aspect Rate:..................... " + infoImage.AspectRadio.ToString());
            WriteToConsole("Ponto por Polegada (DpiX):....... " + infoImage.DpiX.ToString());
            WriteToConsole("Ponto por Polegada (DpiY):....... " + infoImage.DpiY.ToString());
            WriteToConsole("Largura:......................... " + infoImage.Width + "px");
            WriteToConsole("Altura:.......................... " + infoImage.Height + "px");
            WriteToConsole("Formato de Pixel:................ " + infoImage.PixelFormatType);
            WriteToConsole("Formato de Image:................ " + infoImage.ImageFormat);
            WriteToConsole("Tamanho:......................... " + infoImage.Size);
            WriteToConsole("Largura Física:.................. " + infoImage.PhisicalDimensionWidth);
            WriteToConsole("Altura Física:................... " + infoImage.PhisicalDimensionHeight);
            WriteToConsole("Horizondal Resolution:........... " + infoImage.HorizondalResolution);
            WriteToConsole("Vertical Resolution:............. " + infoImage.VeritcalResolution);
            WriteToConsole("Modo Interpolacao:............... " + infoImage.Interpolacao);
            WriteToConsole("Megapixel:....................... " + infoImage.Megapixel);

        }

        static void CarregaImage03()
        {
            WriteToConsole(String.Empty);
            WriteToConsole("-----------------------------------------------------------------------------");
            WriteToConsole("Image 3 ");
            WriteToConsole("-----------------------------------------------------------------------------");
            
            var diretoryImage = @"C:\Users\rodrigo.fernandes\Documents\GitHub\SolutionHarpiaGedOcr\HarpiaGed.Recognition.UnitTest\Upload\3.jpg";
            var infoImage = new InfoImage(diretoryImage)._imageAnnotation;

            WriteToConsole("Aspect Rate:..................... " + infoImage.AspectRadio.ToString());
            WriteToConsole("Ponto por Polegada (DpiX):....... " + infoImage.DpiX.ToString());
            WriteToConsole("Ponto por Polegada (DpiY):....... " + infoImage.DpiY.ToString());
            WriteToConsole("Largura:......................... " + infoImage.Width + "px");
            WriteToConsole("Altura:.......................... " + infoImage.Height + "px");
            WriteToConsole("Formato de Pixel:................ " + infoImage.PixelFormatType);
            WriteToConsole("Formato de Image:................ " + infoImage.ImageFormat);
            WriteToConsole("Tamanho:......................... " + infoImage.Size);
            WriteToConsole("Largura Física:.................. " + infoImage.PhisicalDimensionWidth);
            WriteToConsole("Altura Física:................... " + infoImage.PhisicalDimensionHeight);
            WriteToConsole("Horizondal Resolution:........... " + infoImage.HorizondalResolution);
            WriteToConsole("Vertical Resolution:............. " + infoImage.VeritcalResolution);
            WriteToConsole("Modo Interpolacao:............... " + infoImage.Interpolacao);
            WriteToConsole("Megapixel:....................... " + infoImage.Megapixel);

        }

        static void CarregaImage04()
        {
            WriteToConsole(String.Empty);
            WriteToConsole("-----------------------------------------------------------------------------");
            WriteToConsole("Image 4 ");
            WriteToConsole("-----------------------------------------------------------------------------");

            var diretoryImage = @"C:\Users\rodrigo.fernandes\Documents\GitHub\SolutionHarpiaGedOcr\HarpiaGed.Recognition.UnitTest\Upload\4.jpg";
            var infoImage = new InfoImage(diretoryImage)._imageAnnotation;

            WriteToConsole("Aspect Rate:..................... " + infoImage.AspectRadio.ToString());
            WriteToConsole("Ponto por Polegada (DpiX):....... " + infoImage.DpiX.ToString());
            WriteToConsole("Ponto por Polegada (DpiY):....... " + infoImage.DpiY.ToString());
            WriteToConsole("Largura:......................... " + infoImage.Width + "px");
            WriteToConsole("Altura:.......................... " + infoImage.Height + "px");
            WriteToConsole("Formato de Pixel:................ " + infoImage.PixelFormatType);
            WriteToConsole("Formato de Image:................ " + infoImage.ImageFormat);
            WriteToConsole("Tamanho:......................... " + infoImage.Size);
            WriteToConsole("Largura Física:.................. " + infoImage.PhisicalDimensionWidth);
            WriteToConsole("Altura Física:................... " + infoImage.PhisicalDimensionHeight);
            WriteToConsole("Horizondal Resolution:........... " + infoImage.HorizondalResolution);
            WriteToConsole("Vertical Resolution:............. " + infoImage.VeritcalResolution);
            WriteToConsole("Modo Interpolacao:............... " + infoImage.Interpolacao);
            WriteToConsole("Megapixel:....................... " + infoImage.Megapixel);

        }

        static void CarregaImage05()
        {
            WriteToConsole(String.Empty);
            WriteToConsole("-----------------------------------------------------------------------------");
            WriteToConsole("Image 5 ");
            WriteToConsole("-----------------------------------------------------------------------------");

            var diretoryImage = @"C:\Users\rodrigo.fernandes\Documents\GitHub\SolutionHarpiaGedOcr\HarpiaGed.Recognition.UnitTest\Upload\5.jpg";
            var infoImage = new InfoImage(diretoryImage)._imageAnnotation;

            WriteToConsole("Aspect Rate:..................... " + infoImage.AspectRadio.ToString());
            WriteToConsole("Ponto por Polegada (DpiX):....... " + infoImage.DpiX.ToString());
            WriteToConsole("Ponto por Polegada (DpiY):....... " + infoImage.DpiY.ToString());
            WriteToConsole("Largura:......................... " + infoImage.Width + "px");
            WriteToConsole("Altura:.......................... " + infoImage.Height + "px");
            WriteToConsole("Formato de Pixel:................ " + infoImage.PixelFormatType);
            WriteToConsole("Formato de Image:................ " + infoImage.ImageFormat);
            WriteToConsole("Tamanho:......................... " + infoImage.Size);
            WriteToConsole("Largura Física:.................. " + infoImage.PhisicalDimensionWidth);
            WriteToConsole("Altura Física:................... " + infoImage.PhisicalDimensionHeight);
            WriteToConsole("Horizondal Resolution:........... " + infoImage.HorizondalResolution);
            WriteToConsole("Vertical Resolution:............. " + infoImage.VeritcalResolution);
            WriteToConsole("Modo Interpolacao:............... " + infoImage.Interpolacao);
            WriteToConsole("Megapixel:....................... " + infoImage.Megapixel);
        }

        static void CarregaImage06()
        {
            WriteToConsole(String.Empty);
            WriteToConsole("-----------------------------------------------------------------------------");
            WriteToConsole("Image 6 ");
            WriteToConsole("-----------------------------------------------------------------------------");

            var diretoryImage = @"C:\Users\rodrigo.fernandes\Documents\GitHub\SolutionHarpiaGedOcr\HarpiaGed.Recognition.UnitTest\Upload\6.jpg";
            var infoImage = new InfoImage(diretoryImage)._imageAnnotation;

            WriteToConsole("Aspect Rate:..................... " + infoImage.AspectRadio.ToString());
            WriteToConsole("Ponto por Polegada (DpiX):....... " + infoImage.DpiX.ToString());
            WriteToConsole("Ponto por Polegada (DpiY):....... " + infoImage.DpiY.ToString());
            WriteToConsole("Largura:......................... " + infoImage.Width + "px");
            WriteToConsole("Altura:.......................... " + infoImage.Height + "px");
            WriteToConsole("Formato de Pixel:................ " + infoImage.PixelFormatType);
            WriteToConsole("Formato de Image:................ " + infoImage.ImageFormat);
            WriteToConsole("Tamanho:......................... " + infoImage.Size);
            WriteToConsole("Largura Física:.................. " + infoImage.PhisicalDimensionWidth);
            WriteToConsole("Altura Física:................... " + infoImage.PhisicalDimensionHeight);
            WriteToConsole("Horizondal Resolution:........... " + infoImage.HorizondalResolution);
            WriteToConsole("Vertical Resolution:............. " + infoImage.VeritcalResolution);
            WriteToConsole("Modo Interpolacao:............... " + infoImage.Interpolacao);
            WriteToConsole("Megapixel:....................... " + infoImage.Megapixel);

        }

        static void CarregaImage07()
        {
            WriteToConsole(String.Empty);
            WriteToConsole("-----------------------------------------------------------------------------");
            WriteToConsole("Image 7 ");
            WriteToConsole("-----------------------------------------------------------------------------");

            var diretoryImage = @"C:\Users\rodrigo.fernandes\Documents\GitHub\SolutionHarpiaGedOcr\HarpiaGed.Recognition.UnitTest\Upload\7.jpg";
            var infoImage = new InfoImage(diretoryImage)._imageAnnotation;

            WriteToConsole("Aspect Rate:..................... " + infoImage.AspectRadio.ToString());
            WriteToConsole("Ponto por Polegada (DpiX):....... " + infoImage.DpiX.ToString());
            WriteToConsole("Ponto por Polegada (DpiY):....... " + infoImage.DpiY.ToString());
            WriteToConsole("Largura:......................... " + infoImage.Width + "px");
            WriteToConsole("Altura:.......................... " + infoImage.Height + "px");
            WriteToConsole("Formato de Pixel:................ " + infoImage.PixelFormatType);
            WriteToConsole("Formato de Image:................ " + infoImage.ImageFormat);
            WriteToConsole("Tamanho:......................... " + infoImage.Size);
            WriteToConsole("Largura Física:.................. " + infoImage.PhisicalDimensionWidth);
            WriteToConsole("Altura Física:................... " + infoImage.PhisicalDimensionHeight);
            WriteToConsole("Horizondal Resolution:........... " + infoImage.HorizondalResolution);
            WriteToConsole("Vertical Resolution:............. " + infoImage.VeritcalResolution);
            WriteToConsole("Modo Interpolacao:............... " + infoImage.Interpolacao);
            WriteToConsole("Megapixel:....................... " + infoImage.Megapixel);

        }
        
        static void CarregaImage08()
        {
            WriteToConsole(String.Empty);
            WriteToConsole("-----------------------------------------------------------------------------");
            WriteToConsole("Image 8 ");
            WriteToConsole("-----------------------------------------------------------------------------");

            var diretoryImage = @"C:\Users\rodrigo.fernandes\Documents\GitHub\SolutionHarpiaGedOcr\HarpiaGed.Recognition.UnitTest\Upload\8.jpg";
            var infoImage = new InfoImage(diretoryImage)._imageAnnotation;

            WriteToConsole("Aspect Rate:..................... " + infoImage.AspectRadio.ToString());
            WriteToConsole("Ponto por Polegada (DpiX):....... " + infoImage.DpiX.ToString());
            WriteToConsole("Ponto por Polegada (DpiY):....... " + infoImage.DpiY.ToString());
            WriteToConsole("Largura:......................... " + infoImage.Width + "px");
            WriteToConsole("Altura:.......................... " + infoImage.Height + "px");
            WriteToConsole("Formato de Pixel:................ " + infoImage.PixelFormatType);
            WriteToConsole("Formato de Image:................ " + infoImage.ImageFormat);
            WriteToConsole("Tamanho:......................... " + infoImage.Size);
            WriteToConsole("Largura Física:.................. " + infoImage.PhisicalDimensionWidth);
            WriteToConsole("Altura Física:................... " + infoImage.PhisicalDimensionHeight);
            WriteToConsole("Horizondal Resolution:........... " + infoImage.HorizondalResolution);
            WriteToConsole("Vertical Resolution:............. " + infoImage.VeritcalResolution);
            WriteToConsole("Modo Interpolacao:............... " + infoImage.Interpolacao);
            WriteToConsole("Megapixel:....................... " + infoImage.Megapixel);

        }

        static void CarregaImage09()
        {
            WriteToConsole(String.Empty);
            WriteToConsole("-----------------------------------------------------------------------------");
            WriteToConsole("Image 9 ");
            WriteToConsole("-----------------------------------------------------------------------------");

            var diretoryImage = @"C:\Users\rodrigo.fernandes\Documents\GitHub\SolutionHarpiaGedOcr\HarpiaGed.Recognition.UnitTest\Upload\9.jpg";
            var infoImage = new InfoImage(diretoryImage)._imageAnnotation;

            WriteToConsole("Aspect Rate:..................... " + infoImage.AspectRadio.ToString());
            WriteToConsole("Ponto por Polegada (DpiX):....... " + infoImage.DpiX.ToString());
            WriteToConsole("Ponto por Polegada (DpiY):....... " + infoImage.DpiY.ToString());
            WriteToConsole("Largura:......................... " + infoImage.Width + "px");
            WriteToConsole("Altura:.......................... " + infoImage.Height + "px");
            WriteToConsole("Formato de Pixel:................ " + infoImage.PixelFormatType);
            WriteToConsole("Formato de Image:................ " + infoImage.ImageFormat);
            WriteToConsole("Tamanho:......................... " + infoImage.Size);
            WriteToConsole("Largura Física:.................. " + infoImage.PhisicalDimensionWidth);
            WriteToConsole("Altura Física:................... " + infoImage.PhisicalDimensionHeight);
            WriteToConsole("Horizondal Resolution:........... " + infoImage.HorizondalResolution);
            WriteToConsole("Vertical Resolution:............. " + infoImage.VeritcalResolution);
            WriteToConsole("Modo Interpolacao:............... " + infoImage.Interpolacao);
            WriteToConsole("Megapixel:....................... " + infoImage.Megapixel);

        }

        static void CarregaImage10()
        {
            WriteToConsole(String.Empty);
            WriteToConsole("-----------------------------------------------------------------------------");
            WriteToConsole("Image 10 ");
            WriteToConsole("-----------------------------------------------------------------------------");

            var diretoryImage = @"C:\Users\rodrigo.fernandes\Documents\GitHub\SolutionHarpiaGedOcr\HarpiaGed.Recognition.UnitTest\Upload\10.jpg";
            var infoImage = new InfoImage(diretoryImage)._imageAnnotation;

            WriteToConsole("Aspect Rate:..................... " + infoImage.AspectRadio.ToString());
            WriteToConsole("Ponto por Polegada (DpiX):....... " + infoImage.DpiX.ToString());
            WriteToConsole("Ponto por Polegada (DpiY):....... " + infoImage.DpiY.ToString());
            WriteToConsole("Largura:......................... " + infoImage.Width + "px");
            WriteToConsole("Altura:.......................... " + infoImage.Height + "px");
            WriteToConsole("Formato de Pixel:................ " + infoImage.PixelFormatType);
            WriteToConsole("Formato de Image:................ " + infoImage.ImageFormat);
            WriteToConsole("Tamanho:......................... " + infoImage.Size);
            WriteToConsole("Largura Física:.................. " + infoImage.PhisicalDimensionWidth);
            WriteToConsole("Altura Física:................... " + infoImage.PhisicalDimensionHeight);
            WriteToConsole("Horizondal Resolution:........... " + infoImage.HorizondalResolution);
            WriteToConsole("Vertical Resolution:............. " + infoImage.VeritcalResolution);
            WriteToConsole("Modo Interpolacao:............... " + infoImage.Interpolacao);
            WriteToConsole("Megapixel:....................... " + infoImage.Megapixel);

        }


        /// <summary>
        /// Chamada do Google
        /// </summary>
        static async void ChamaServico()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            WriteToConsole(String.Empty);
            WriteToConsole("-----------------------------------------------------------------------------");
            WriteToConsole("Chamada do servico google.clound.vision.v1");
            WriteToConsole("-----------------------------------------------------------------------------");

            //var diretoryImage = @"C:\Users\rodrigo.fernandes\Documents\GitHub\SolutionHarpiaGedOcr\HarpiaGed.Recognition.UnitTest\Upload\1.jpg";
            //var diretoryImage = @"C:\Users\rodrigo.fernandes\Documents\GitHub\SolutionHarpiaGedOcr\HarpiaGed.Recognition.UnitTest\Upload\2.jpg";
            //var diretoryImage = @"C:\Users\rodrigo.fernandes\Documents\GitHub\SolutionHarpiaGedOcr\HarpiaGed.Recognition.UnitTest\Upload\3.jpg";
            //var diretoryImage = @"C:\Users\rodrigo.fernandes\Documents\GitHub\SolutionHarpiaGedOcr\HarpiaGed.Recognition.UnitTest\Upload\4.jpg";
            var diretoryImage = @"C:\Users\rodrigo.fernandes\Documents\GitHub\SolutionHarpiaGedOcr\HarpiaGed.Recognition.UnitTest\Upload\5.jpg";
            //var diretoryImage = @"C:\Users\rodrigo.fernandes\Documents\GitHub\SolutionHarpiaGedOcr\HarpiaGed.Recognition.UnitTest\Upload\6.jpg";
            //var diretoryImage = @"C:\Users\rodrigo.fernandes\Documents\GitHub\SolutionHarpiaGedOcr\HarpiaGed.Recognition.UnitTest\Upload\7.jpg";
            //var diretoryImage = @"C:\Users\rodrigo.fernandes\Documents\GitHub\SolutionHarpiaGedOcr\HarpiaGed.Recognition.UnitTest\Upload\8.jpg";
            //var diretoryImage = @"C:\Users\rodrigo.fernandes\Documents\GitHub\SolutionHarpiaGedOcr\HarpiaGed.Recognition.UnitTest\Upload\9.jpg";
            //var diretoryImage = @"C:\Users\rodrigo.fernandes\Documents\GitHub\SolutionHarpiaGedOcr\HarpiaGed.Recognition.UnitTest\Upload\10.jpg";

            var image = Common.GetImage(diretoryImage);

            HarpiaGed.Recognition.WCF.GoogleService client = new HarpiaGed.Recognition.WCF.GoogleService();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            var ret = (IEnumerable<object>)client.DetectText(Common.GetStream(diretoryImage));

            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var item in ret)
            {
                WriteToConsole(item.ToString());
            }

            stopwatch.Stop();

            Console.ForegroundColor = ConsoleColor.Yellow;
            WriteToConsole(String.Format("Tempo decorrido: Minutos:{0}, Segundos:{1}, Milésimos:{2}", stopwatch.Elapsed.Minutes, stopwatch.Elapsed.Seconds, stopwatch.Elapsed.Milliseconds));

        }

        #region Métodos do shellprompt

        private static void TimeSleep(int Milliseconds)
        {
            var StopWatch = Stopwatch.StartNew();
            Thread.Sleep(Milliseconds);
            StopWatch.Stop();
        }

        private static void WriteHeader()
        {
            Console.Title = typeof(Program).Name;
            Console.ForegroundColor = ConsoleColor.Green;

            var ConsoleCopyRight = new StringBuilder();

            Console.WriteLine("#***********************************************************");
            Console.WriteLine("# Obtem dados de imagem.                                    ");
            Console.WriteLine("#***********************************************************");

            WriteToConsole(ConsoleCopyRight.ToString());
        }

        private static ConsoleKeyInfo ReadKeyPress()
        {
            return (Console.ReadKey());
        }

        private static string ReadFromConsole()
        {
            return (Console.ReadLine());
        }

        private static void WriteToConsole(string message)
        {
            if (message.Length > 0)
            {
                Console.WriteLine("prompt: " + message);
            }
        }

        private static void WriteEnterLine()
        {
            Console.WriteLine(String.Empty);
            Console.ReadLine();
        }

        private static string Execute(string command)
        {
            return string.Format("Comando {0} executado.", command);
        }

        #endregion

    }
}

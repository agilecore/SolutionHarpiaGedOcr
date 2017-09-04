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
            //buildInformation();
            ChamaServico();
        }

        internal static void buildInformation()
        {
            var collectionFiles = new List<String>();

            collectionFiles.Add(@"C:\Users\rodrigo.fernandes\Documents\GitHub\SolutionHarpiaGedOcr\HarpiaGed.Recognition.UnitTest\Upload\1.jpg" );
            collectionFiles.Add(@"C:\Users\rodrigo.fernandes\Documents\GitHub\SolutionHarpiaGedOcr\HarpiaGed.Recognition.UnitTest\Upload\2.jpg" );
            collectionFiles.Add(@"C:\Users\rodrigo.fernandes\Documents\GitHub\SolutionHarpiaGedOcr\HarpiaGed.Recognition.UnitTest\Upload\3.jpg" );
            collectionFiles.Add(@"C:\Users\rodrigo.fernandes\Documents\GitHub\SolutionHarpiaGedOcr\HarpiaGed.Recognition.UnitTest\Upload\4.jpg" );
            collectionFiles.Add(@"C:\Users\rodrigo.fernandes\Documents\GitHub\SolutionHarpiaGedOcr\HarpiaGed.Recognition.UnitTest\Upload\5.jpg" );
            collectionFiles.Add(@"C:\Users\rodrigo.fernandes\Documents\GitHub\SolutionHarpiaGedOcr\HarpiaGed.Recognition.UnitTest\Upload\6.jpg" );
            collectionFiles.Add(@"C:\Users\rodrigo.fernandes\Documents\GitHub\SolutionHarpiaGedOcr\HarpiaGed.Recognition.UnitTest\Upload\7.jpg" );
            collectionFiles.Add(@"C:\Users\rodrigo.fernandes\Documents\GitHub\SolutionHarpiaGedOcr\HarpiaGed.Recognition.UnitTest\Upload\8.jpg" );
            collectionFiles.Add(@"C:\Users\rodrigo.fernandes\Documents\GitHub\SolutionHarpiaGedOcr\HarpiaGed.Recognition.UnitTest\Upload\9.jpg" );
            collectionFiles.Add(@"C:\Users\rodrigo.fernandes\Documents\GitHub\SolutionHarpiaGedOcr\HarpiaGed.Recognition.UnitTest\Upload\10.jpg");

            var count = 1;

            foreach (string item in collectionFiles)
            {
                WriteToConsole("-----------------------------------------------------------------------------");
                WriteToConsole("-- Image " + count);
                WriteToConsole("-----------------------------------------------------------------------------");

                WriteInScreen(item);

                count += 1;
            }

        }

        static void WriteInScreen(string diretoryImage)
        {
            var imageDto = new InfoImage(diretoryImage)._imageAnnotation;
            WriteToConsole("Largura......................................" + imageDto.Width);
            WriteToConsole("Altura......................................." + imageDto.Height);
            WriteToConsole("DpiX(Dots per InchsX)........................" + imageDto.HorizontalResolutionDpiX);
            WriteToConsole("DpiY(Dots per InchsY)........................" + imageDto.VerticalResolutionDpiY);
            WriteToConsole("PpiX(Pixel per InchsX)......................." + imageDto.HorizontalResolutionPpiX);
            WriteToConsole("PpiY(Pixel per InchsY)......................." + imageDto.VerticalResolutionPpiY);
            WriteToConsole("PixelFormat.................................." + imageDto.PixelFormat);
            WriteToConsole("Extension...................................." + imageDto.Extension);
            WriteToConsole("Megapixel...................................." + imageDto.Megapixel);
            WriteToConsole("FileSize....................................." + imageDto.FileSize);
            WriteToConsole("Interpolacao................................." + imageDto.Interpolacao);
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

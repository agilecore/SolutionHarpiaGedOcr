using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Tesseract;

namespace HarpiaGed.Recognition
{
    public class OcrTesseract
    {
        internal string language {get;set;}
        internal string tessdata { get; set; }
        internal string output { get; set; }
        public string annotation { get; set; }
        public string versionEngine { get; set; }

        internal void Initializer()
        {
            this.language = ConfigurationManager.AppSettings["language"];
            this.tessdata = ConfigurationManager.AppSettings["tessdata"];
            this.output = ConfigurationManager.AppSettings["output"];
        }

        public OcrTesseract(string fileToRecognize)
        {
            Initializer();
            DetectText(fileToRecognize);
        }

        public void DetectText(string fileToRecognize)
        {
            var findText = string.Empty;

            try
            {
                var bitmap = Common.GetBitmap(fileToRecognize);

                using (var engine = new TesseractEngine(tessdata, language, EngineMode.TesseractAndCube))
                {
                    versionEngine = engine.Version;
                   
                    using (Pix img = PixConverter.ToPix(bitmap))
                    {
                        using (Page page = engine.Process(img))
                        {                            
                            findText = page.GetText();
                        }
                    }
                }                
            }
            catch (Exception ex)
            {
                findText = ex.Message;
            }

            this.annotation = findText;
        }      



        //internal void DetectTextInterator(string fileToRecognize)
        //{
        //    using (var engine = new TesseractEngine(tessdata, language, EngineMode.TesseractAndCube))
        //    {
        //        using (var img = Pix.LoadFromFile(fileToRecognize))
        //        {
        //            using (var page = engine.Process(img))
        //            {
        //                var text = page.GetText();

        //                //Console.WriteLine("Mean confidence: {0}", page.GetMeanConfidence());
        //                //Console.WriteLine("Text (GetText): \r\n{0}", text);
        //                //Console.WriteLine("Text (iterator):");

        //                using (var iter = page.GetIterator())
        //                {
        //                    iter.Begin();

        //                    do
        //                    {
        //                        do
        //                        {
        //                            do
        //                            {
        //                                do
        //                                {
        //                                    if (iter.IsAtBeginningOf(PageIteratorLevel.Block))
        //                                    {
        //                                        Console.WriteLine("<BLOCK>");
        //                                    }

        //                                    Console.Write(iter.GetText(PageIteratorLevel.Word));
        //                                    Console.Write(" ");

        //                                    if (iter.IsAtFinalOf(PageIteratorLevel.TextLine, PageIteratorLevel.Word))
        //                                    {
        //                                        Console.WriteLine();
        //                                    }
        //                                } while (iter.Next(PageIteratorLevel.TextLine, PageIteratorLevel.Word));

        //                                if (iter.IsAtFinalOf(PageIteratorLevel.Para, PageIteratorLevel.TextLine))
        //                                {
        //                                    Console.WriteLine();
        //                                }
        //                            } while (iter.Next(PageIteratorLevel.Para, PageIteratorLevel.TextLine));
        //                        } while (iter.Next(PageIteratorLevel.Block, PageIteratorLevel.Para));
        //                    } while (iter.Next(PageIteratorLevel.Block));
        //                }
        //            }
        //        }
        //    }
        //}






















    }
}

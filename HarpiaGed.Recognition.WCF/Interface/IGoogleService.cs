using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using Google.Cloud.Vision.V1;

namespace HarpiaGed.Recognition.WCF.Interface
{
    [ServiceContract]
    public interface IGoogleService
    {
        [OperationContract]
        List<ImageProcessPage> DetectDocumentText(System.IO.Stream fileStream);

        //[OperationContract]
        //object DetectImageProperties(System.IO.Stream fileStream);

        [OperationContract]
        List<ImageProcess> DetectText(System.IO.Stream fileStream);

        //[OperationContract]
        //object DetectWebInformation(System.IO.Stream fileStream);

        //[OperationContract]
        //object DetectFaces(System.IO.Stream fileStream);

        [OperationContract]
        List<ImageProcessLabels> DetectLabels(System.IO.Stream fileStream);

        [OperationContract]
        List<ImageProcessLandMarks> DetectLandmarks(System.IO.Stream fileStream);

    }
}

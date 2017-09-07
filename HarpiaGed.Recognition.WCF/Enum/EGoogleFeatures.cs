using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HarpiaGed.Recognition.WCF
{
    public enum EGoogleImageFeatures
    {
        TYPE_UNSPECIFIED,         // -> Unspecified feature type.
        FACE_DETECTION,           // -> Run face detection.
        LANDMARK_DETECTION,       // -> Run landmark detection.
        LOGO_DETECTION,           // -> Run logo detection.
        LABEL_DETECTION,          // -> Run label detection.
        TEXT_DETECTION,           // -> Run OCR.
        DOCUMENT_TEXT_DETECTION,  // -> Run dense text document OCR. Takes precedence when both DOCUMENT_TEXT_DETECTION and TEXT_DETECTION are present.
        SAFE_SEARCH_DETECTION,    // -> Run computer vision models to compute image safe-search properties.
        IMAGE_PROPERTIES,         // -> Compute a set of image properties, such as the image's dominant colors.
        CROP_HINTS,               // -> Run crop hints.
        WEB_DETECTION             // -> Run web detection.
    }
}
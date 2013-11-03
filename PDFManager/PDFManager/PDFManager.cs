using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.util;

namespace PDF2Text.PDFCommon
{
    public class PDFManager
    {
        public string GetPDFText(string filename)
        {
            PDDocument pdoc = PDDocument.load(filename);
            PDFTextStripper txtStripper = new PDFTextStripper();
            string text = txtStripper.getText(pdoc);
            pdoc.close();

            return text;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Spire.Pdf;
using Spire.Pdf.Graphics;
using Spire.Pdf.Security;
using System.Drawing;

using WavContact.Models;
using WavContact.DB;

namespace WavContact.Signature
{
    public class WavSign
    {
        public static bool SignerDocument(User u, WavFile file, Project p, string pathToCertificate, string password)
        {
            try
            {

                string path = file.LocalPath;

                PdfDocument doc = new PdfDocument(path);
                PdfPageBase page = doc.Pages[0];

                PdfCertificate cert = new PdfCertificate(pathToCertificate, password);

                PdfSignature signature = new PdfSignature(doc, page, cert, file.Name+u.Last_name);

                RectangleF rectangleF = new RectangleF(10, 10, 300, 110);
                signature.Bounds = rectangleF;
                signature.Certificated = true;

                signature.GraphicsMode = GraphicMode.SignImageAndSignDetail;


                signature.NameLabel = "Signer: ";
                signature.Name = u.First_name + " " + u.Last_name;
                signature.DateLabel = "Date: ";
                signature.Date = DateTime.Now;
                signature.ReasonLabel = "Reason: ";
                signature.Reason = "ACCEPTED";

                signature.SignImageSource = PdfImage.FromImage(Properties.Resources.ok);


                signature.SignDetailsFont = new PdfTrueTypeFont(new Font("Arial Unicode MS", 12f, FontStyle.Regular));

                signature.DocumentPermissions = PdfCertificationFlags.ForbidChanges;

                string newFile = file.LocalPath.Replace(file.Name, "");
                newFile += file.Name.Split(".")[0] + "_signed.pdf";
                
                doc.SaveToFile(newFile);

                doc.Close();

                WavFTP.UploadFile(newFile, p);
                WavActivity.AjoutActiviteCustom(u, p, "Signature du document :" + file.Name);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
            

        }
    }
}

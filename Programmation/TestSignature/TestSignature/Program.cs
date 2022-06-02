using Spire.Pdf;
using Spire.Pdf.Graphics;
using Spire.Pdf.Security;
using System.Drawing;

PdfDocument doc = new PdfDocument("test.pdf");
PdfPageBase page = doc.Pages[0];

PdfCertificate cert = new PdfCertificate("certificate.pfx", "target");

PdfSignature signature = new PdfSignature(doc, page, cert, "demo");

RectangleF rectangleF = new RectangleF(10,10,300, 110);
signature.Bounds = rectangleF;
signature.Certificated = true;

signature.GraphicsMode = GraphicMode.SignImageAndSignDetail;


signature.NameLabel = "Signer: ";
signature.Name = "Constantin";
signature.DateLabel = "Date: ";
signature.Date = DateTime.Now;
signature.ReasonLabel = "Reason: ";
signature.Reason = "ACCEPTED";

signature.SignImageSource = PdfImage.FromFile("ok.png");


signature.SignDetailsFont = new PdfTrueTypeFont(new Font("Arial Unicode MS", 12f, FontStyle.Regular));

signature.DocumentPermissions = PdfCertificationFlags.ForbidChanges;

doc.SaveToFile("Result.pdf");

doc.Close();

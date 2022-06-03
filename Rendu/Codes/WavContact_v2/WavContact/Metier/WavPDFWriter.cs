﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using iText;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using WavContact.DB;
using WavContact.Models;

namespace WavContact.Metier
{
    public class WavPDFWriter
    {
        public static void WritePDF(Project p, Tournage t, List<Materiel> materiels, List<CategorieMateriel> categories, bool export)
        {
            string path = WavFTP.downloadFolder + "\\" + p.Id.ToString();
            string file_path = path + "\\" + p.Name + "_" + t.Id.ToString() + ".pdf";

            PdfDocument pdfDoc = new PdfDocument(new PdfWriter(file_path));
            Document doc = new Document(pdfDoc);

            doc.Add(new Paragraph(String.Format("PROJET : {0}", p.Name)));
            
            doc.Add(new Paragraph(String.Format("TOURNAGE : {0}", t.Debut.ToString("dd/MM-yyyy (HH:mm)") + " - " + t.Fin.ToString("dd/MM-yyyy (HH:mm)"))));

            foreach (CategorieMateriel cate in categories)
            {
                int cpt = 0;
                string line = "";
                foreach (Materiel materiel in materiels)
                {
                    if (cate.Id == materiel.IdCat)
                    {
                        cpt++;
                        line += "- "+ materiel.ToString() + Environment.NewLine;
                    }
                }

                if (cpt != 0)
                {
                    doc.Add(new Paragraph("---------------------------------------------"));
                    doc.Add(new Paragraph(cate.Nom));
                    doc.Add(new Paragraph(line));
                }
            }

            doc.Close();

            if (export)
            {
                WavFTP.UploadFile(file_path, p);

            }
            
            Process.Start("Explorer.exe", file_path);
        }
    }
}
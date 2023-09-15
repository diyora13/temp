// using System;
// using SelectPdf;
// using Pdfcrowd.HtmlToPdfClient;
// using System.IO;


// public class HtmlToPdf
// {
//     public void ConvertAndDownload(string webLink)
//     {
//         String Converted = "Yes";
//         try
//         {
//             Pdfcrowd.HtmlToPdfClient client = new Pdfcrowd.HtmlToPdfClient("user", "apikey");
//             HtmlToPdf converter = new HtmlToPdf();
//             PdfDocument doc = converter.ConvertUrl(webLink);
//             string outputFilename = webLink.Substring(webLink.LastIndexOf('/') + 1) + ".pdf";
//             doc.Save(outputFilename);
//             doc.Close();
//         }
//         catch (Exception e)
//         {
//             Console.Error.WriteLine("Error: " + e.Message);
//         }
//     }
// }
import com.pdfcrowd.HtmlToPdfClient;
import com.pdfcrowd.View;
import com.pdfcrowd.Error;

public void ConverAndDownload(String webLink) {

    String Converted = "Yes";

    try {
        Pdfcrowd.HtmlToPdfClient client = new Pdfcrowd.HtmlToPdfClient("user", "apikey");
        String outputFilename = webLink.substring(WebLink.lastIndexOf('/') + 1) + ".pdf";
        client.convertUrlToFile(webLink, outputFilename);
    }
    catch(Pdfcrowd.Error e){
        System.err.println("Pdfcrowd Error: " + e.getMessage());
    }
    catch(IOException e) {
        System.err.println("IO Error: " + e.getMessage());
    }
}

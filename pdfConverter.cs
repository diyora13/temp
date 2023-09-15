
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

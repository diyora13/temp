import com.pdfcrowd.HtmlToPdfClient;
import com.pdfcrowd.View;
import com.pdfcrowd.Error;


public void converAndDownload(String WebLink) {
    
    String Converted = "Yes";
    
    try {
        Pdfcrowd.HtmlToPdfClient client = new Pdfcrowd.HtmlToPdfClient("user", "apikey");
        String outputFilename = WebLink.substring(WebLink.lastIndexOf('/') + 1) + ".pdf";
        client.convertUrlToFile(WebLink, outputFilename);
    }
    catch(Pdfcrowd.Error e){
        System.err.println("Pdfcrowd Error: " + e.getMessage());
    }
    catch(IOException e) {
        System.err.println("IO Error: " + e.getMessage());
    }
}

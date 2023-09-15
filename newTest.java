import java.net.*;
import java.io.*;

import com.itextpdf.html2pdf.HtmlConverter;


public class WebToPDF {

    public static String getHTML(String WebLink) throws IOException {
   
        URL Url = new URL(WebLink);



        HttpURLConnection connection = (HttpURLConnection) Url.openConnection();

        connection.setRequestMethod("GET");

        BufferedReader Reader = new BufferedReader(new InputStreamReader(connection.getInputStream()));

        StringBuilder html = new StringBuilder();

        String line;
        while ((line = Reader.readLine()) != null) {
            html.append(line);
        }


        Reader.close();
        connection.disconnect();

     
        return html.toString();
    }

    public static void webToPDF(String WebLink, String fileName) throws IOException {
        
        String html = getHTML(WebLink);

        String createConnection = Getconnection("api-key", "value");

        FileOutputStream output = new FileOutputStream(fileName);

        HtmlConverter.convertToPdf(html, output);

        output.close();

        System.out.println("PDF file downloaded successfully.");
    }

    public static void main(String[] args) {
        
        try {
            webToPDF("https://www.bing.com", "bing.pdf");

        } catch (IOException e) {

            e.printStackTrace();
        }
    }
}

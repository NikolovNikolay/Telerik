using System;
using System.Windows.Forms;
using System.Net;
using System.Security;

class DownloadAFile
{
    static void Main()
    {
        try
        {
            string url = "http://www.devbg.org/img/";
            string fileName = "Logo-BASD.jpg", myDownload = null;

            WebClient downloader = new WebClient();

            myDownload = url + fileName;
            Console.WriteLine("Downloading File \"{0}\" from \"{1}\" .......\n\n", fileName, myDownload);

            downloader.DownloadFile(myDownload, fileName);
            Console.WriteLine("Successfully Downloaded File \"{0}\" from \"{1}\"", fileName, myDownload);
            Console.WriteLine("\nDownloaded file saved in the following file system folder:\n\t" + Application.StartupPath);
        }
        catch (ArgumentException)
        {
            Console.WriteLine("There is a problem with the url or file name format entered");
        }

        catch (WebException)
        {
            Console.WriteLine("Combinig the url and filename is invalid or an error occured while downloading data.");
        }
        catch (SecurityException)
        {
            Console.WriteLine("Permission writing issues.");
        }
    }
}
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO.Compression;

class Server
{
    static void Main()
    {
        TcpListener server = new TcpListener(IPAddress.Any, 5000);
        server.Start();
        Console.WriteLine("Server started...");

        while (true)
        {
            TcpClient client = server.AcceptTcpClient();
            Thread t = new Thread(HandleClient);
            t.Start(client);
        }
    }

    static void HandleClient(object obj)
    {
        TcpClient client = (TcpClient)obj;

        try
        {
            NetworkStream stream = client.GetStream();

            byte[] sizeBytes = new byte[4];
            stream.Read(sizeBytes, 0, 4);
            int fileSize = BitConverter.ToInt32(sizeBytes, 0);

            byte[] fileData = new byte[fileSize];
            int bytesRead = 0;

            while (bytesRead < fileSize)
            {
                bytesRead += stream.Read(fileData, bytesRead, fileSize - bytesRead);
            }

            byte[] compressedData = Compress(fileData);

            byte[] compSize = BitConverter.GetBytes(compressedData.Length);
            stream.Write(compSize, 0, 4);

            stream.Write(compressedData, 0, compressedData.Length);

            Console.WriteLine("File compressed and sent back!");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            client.Close();
        }
    }

    static byte[] Compress(byte[] data)
    {
        using (MemoryStream output = new MemoryStream())
        {
            using (GZipStream gzip = new GZipStream(output, CompressionMode.Compress))
            {
                gzip.Write(data, 0, data.Length);
            }
            return output.ToArray();
        }
    }
}
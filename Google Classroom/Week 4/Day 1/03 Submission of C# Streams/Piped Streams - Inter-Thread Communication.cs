using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Text;
using System.Threading;

namespace Google_Classroom.Week_4.Day_1._03_Submission_of_C__Streams
{
    internal class Piped_Streams___Inter_Thread_Communication
    {
        public static void Main(string[] args)
        {
            try
            {
                using (AnonymousPipeServerStream pipeServer = new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.None))
                {
                    string pipeHandle = pipeServer.GetClientHandleAsString();
                    Thread readerThread = new Thread(() =>
                    {
                        try
                        {
                            using (AnonymousPipeClientStream pipeClient = new AnonymousPipeClientStream(PipeDirection.In, pipeHandle))
                            using (StreamReader sr = new StreamReader(pipeClient))
                            {
                                string msg = sr.ReadLine();
                                Console.Write($"Received: {msg}");
                            }
                        }
                        catch (IOException ex)
                        {
                            Console.Write($"Reader Error: {ex.Message}");
                        }
                    });
                    readerThread.Start();
                    pipeServer.DisposeLocalCopyOfClientHandle();
                    using (StreamWriter sw = new StreamWriter(pipeServer))
                    {
                        sw.AutoFlush = true;
                        sw.WriteLine("Hello from Writer Thread through PipeStream!");
                    }
                    readerThread.Join();
                }
            }
            catch (IOException ex)
            {
                Console.Write($"Pipe Error: {ex.Message}");
            }
        }
    }
}

using System;
using System.IO;

namespace Cut
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //int i = 0;
            //while (true)
            //{
            //    i++;
            //    File.AppendAllText("log.txt", $"{i}tesdfsdsdfsdfsdfsafdasdfsadfasdfsdafasdfsdfsadfsadfsdfsdafsdafdsfsdfsdafasdff");
            //    FileInfo f = new FileInfo("log.txt");
            //    Console.WriteLine($"10 - {f.Length / (1024 * 1024)} ={10 - f.Length / (1024 * 1024)}");
            //    if (f.Length > 10 * 1024 * 1024)
            //    {
            //        break;
            //    }
            //}
            //args = new string[] { "log.txt", "1" };

            string file = args[0];

            int splitFileSize = 200 * 1024 * 1024;
            if (args.Length > 1)
            {
                splitFileSize = int.Parse(args[1]) * 1024 * 1024;
            }

            FileInfo fileInfo = new FileInfo(file);
            var name = fileInfo.Name.TrimEnd(".txtTXT".ToCharArray());

            var path = $"{fileInfo.Directory.FullName}/{name }_s";
            string splitFileFormat = $"{path}/{name}_" + "{0}.txt";
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);

            int steps = (int)(fileInfo.Length / splitFileSize);
            using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    int couter = 1;
                    bool isReadingComplete = false;
                    while (!isReadingComplete)
                    {
                        string filePath = string.Format(splitFileFormat, couter);
                        Console.WriteLine("开始读取文件【{1}】：{0}", filePath, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));

                        byte[] input = br.ReadBytes(splitFileSize);
                        using (FileStream writeFs = new FileStream(filePath, FileMode.Create))
                        {
                            using (BinaryWriter bw = new BinaryWriter(writeFs))
                            {
                                bw.Write(input);
                            }
                        }

                        isReadingComplete = (input.Length != splitFileSize);
                        if (!isReadingComplete)
                        {
                            couter += 1;
                        }
                        Console.WriteLine("完成读取文件【{1}】：{0}", filePath, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                    }
                }
            }

            Console.WriteLine("分隔完成，请按下任意键结束操作。。。");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public class Tools
    {
        public static string AssignType(string extension)
        {
            Dictionary<string, List<string>> types = new Dictionary<string, List<string>>();
            types.Add("image", new List<string>() { ".jpg", ".jpeg", ".png", ".gif", ".tiff", ".webp" });
            types.Add("audio", new List<string>() { ".ogg", ".mp3", ".mp4a", ".wav", ".aac", ".flac" });
            types.Add("video", new List<string>() { ".mp4", ".webm", ".avi", ".mkv", ".flv" });
            types.Add("document", new List<string>() { ".txt", ".doc", ".docx", ".xml", ".xlmx", ".pdf" });
            types.Add("archive", new List<string>() { ".zip", ".rar", ".7z", ".tar", ".gz" });
            string output = "other";
            foreach (var type in types)
            {
                foreach (var ext in type.Value)
                {
                    if (extension == ext)
                    {
                        output = type.Key;
                    }
                }
            }
            return output;
        }

        public static string ConvertSize(long bytes)
        {
            string output;
            if (bytes < 1024)
            {
                output = $"{bytes}B";
            }
            else if (bytes < 1024 * 1024)
            {
                output = $"{bytes / 1024}KB";
            }
            else if (bytes < 1024 * 1024 * 1024)
            {
                output = $"{bytes / 1024 / 1024}MB";
            }
            else
            {
                output = $"{bytes / 1024 / 1024 / 1024}GB";
            }
            return output;
        }

    }
}

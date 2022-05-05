using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public class FileData
    {
        public string Name { get; }
        public string Path { get; }
        public long Size { get; }
        public string Extension { get; }
        public string Type { get; }

        public FileData(string Name, string FullName, string Extension, long Length)
        {
            this.Name = Name;
            Path = FullName;
            this.Extension = Extension;
            Size = Length;

            Type = Extension switch
            {
                "png" => "image",
                "webp" => "image",
                "jpg" => "image",
                "gif" => "image",
                "tiff" => "image",
                "ogg" => "audio",
                "mp3" => "audio",
                "mp4a" => "audio",
                "flac" => "audio",
                "wav" => "audio",
                "mkv" => "video",
                "mp4" => "video",
                "webm" => "video",
                "txt" => "document",
                "doc" => "document",
                "docx" => "document",
                "xml" => "document",
                "xlmx" => "document",
                _ => "other"
            };
        }
    }
}

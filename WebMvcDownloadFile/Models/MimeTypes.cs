namespace WebMvcDownloadFile.Models
{
    public class MimeTypes
    {
        public static Dictionary<string, string> GetMimeTypes()
        {
            return new Dictionary<string, string>
            {
               {".png", "image/png"},
               {".jpg", "image/jpeg"},
               {".jpeg", "image/jpeg"},
               {".gif", "image/gif"}
            };
        }
    }
}

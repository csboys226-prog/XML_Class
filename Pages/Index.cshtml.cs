using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Serialization;
using System.IO;
using XML_Class.Models;

namespace XML_Class.Pages
{
    public class IndexModel : PageModel
    {
        public string XmlOutput { get; set; } = string.Empty;

        public void OnGet()
        {
            // 1. Oru Student Object create pannuvom
            var student = new Student { Id = 101, Name = "Vijay", Course = "ASP.NET Core" };

            // 2. XmlSerializer Class-ah initialize pannuvom
            XmlSerializer serializer = new XmlSerializer(typeof(Student));

            // 3. StringWriter use panni XML-ah text-ah mathuvom
            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, student);
                XmlOutput = writer.ToString(); // Intha string-ah thaan view-la kaatta porom
            }
        }
    }
}
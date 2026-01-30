using System.Xml.Serialization;

namespace XML_Class.Models
{
    [XmlRoot("StudentProfile")] // XML-oda root tag name ithu thaan
    public class Student
    {
        [XmlElement("StudentName")] // C# property-ah XML element-ah mathum
        public string Name { get; set; } = string.Empty;

        [XmlAttribute("StudentID")] // Ithu XML tag-kulle attribute-ah varum
        public int Id { get; set; }

        [XmlElement("Course")]
        public string Course { get; set; } = string.Empty;
    }
}
// See https://aka.ms/new-console-template for more information
using DocumentFormat.OpenXml.Wordprocessing;
using System.Security.Cryptography;
using System.Xml;
using XmlWriteConcepts;


Course[] crs = new Course[3];
crs[0] = new Course() { Cid = 11, Name = "DotnetCore" };
crs[1] = new Course() { Cid = 22, Name = "Angular" };
crs[2] = new Course() { Cid = 33, Name = "React" };


using(XmlWriter xmlw = XmlWriter.Create("course.xml"))
{
    xmlw.WriteStartDocument();
    xmlw.WriteStartElement("Courses");


    foreach (Course c in crs)
    {
        xmlw.WriteStartElement("Course");
        xmlw.WriteAttributeString("CID", c.Cid.ToString());
        xmlw.WriteElementString("CName", c.Name);
        // Console.WriteLine(c.Cid+" "+c.Name);
        xmlw.WriteEndElement();
    }
    xmlw.WriteEndElement();
    xmlw.WriteEndDocument();
    Console.WriteLine();
}
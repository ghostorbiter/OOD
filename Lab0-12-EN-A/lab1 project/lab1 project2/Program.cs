using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library;
using lab1_project;
using System.Xml;
using System.Xml.Schema;

namespace lab1_project2
{
    class Program
    {
        private static void ValidationHandler(Object sender, ValidationEventArgs args)
        {
            if (args.Severity == XmlSeverityType.Warning)
                Console.WriteLine("Warning: {0}", args.Message);
            else
                Console.WriteLine("Error: {0}", args.Message);
        }

        static void Main(string[] args)
        {


            bool name = false;
            bool price = false;
        //...
        XmlReaderSettings settings = new XmlReaderSettings();
            // Validator settings
            settings.ValidationType = ValidationType.Schema;
            settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessInlineSchema;
            settings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;

            // Here we add xsd files to namespaces we want to validate
            // (It's like XML -> Schemas setting in Visual Studio)
            settings.Schemas.Add("http://example.org/jk/library", "h:\\Windows7\\Desktop\\yusupovy xml\\lab1\\lab1 project\\lab1 project\\library.xsd");

            // Processing XSI Schema Location attribute
            // (Disabled by default as it is a security risk). 
            settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessSchemaLocation;

            // A function delegate that will be called when 
            // validation error or warning occurs
            settings.ValidationEventHandler += ValidationHandler;

            XmlReader reader = XmlReader.Create("h:\\Windows7\\Desktop\\yusupovy xml\\lab1\\library.xml", settings);

            // Read method reads next element or attribute from the document
            // It will call ValidationEventHandler if some invalid
            // part occurs
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        switch (reader.Name)
                        {
                            case "<name>":
                                name = true;
                                price = false;
                                break;
                            case "<price>":
                                price = true;
                                name = false;
                                break;
                                
                        }
                        break;
                    case XmlNodeType.Text:
                        if (name)
                        {
                            Console.WriteLine($"Total cost of {reader.Name} : ");
                        }
                        if (price)
                        {
                            Console.WriteLine(reader.Name);
                        }
                        break;
                    case XmlNodeType.CDATA:
                        Console.Write("<![CDATA[{0}]]>", reader.Value);
                        break;
                    case XmlNodeType.ProcessingInstruction:
                        Console.Write("<?{0} {1}?>", reader.Name, reader.Value);
                        break;
                    case XmlNodeType.Comment:
                        Console.Write("<!--{0}-->", reader.Value);
                        break;
                    case XmlNodeType.XmlDeclaration:
                        Console.Write("<?xml version='1.0'?>");
                        break;
                    case XmlNodeType.Document:
                        break;
                    case XmlNodeType.DocumentType:
                        Console.Write("<!DOCTYPE {0} [{1}]", reader.Name, reader.Value);
                        break;
                    case XmlNodeType.EntityReference:
                        Console.Write(reader.Name);
                        break;
                    case XmlNodeType.EndElement:
                        Console.Write("</{0}>", reader.Name);
                        break;
                }
            }

            //library lib = libRead.ReadLib("h:\\Windows7\\Desktop\\yusupovy xml\\lab1\\library.xml");
            //Console.WriteLine(lib.book[1].authornames);
        }
    }
}

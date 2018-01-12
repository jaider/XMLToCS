using System;
using System.Text;
using System.Xml.Linq;

namespace XMLToCS.Lib
{
    public class XMLCodeConverter
    {
        Func<int, string> Tab = n => "".PadLeft(n * 4);

        public string LoadAndConvert(string uri)
        {
            XDocument root = XDocument.Load(uri);
            return Convert(root);
        }

        public string ParseAndConvert(string xmlContent)
        {
            XDocument root = XDocument.Parse(xmlContent);
            return Convert(root);
        }

        public string Convert(XDocument root)
        {
            var result = new StringBuilder();
            Nav(root.Root, ref result);
            result.AppendLine(";");
            return result.ToString();
        }

        private void Nav(XElement node, ref StringBuilder sb, int indentation = 0)
        {
            sb.Append($"{Tab(indentation)}new XElement(\"{node.Name}\"");

            if (node.HasAttributes) {
                foreach (var attr in node.Attributes()) {
                    sb.AppendLine($"{Tab(indentation + 1)},");
                    sb.Append($"{Tab(indentation + 1)}new XAttribute(\"{attr.Name}\", \"{attr.Value}\")");
                }
            }

            if (node.HasElements) {
                foreach (var child in node.Elements()) {
                    sb.AppendLine($"{Tab(indentation + 1)},");
                    Nav(child, ref sb, indentation + 1);
                }
                sb.AppendLine($"{Tab(indentation)})");
            }
            else {
                if (!string.IsNullOrEmpty(node.Value)) {
                    sb.Append($", \"{node.Value.Trim()}\")");
                }
                else {
                    sb.Append($")");
                }
            }
        }

    }
}


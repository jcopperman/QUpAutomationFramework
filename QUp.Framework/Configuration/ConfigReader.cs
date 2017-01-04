using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace QUp.Framework.Config
{
    public class ConfigReader
    {
        public static void SetFrameworkSettings()
        {
            XPathItem environment;
            XPathItem testtype;
            XPathItem islog;
            XPathItem isreport;
            XPathItem buildname;
            XPathItem logPath;

            string strFilename = /*Environment.CurrentDirectory.ToString() + */"C:\\Dev\\QUp.Framework\\QUp.Framework\\Configuration\\GlobalConfig.xml";
            FileStream stream = new FileStream(strFilename, FileMode.Open);
            XPathDocument document = new XPathDocument(stream);
            XPathNavigator navigator = document.CreateNavigator();

            //Get XML Details and pass it in XPathItem type variables
            environment = navigator.SelectSingleNode("QUp.Framework/RunSettings/Environment");
            buildname = navigator.SelectSingleNode("QUp.Framework/RunSettings/BuildName");
            testtype = navigator.SelectSingleNode("QUp.Framework/RunSettings/TestType");
            islog = navigator.SelectSingleNode("QUp.Framework/RunSettings/IsLog");
            isreport = navigator.SelectSingleNode("QUp.Framework/RunSettings/IsReport");
            logPath = navigator.SelectSingleNode("QUp.Framework/RunSettings/LogPath");

            //Set XML Details in the property to be used accross framework
            Settings.Environment = environment.Value.ToString();
            Settings.BuildName = buildname.Value.ToString();
            Settings.TestType = testtype.Value.ToString();
            Settings.IsLog = islog.Value.ToString();
            Settings.IsReporting = isreport.Value.ToString();
            Settings.LogPath = logPath.Value.ToString();
        }
    }
}

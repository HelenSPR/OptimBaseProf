using Atechnology.DBConnections2;
using Atechnology.ecad.Calc.winDraw;
using Atechnology.ecad.Document.DataSets;
using Atechnology.winDraw;
using Atechnology.winDraw.Classes;
using Atechnology.winDraw.Collections;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace ValidateConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            AnotherMain();
            //dbinit.db = new SqlConnection("Data Source=sqlwindraw.fabrikon.ru;Initial Catalog=ecad_FO;User ID=windraw;Password=Ffff1234");
            //dbconn._db = new dbconn();
            //SettingsLoad.currentSettings = new Atechnology.winDraw.Model.Settings.Settings();

            //ds_order.modelDataTable modelDT = new ds_order.modelDataTable();
            ////ds_order.orderitemDataTable orderitemDT = new ds_order.orderitemDataTable();

            //dbconn.FillDataTable2(modelDT, "select top (100) * from model where idorderitem  = 1258573", true);

            //ds_order.modelRow modelRow = modelDT[0];

     

            //OrderItemModelValidator validator = OrderItemModelValidator.CreateValidator(modelRow);
            //validator.AllValidate();


            
        }

        static void AnotherMain()
        {
            dbinit.db = new SqlConnection("Data Source=sqlwindraw.fabrikon.ru;Initial Catalog=ecad_FO;User ID=windraw;Password=Ffff1234");
            dbconn._db = new dbconn();
            SettingsLoad.currentSettings = new Atechnology.winDraw.Model.Settings.Settings();

            ds_order ds = new ds_order();
            ds_order.modelDataTable modelDT = new ds_order.modelDataTable();
            ds_order.orderitemDataTable orderitemDT = new ds_order.orderitemDataTable();


            //int idorderitem = 1249634;
            int idorderitem = 1249635;
            //int idorderitem = 1258469;

          
            dbconn.FillDataTable2(modelDT, string.Format("select top (100) * from model where idorderitem  = {0}", idorderitem), true);
            dbconn.FillDataTable2(orderitemDT, string.Format("select * from orderitem where idorderitem = {0}", idorderitem), false);
            
            ds_order.modelRow modelRow = modelDT[0];
            ds_order.orderitemRow orderitem = orderitemDT[0];

      


            byte[] b = Atechnology.Components.ZipArchiver.UnZip2(modelRow.classnative);
            clsModel classmodel = new clsModel(b);
            classmodel.Load(b);
            MemoryStream ms = new MemoryStream(b);
            XmlReader xmlReader = XmlReader.Create(ms);

            XElement xElement = XElement.Load(xmlReader);

            //classmodel.Save();

            //classmodel.ZipSave();

            classmodel.ZipConstructionSave();
   
        

            ImitationSaveClassModel(classmodel);
        }

        static void ImitationSaveClassModel(clsModel classModel)
        {
            XmlDocument doc = new XmlDocument();
            XmlProcessingInstruction newChild = doc.CreateProcessingInstruction("xml", "version = '1.0'");
            doc.AppendChild(newChild);
            XmlElement element = doc.CreateElement("clsModel");
            doc.AppendChild(element);
            classModel.ProfileSystem.Save(doc, element);
            classModel.FurnitureSystem.Save(doc, element);
            element.SetAttribute("BaseRegionID", (classModel.BaseRegion == null) ? "-1" : classModel.BaseRegion.IDRegion.ToString());
            element.SetAttribute("BaseRegionFatherID", (classModel.BaseRegion == null) ? "-1" : classModel.BaseRegion.IDFathRegion.ToString());
            element.SetAttribute("Orient", ((int)classModel.Orientation).ToString());
            element.SetAttribute("ModelName", classModel.ModelName);
            //Tools.SetIntAttr(element, "ModelID", classModel.m);
            element.SetAttribute("Comment", classModel.Comment);
            element.SetAttribute("ModelCount", classModel.ModelCount.ToString());
            element.SetAttribute("HandleType", ((int)classModel.HandleType).ToString());
            element.SetAttribute("HandlePositionType", ((int)classModel.HandlePositionType).ToString());
            //element.SetAttribute("ConstructionOffset", ((int)classModel.constructionOffset).ToString());
            element.SetAttribute("CreateTime", DateTime.Now.ToString(CultureInfo.InvariantCulture));


            if (classModel.ColorInside != null)
            {
                classModel.ColorInside.Save(doc, element, "NewColorInside");
            }
            if (classModel.ColorOutside != null)
            {
                classModel.ColorOutside.Save(doc, element, "NewColorOutside");
            }
            if (classModel.HandlePosition != null)
            {
                classModel.HandlePosition.Save(doc, element);
            }
            if (classModel.ProfileSystem.Fills.Default != null)
            {
                classModel.ProfileSystem.Fills.Default.Save(doc, element, "DefaultFill");
            }
            if ((classModel.UserParameters != null) && (classModel.UserParameters.Count != 0))
            {
                classModel.UserParameters.Save(doc, element);
            }
            if (classModel.ConstructionType != null)
            {
                classModel.ConstructionType.Save(doc, element);
            }
            int num = 0;
            int count = classModel.Parts.Count;
            while (num < count)
            {
                classModel.Parts[num].Save(doc, element);
                num++;
            }
            colModelConnection first = classModel.ModelConnections.GetFirstModelConnection(classModel);
            classModel.ModelConnections.Save(doc, element, 2);
            num = 0;
            count = classModel.ModelConnections.Count;

            var mmmmmmmmmmmmm = classModel.ModelConnections[0];
            while (num < count)
            {
                classModel.ModelConnections[num].Save(doc, element, classModel.ModelConnections[num].firstModel == classModel);
                num++;
            }
            XmlElement element2 = doc.CreateElement("CalcVariables");
            element.AppendChild(element2);
            foreach (KeyValuePair<string, string> pair in classModel.CalcVariables)
            {
                XmlElement element3 = doc.CreateElement("Variable");
                element2.AppendChild(element3);
                element3.SetAttribute("Name", pair.Key);
                element3.SetAttribute("Value", pair.Value);
            }
            MemoryStream outStream = new MemoryStream();
            doc.Save(outStream);


        }

        //static void SaveClassModel(clsModel classmodel)
        //{
        //    if (classmodel.DisableSave)
        //    {
        //        return new byte[0];
        //    }
        //    XmlDocument doc = new XmlDocument();
        //    XmlProcessingInstruction newChild = doc.CreateProcessingInstruction("xml", "version='1.0'");
        //    doc.AppendChild(newChild);
        //    XmlElement element = doc.CreateElement("clsModel");
        //    doc.AppendChild(element);
        //    classmodel.ProfileSystem.Save(doc, element);
        //    classmodel.FurnitureSystem.Save(doc, element);
        //    element.SetAttribute("BaseRegionID", (classmodel.BaseRegion == null) ? "-1" : classmodel.BaseRegion.IDRegion.ToString());
        //    element.SetAttribute("BaseRegionFatherID", (classmodel.BaseRegion == null) ? "-1" : classmodel.BaseRegion.IDFathRegion.ToString());
        //    element.SetAttribute("Orient", ((int)classmodel.Orientation).ToString());
        //    element.SetAttribute("ModelName", classmodel.ModelName);
        //    //Tools.SetIntAttr(element, "ModelID", classmodel.IDModel);
        //    //element.SetAttribute("Comment", classmodel.Comment);
        //    //element.SetAttribute("ModelCount", classmodel.ModelCount.ToString());
        //    //element.SetAttribute("HandleType", ((int)classmodel.HandleType).ToString());
        //    //element.SetAttribute("HandlePositionType", ((int)classmodel.HandlePositionType).ToString());
        //    //element.SetAttribute("ConstructionOffset", ((int)classmodel.constructionOffset).ToString());
        //    element.SetAttribute("CreateTime", DateTime.Now.ToString(CultureInfo.InvariantCulture));
        //    if (classmodel.ColorInside != null)
        //    {
        //        classmodel.ColorInside.Save(doc, element, "NewColorInside");
        //    }
        //    if (classmodel.ColorOutside != null)
        //    {
        //        classmodel.ColorOutside.Save(doc, element, "NewColorOutside");
        //    }
        //    if (classmodel.HandlePosition != null)
        //    {
        //        classmodel.HandlePosition.Save(doc, element);
        //    }
        //    if (classmodel.ProfileSystem.Fills.Default != null)
        //    {
        //        classmodel.ProfileSystem.Fills.Default.Save(doc, element, "DefaultFill");
        //    }
        //    if ((classmodel.UserParameters != null) && (classmodel.UserParameters.Count != 0))
        //    {
        //        classmodel.UserParameters.Save(doc, element);
        //    }
        //    if (classmodel.ConstructionType != null)
        //    {
        //        classmodel.ConstructionType.Save(doc, element);
        //    }
        //    int num = 0;
        //    int count = classmodel.Parts.Count;
        //    while (num < count)
        //    {
        //        classmodel.Parts[num].Save(doc, element);
        //        num++;
        //    }
        //    classmodel.ModelConnections.Save(doc, element, classmodel.IDModel);
        //    num = 0;
        //    count = classmodel.ModelConnections.Count;
        //    while (num < count)
        //    {
        //        classmodel.ModelConnections[num].Save(doc, element, classmodel.ModelConnections[num].firstModel == this);
        //        num++;
        //    }
        //    XmlElement element2 = doc.CreateElement("CalcVariables");
        //    element.AppendChild(element2);
        //    foreach (KeyValuePair<string, string> pair in classmodel.CalcVariables)
        //    {
        //        XmlElement element3 = doc.CreateElement("Variable");
        //        element2.AppendChild(element3);
        //        element3.SetAttribute("Name", pair.Key);
        //        element3.SetAttribute("Value", pair.Value);
        //    }
        //    MemoryStream outStream = new MemoryStream();
        //    doc.Save(outStream);
        //    return outStream.ToArray();
        //}

       
    }
}

// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.ProductionTypeClass
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.ecad.Dictionary.DataSets;
using System;
using System.Collections.Generic;
using System.Data;

namespace Atechnology.ecad.Dictionary
{
    public class ProductionTypeClass
    {
        public static ds_productiontype ds;

        public static void Load()
        {
            if (ProductionTypeClass.ds == null)
                ProductionTypeClass.ds = new ds_productiontype();
            ProductionTypeClass.ds.Load();
        }

        public static ds_productiontype.productiontypeRow GetProductionType(int IdProductionType)
        {
            return ProductionTypeClass.ds.productiontype.FindByidproductiontype(IdProductionType);
        }

        public static ds_productiontype.productiontypeRow GetProductionType(string name)
        {
            DataRow[] dataRowArray = ProductionTypeClass.ds.productiontype.Select("name = '" + name + "'");
            if (dataRowArray.Length == 0)
                return (ds_productiontype.productiontypeRow)null;
            return (ds_productiontype.productiontypeRow)dataRowArray[0];
        }

        public static ds_productiontype.productiontypeRow GetProductionType(string name, string Group)
        {
            foreach (ds_productiontype.productiontypeRow productiontypeRow in ProductionTypeClass.ds.productiontype.Select("name = '" + name + "'"))
            {
                if (productiontypeRow.productiontypegroupRow.name == Group)
                    return productiontypeRow;
            }
            return (ds_productiontype.productiontypeRow)null;
        }

        public static ds_productiontype.productiontypeRow GetProductionTypeByConstrName(string ConstrName)
        {
            DataRow[] dataRowArray = ProductionTypeClass.ds.productiontype.Select("constructiontype_name = '" + ConstrName + "'");
            if (dataRowArray.Length == 0)
                return (ds_productiontype.productiontypeRow)null;
            return (ds_productiontype.productiontypeRow)dataRowArray[0];
        }

        public static List<int> GetProductionTypeConstrList(int IdProductionType)
        {
            List<int> list = new List<int>();
            ds_productiontype.productiontypeRow productionType = ProductionTypeClass.GetProductionType(IdProductionType);
            if (productionType == null)
                return list;
            ds_productiontype.productiontypeconstructionRow[] productiontypeconstructionRowArray = productionType.GetproductiontypeconstructionRows();
            if (productiontypeconstructionRowArray == null || productiontypeconstructionRowArray.Length == 0)
                return list;
            foreach (ds_productiontype.productiontypeconstructionRow productiontypeconstructionRow in productiontypeconstructionRowArray)
            {
                if (productiontypeconstructionRow._active)
                    list.Add(productiontypeconstructionRow.idconstructiontype);
            }
            return list;
        }

        public static List<int> GetProductionTypeSystemList(int IdProductionType)
        {
            List<int> list = new List<int>();
            ds_productiontype.productiontypeRow productionType = ProductionTypeClass.GetProductionType(IdProductionType);
            if (productionType == null)
                return list;
            ds_productiontype.productiontypesystemsRow[] productiontypesystemsRowArray = productionType.GetproductiontypesystemsRows();
            if (productiontypesystemsRowArray == null || productiontypesystemsRowArray.Length == 0)
                return list;
            foreach (ds_productiontype.productiontypesystemsRow productiontypesystemsRow in productiontypesystemsRowArray)
            {
                if (productiontypesystemsRow._active)
                    list.Add(productiontypesystemsRow.idsystem);
            }
            return list;
        }

        public static ds_productiontype.productiontypesettingRow GetSettingVar(string ProdName, string SettingName)
        {
            DataRow[] dataRowArray = ProductionTypeClass.ds.productiontypesetting.Select("setting_name  = '" + SettingName + "' and productiontype_name = '" + ProdName + "'");
            if (dataRowArray.Length == 0)
                return (ds_productiontype.productiontypesettingRow)null;
            return (ds_productiontype.productiontypesettingRow)dataRowArray[0];
        }

        public static ds_productiontype.productiontypesettingRow GetSettingVar(int IdProduct, string SettingName)
        {
            DataRow[] dataRowArray = ProductionTypeClass.ds.productiontypesetting.Select(string.Concat(new object[4]
      {
        (object) "setting_name = '",
        (object) SettingName,
        (object) "' and idproductiontype = ",
        (object) IdProduct
      }));
            if (dataRowArray.Length == 0)
                return (ds_productiontype.productiontypesettingRow)null;
            return (ds_productiontype.productiontypesettingRow)dataRowArray[0];
        }

        public static ds_productiontype.productiontypesettingRow GetSettingVar(int IdProduct, int IDSetting)
        {
            DataRow[] dataRowArray = ProductionTypeClass.ds.productiontypesetting.Select(string.Concat(new object[4]
      {
        (object) "idsetting = '",
        (object) IDSetting,
        (object) " and idproductiontype = ",
        (object) IdProduct
      }));
            if (dataRowArray.Length == 0)
                return (ds_productiontype.productiontypesettingRow)null;
            return (ds_productiontype.productiontypesettingRow)dataRowArray[0];
        }

        public static ds_productiontype.productiontypesettingRow GetSettingVar(string ProdName, int IDSetting)
        {
            DataRow[] dataRowArray = ProductionTypeClass.ds.productiontypesetting.Select("idsetting = '" + (object)IDSetting + " and productiontype_name = '" + ProdName + "'");
            if (dataRowArray.Length == 0)
                return (ds_productiontype.productiontypesettingRow)null;
            return (ds_productiontype.productiontypesettingRow)dataRowArray[0];
        }

        public static Decimal GetIntValue(int IdProduct, string SettingName, Decimal DefaultValue)
        {
            ds_productiontype.productiontypesettingRow settingVar = ProductionTypeClass.GetSettingVar(IdProduct, SettingName);
            if (settingVar == null || settingVar.IsintvalueNull())
                return DefaultValue;
            return settingVar.intvalue;
        }

        public static Decimal GetIntValue2(int IdProduct, string SettingName, Decimal DefaultValue)
        {
            ds_productiontype.productiontypesettingRow settingVar = ProductionTypeClass.GetSettingVar(IdProduct, SettingName);
            if (settingVar == null || settingVar.Isintvalue2Null())
                return DefaultValue;
            return settingVar.intvalue2;
        }

        public static string GetTxtValue(int IdProduct, string SettingName, string DefaultValue)
        {
            ds_productiontype.productiontypesettingRow settingVar = ProductionTypeClass.GetSettingVar(IdProduct, SettingName);
            if (settingVar == null || settingVar.IstxtvalueNull())
                return DefaultValue;
            return settingVar.txtvalue;
        }

        public static DataTable GetTableValue(int IdProduct, string SettingName, DataTable DefaultValue)
        {
            ds_productiontype.productiontypesettingRow settingVar = ProductionTypeClass.GetSettingVar(IdProduct, SettingName);
            if (settingVar == null || settingVar.IsblbvalueNull())
                return DefaultValue;
            return settingVar.TableValue ?? DefaultValue;
        }

        public static ds_productiontype.productiontypeparamRow GetParam(int IdProductionType, string ParamName)
        {
            DataRow[] dataRowArray = ProductionTypeClass.ds.productiontypeparam.Select(string.Concat(new object[4]
      {
        (object) "modelparam_name  = '",
        (object) ParamName,
        (object) "' and idproductiontype = ",
        (object) IdProductionType
      }));
            if (dataRowArray.Length == 0)
                return (ds_productiontype.productiontypeparamRow)null;
            return (ds_productiontype.productiontypeparamRow)dataRowArray[0];
        }

        public static ds_productiontype.productiontypeparamRow GetParam(string ProdName, string ParamName, string ParamGroupName)
        {
            DataRow[] dataRowArray = ProductionTypeClass.ds.productiontypeparam.Select("modelparam_name  = '" + ParamName + "' and productiontype_name = '" + ProdName + "'");
            if (dataRowArray.Length == 0)
                return (ds_productiontype.productiontypeparamRow)null;
            return (ds_productiontype.productiontypeparamRow)dataRowArray[0];
        }
    }
}

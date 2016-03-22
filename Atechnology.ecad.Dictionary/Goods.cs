// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.Goods
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.DBConnections2;
using Atechnology.ecad.Dictionary.DataSets;
using System.Data;

namespace Atechnology.ecad.Dictionary
{
    public class Goods
    {
        public static bool CancelUpdatePrice = false;
        public static ds_good ds = new ds_good(false);
        public static DataTable table_good = (DataTable)Goods.ds.good;
        public static DataTable table_goodkitdetail = new DataTable("goodkitdetail");
        public static DataTable table_goodgroup = (DataTable)Goods.ds.goodgroup;

        public static dbconn db
        {
            get
            {
                return dbconn._db;
            }
        }

        public Goods()
        {
            Goods.Reload();
        }

        public static void Reload()
        {
            if (Goods.ds == null)
            {
                Goods.ds = new ds_good(true);
                Goods.table_good = (DataTable)Goods.ds.good;
                Goods.table_goodgroup = (DataTable)Goods.ds.goodgroup;
            }
            else
                Goods.ds.Load();
            Goods.table_goodkitdetail.Clear();
            Goods.db.command.CommandText = "select * from view_goodkitdetail where deleted is null and goodkitgroup_isactive = 1";
            Goods.db.adapter.Fill(Goods.table_goodkitdetail);
            Goods.ds.AcceptChanges();
            Goods.CancelUpdatePrice = false;
        }

        public bool IsExistGoodKit(string Name)
        {
            return Goods.table_goodkitdetail.Select("goodkit_name = '" + Name + "' and goodkitgroup_isactive = 1").Length != 0;
        }

        public DataRow[] GetGoodRowsByGoodKit(string Name)
        {
            return Goods.table_goodkitdetail.Select("goodkit_name = '" + Name + "' and goodkitgroup_isactive = 1");
        }

        public static DataRow GetGoodRow(int idgood)
        {
            DataRow[] dataRowArray = Goods.ds.good.Select("idgood = " + idgood.ToString());
            if (dataRowArray.Length != 0)
                return dataRowArray[0];
            return (DataRow)null;
        }

        public static DataRow GetGoodRow(string marking, string SystemName)
        {
            return Goods.GetGoodRow(marking, SystemName, "", "", "", "");
        }

        public static DataRow GetGoodRow(string marking)
        {
            return Goods.GetGoodRow(marking, "", "", "", "", "");
        }

        public static DataRow GetGoodRow(string marking, string SystemName, string Color1, string Color2)
        {
            return Goods.GetGoodRow(marking, SystemName, Color1, "", Color2, "");
        }

        public static DataRow GetGoodRow(string marking, string Color1, string Color2)
        {
            return Goods.GetGoodRow(marking, "", Color1, "", Color2, "");
        }

        public static DataRow GetGoodRow(string marking, string SystemName, int IdColor1, int IdColor2)
        {
            string filterExpression1 = "goodgroup_isactive = 1 and marking = '" + marking + "'";
            if (SystemName != null && SystemName != "")
                filterExpression1 = filterExpression1 + " and system_name = '" + SystemName + "'";
            if (IdColor1 != 0)
                filterExpression1 = filterExpression1 + (object)" and idcolor1 = " + (string)(object)IdColor1;
            if (IdColor2 != 0)
                filterExpression1 = filterExpression1 + (object)" and idcolor2 = " + (string)(object)IdColor2;
            DataRow[] dataRowArray = Goods.ds.good.Select(filterExpression1);
            if (dataRowArray.Length == 0)
            {
                string filterExpression2 = "goodgroup_isactive = 1 and marking = '" + marking + "'";
                if (SystemName != null && SystemName != "")
                    filterExpression2 = filterExpression2 + " and system_name = '" + SystemName + "'";
                dataRowArray = Goods.ds.good.Select(filterExpression2);
            }
            if (dataRowArray.Length == 1)
                return dataRowArray[0];
            return (DataRow)null;
        }

        public static DataRow GetGoodRow(string marking, int IdColor1, int IdColor2)
        {
            return Goods.GetGoodRow(marking, "", IdColor1, IdColor2);
        }

        public static DataRow GetGoodRow(string marking, string SystemName, string Color1, string ColorGroup1, string Color2, string ColorGroup2)
        {
            string filterExpression1 = "goodgroup_isactive = 1 and marking = '" + marking + "'";
            if (SystemName != null && SystemName != "")
                filterExpression1 = filterExpression1 + " and system_name = '" + SystemName + "'";
            if (Color1 != null && Color1 != "")
                filterExpression1 = filterExpression1 + " and color1_name = '" + Color1 + "'";
            if (Color2 != null && Color2 != "")
                filterExpression1 = filterExpression1 + " and color2_name = '" + Color2 + "'";
            if (ColorGroup1 != null && ColorGroup1 != "")
                filterExpression1 = filterExpression1 + " and color1_groupname = '" + ColorGroup1 + "'";
            if (ColorGroup2 != null && ColorGroup2 != "")
                filterExpression1 = filterExpression1 + " and color2_groupname = '" + ColorGroup2 + "'";
            DataRow[] dataRowArray = Goods.ds.good.Select(filterExpression1);
            if (dataRowArray.Length == 0)
            {
                string filterExpression2 = "goodgroup_isactive = 1 and marking = '" + marking + "'";
                if (SystemName != null && SystemName != "")
                    filterExpression2 = filterExpression2 + " and system_name = '" + SystemName + "'";
                dataRowArray = Goods.ds.good.Select(filterExpression2);
            }
            if (dataRowArray.Length == 1)
                return dataRowArray[0];
            return (DataRow)null;
        }

        public static DataRow GetGoodRow(string marking, string Color1, string ColorGroup1, string Color2, string ColorGroup2)
        {
            return Goods.GetGoodRow(marking, "", Color1, ColorGroup1, Color2, ColorGroup2);
        }
    }
}

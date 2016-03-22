// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.Kladr
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.DBConnections2;
using System.Data;

namespace Atechnology.ecad.Dictionary
{
    public class Kladr
    {
        private static dbconn db = dbconn._db;

        public static DataTable GetCity(string Name)
        {
            Kladr.db.command.CommandText = "select distinct top 30 k.socr, k.name, k.socr +' '+k.name\r\n\t\t\t\tfrom kladr.dbo.kladr k, kladr.dbo.socrbase s\r\n\t\t\t\twhere k.socr = s.scname and s.level in (3,4) and k.name like '%" + Name + "%'\r\n\t\t\t\torder by k.name";
            DataTable table = new DataTable();
            Kladr.db.adapter.Fill(table);
            return table;
        }

        public static DataTable GetStreet(string Name)
        {
            Kladr.db.command.CommandText = "select distinct top 30 name \r\n\t\t\t\tfrom kladr.dbo.street where name like '%" + Name + "%'";
            DataTable table = new DataTable();
            Kladr.db.adapter.Fill(table);
            return table;
        }
    }
}

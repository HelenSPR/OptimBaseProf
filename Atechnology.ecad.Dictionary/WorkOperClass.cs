// Decompiled with JetBrains decompiler
// Type: Atechnology.ecad.Dictionary.WorkOperClass
// Assembly: Atechnology.ecad.Dictionary, Version=1.7.1.0, Culture=neutral, PublicKeyToken=null
// MVID: EDFCAA2E-3C94-4A7F-AEA8-C7783DAED684
// Assembly location: C:\Windraw Local\OLD DLL\Atechnology.ecad.Dictionary.dll

using Atechnology.ecad.Dictionary.DataSets;
using System.Data;

namespace Atechnology.ecad.Dictionary
{
    public class WorkOperClass
    {
        public static ds_workoper ds;

        public static void Load()
        {
            if (WorkOperClass.ds == null)
                WorkOperClass.ds = new ds_workoper();
            WorkOperClass.ds.Load();
        }

        public static ds_workoper.workRow GetWork(int IdWork)
        {
            return WorkOperClass.ds.work.FindByidwork(IdWork);
        }

        public static ds_workoper.workRow GetWork(string name)
        {
            DataRow[] dataRowArray = WorkOperClass.ds.work.Select("name = '" + name + "'");
            if (dataRowArray.Length == 0)
                return (ds_workoper.workRow)null;
            return (ds_workoper.workRow)dataRowArray[0];
        }

        public static ds_workoper.workRow GetWork(string name, string Group)
        {
            foreach (ds_workoper.workRow workRow in WorkOperClass.ds.work.Select("name = '" + name + "'"))
            {
                if (workRow.workgroupRow.name == Group)
                    return workRow;
            }
            return (ds_workoper.workRow)null;
        }

        public static ds_workoper.workoperRow GetWorkOper(string WorkName, string WorkOperName)
        {
            DataRow[] dataRowArray = WorkOperClass.ds.workoper.Select("name  = '" + WorkOperName + "' and work_name = '" + WorkName + "'");
            if (dataRowArray.Length == 0)
                return (ds_workoper.workoperRow)null;
            return (ds_workoper.workoperRow)dataRowArray[0];
        }

        public static ds_workoper.workoperRow GetWorkOper(int IdWork, string WorkOperName)
        {
            DataRow[] dataRowArray = WorkOperClass.ds.workoper.Select(string.Concat(new object[4]
      {
        (object) "name = '",
        (object) WorkOperName,
        (object) "' and idwork  = ",
        (object) IdWork
      }));
            if (dataRowArray.Length == 0)
                return (ds_workoper.workoperRow)null;
            return (ds_workoper.workoperRow)dataRowArray[0];
        }

        public static ds_workoper.workoperRow GetWorkOper(int IdWorkOper)
        {
            DataRow[] dataRowArray = WorkOperClass.ds.workoper.Select("idworkoper  = " + (object)IdWorkOper);
            if (dataRowArray.Length == 0)
                return (ds_workoper.workoperRow)null;
            return (ds_workoper.workoperRow)dataRowArray[0];
        }
    }
}

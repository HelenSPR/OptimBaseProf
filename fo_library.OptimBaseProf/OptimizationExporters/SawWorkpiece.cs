using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;

namespace OptimBaseProf
{
    // Загатовка
    internal class SawWorkpiece
    {
        private readonly DataRow _picRow;
        public readonly List<SawBeam> SawBeamList;

        public readonly int IdOptimDocPic;
        public readonly int IdOptimDoc;

        internal SawWorkpiece(DataRow picRow)
        {
            _picRow = picRow;

            IdOptimDoc = (int)picRow["idoptimdoc"];
            IdOptimDocPic = (int)picRow["idoptimdocpic"];

            SawBeamList = new List<SawBeam>();
        }

        internal string GetString()
        {
            string result = "B,{0},{1},1,{2},{3}";

            string article = (string)_picRow["article"];

            int color1 = (int)_picRow["color1"];
            int color2 = (int)_picRow["color2"];
            string color = string.Format("{0,3}_{1,3}", color1, color2).Replace(" ", "0");

            int length = (int)_picRow["thick"];
            string length1 = string.Format("{0,4}0", length).Replace(" ", "0");
            string length2 = string.Format("{0,4}", length).Replace(" ", "0");

            return string.Format(result, article, color, length1, length2);
        }



        internal void AddBeemWriter(SawBeam beamWriter)
        {
            if (!SawBeamList.Contains(beamWriter))
                SawBeamList.Add(beamWriter);
        }

        // Возвращает описание загатовки и описания напиленых балок из этой загатовки.
        internal string GetPicAndBeamDescription()
        {
            string picText = GetString();

            foreach (var beam in SawBeamList.Where(p=>p.Beam != null))
            {
                picText += "\r\n" + beam.GetString();
            }
            foreach (var beam in SawBeamList.Where(p => p.Beam == null))
            {
                picText += "\r\n" + beam.GetString();
            }

            return picText;
        }
    }



}

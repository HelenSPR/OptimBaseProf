using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace OptimBaseProf
{
    internal class SawDocument
    {
        private readonly DataRow _docRow;

        private readonly List<SawWorkpiece> _SawWorkpieceList;

        // Возвращает загатовку по идентификатору загатовки(рисунка)
        internal SawWorkpiece GetPicWriter(int idOptimDocPic)
        {
            return _SawWorkpieceList.FirstOrDefault(pw => pw.IdOptimDocPic == idOptimDocPic);
        }

        public readonly int IdOptimDoc;

        internal SawDocument(DataRow docRow)
        {
            _docRow = docRow;

            IdOptimDoc = (int)docRow["idoptimdoc"];

            _SawWorkpieceList = new List<SawWorkpiece>();
        }

        internal string WriteString()
        {
            string result = string.Format("L,{0},CUT", _docRow["docname"]);

            return result;
        }

        internal void AddPicWriter(SawWorkpiece sawWorkpiece)
        {
            if (!_SawWorkpieceList.Contains(sawWorkpiece))
                _SawWorkpieceList.Add(sawWorkpiece);
        }

        internal void AddBeamWriter(SawBeam sawBeam)
        {
            var picWriter = _SawWorkpieceList.FirstOrDefault(pw => pw.IdOptimDocPic == sawBeam.IdOptimDocPic);

            if (picWriter != null)
                picWriter.AddBeemWriter(sawBeam);
            else
                throw new Exception("Для балки не создана заготовка. idoptimdocpic = " + sawBeam.IdOptimDocPic);
        }
        /// <summary>
        /// Создает документ заполенынй документ для пилы
        /// </summary>
        /// <param name="folderName">место в котором создается документ</param>
        internal void FillDocument(string folderName)
        {

            var sawBeams = _SawWorkpieceList.SelectMany(item => item.SawBeamList);

            // Создать хранилище балок
            BeamStore store = new BeamStore();
            // Заполнить хранилище балок
            store.FillStore(sawBeams);



            string docText = WriteString();

            foreach (var picWriter in _SawWorkpieceList)
            {
                docText += "\r\n" + picWriter.GetPicAndBeamDescription();
            }

            string fileName = Path.Combine(folderName, (string)_docRow["docname"] + ".txt");

            File.WriteAllText(fileName, docText);
        }
    }
}

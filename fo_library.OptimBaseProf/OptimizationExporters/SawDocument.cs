using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using Atechnology.winDraw.Classes;

namespace OptimBaseProf
{
    public enum TypePerimetr { Rama, Stvorka}
    

    /// <summary>
    /// Документ на сварку
    /// </summary>
    internal class WeldDocument
    {
        private readonly DataRow _docRow;
        private string FileName;

        private int Height;
        private int Width;

        private string Agreename;
        private int NumPos;

        private TypePerimetr Type;

        public virtual string GetDocument(KeyValuePair<int, clsModel> kvp, DataTable beamTable)
        {
            return string.Empty;
        }

        public static void UnloadFile(string Folder, string FileName, string docText)
        {
            string Unload_Path = Path.Combine(Folder, FileName + ".txt");
            File.WriteAllText(Unload_Path, docText);

        }
    }

    /// <summary>
    /// выгрузка на Емиджи
    /// </summary>
    internal class WeldDocument_Emmegi : WeldDocument
    {
        int countPos = 42;
        string SchtrichKod_Format = "000000000000";

        // штрих-коды
        private void GetShtrichKod(IEnumerable<DataRow> beems, string _left, string _top, string _right, string _bottom,
            out string Left, out string Top, out string Right, out string Bottom)
        {
            Left = Top = Right = Bottom = string.Empty;

            foreach (DataRow dr in beems)
            {
                if (dr["modelpart"].ToString() == _left)
                    Left = ((int)dr["idmodelcalc"]).ToString(SchtrichKod_Format);

                if (dr["modelpart"].ToString() == _top)
                    Top = ((int)dr["idmodelcalc"]).ToString(SchtrichKod_Format);

                if (dr["modelpart"].ToString() == _right)
                    Right = ((int)dr["idmodelcalc"]).ToString(SchtrichKod_Format);

                if (dr["modelpart"].ToString() == _bottom)
                    Bottom = ((int)dr["idmodelcalc"]).ToString(SchtrichKod_Format);

            }
        }

        // описани ерамы
        private string GetDescriptionFrame(KeyValuePair<int, clsModel> kvp, DataTable beamTable)
        {
            string result = string.Empty;

            string[] Values = new string[countPos];

            IEnumerable<DataRow> beems = ( beamTable.AsEnumerable()
                                                .Where(br => br.Field<int>("idorderitem") == kvp.Key));
            DataRow beem = beems.FirstOrDefault();

            string left = "", top = "", right = "", bottom = "";

            #region заполнение полей
            if (beem != null)
            {
                Values[0] = "P";
                Values[1] = kvp.Key.ToString();     // StructId: Structure identifier (alphanumeric - optional): it’s a reference for the structure
                Values[2] = "";                     // Piece1: Piece identifier #1 (left) (alphanumeric - optional) : it’s a reference for the piece or the barcode reference
                Values[3] = "";                     // Piece2: Piece identifier #2 (top) (alphanumeric - optional) it’s a reference for the piece or the barcode reference
                Values[4] = "";                     // Piece3: Piece identifier #3 (right) (alphanumeric - optional) it’s a reference for the piece or the barcode reference
                Values[5] = "";                     // Piece4: Piece identifier #4 (bottom) (alphanumeric - optional) it’s a reference for the piece or the barcode reference
                Values[6] = "";                     // Piece5: Piece identifier #5 (1 mullion) (alphanumeric - optional) it’s a reference for the piece or the barcode reference
                Values[7] = "";                     // Piece6: Piece identifier #6 (2 mullion) (alphanumeric - optional) it’s a reference for the piece or the barcode reference
                Values[8] = "1";                    // Templ: Template code (numeric - compulsory): see the below table
                Values[9] = beem["agreename"].ToString();                       // StructDesc: Structure description (alphanumeric - optional)
                Values[10] = beem["numpos"].ToString();                         // StructNumb: Number of equal structures (numeric - compulsory)
                Values[11] = ((int)kvp.Value.Frame.Height).ToString();          // StructH: Structure height (numeric - compulsory)
                Values[12] = ((int)kvp.Value.Frame.Width).ToString();           // StructW: Structure width (numeric - compulsory)
                Values[13] = kvp.Value.ProfileSystem.Name;                      // Serie: Profiles serie (alphanumeric - optional)

                foreach (clsFrame fr in kvp.Value.Frame)
                {
                    if (fr.PositionBeem == Atechnology.winDraw.Model.ItemSide.Left)
                    {
                        left = "Р-" + (fr.VisibleID + 1);
                        Values[14] = fr.Profile.Marking;                        // Code1: Left profile code (alphanumeric - optional)
                        Values[26] = ((int)fr.AngleView).ToString();            // ProgAng1: Special trimming program for angle 1 (numeric – optional): if different than zero it indicates a special trimming program for the specified angle
                    }

                    if (fr.PositionBeem == Atechnology.winDraw.Model.ItemSide.Top)
                    {
                        top = "Р-" + (fr.VisibleID + 1);
                        Values[15] = fr.Profile.Marking;                        // Code2: Top profile code (alphanumeric - optional)
                        Values[27] = ((int)fr.AngleView).ToString();            // ProgAng2: Special trimming program for angle 2 (numeric – optional) if different than zero it indicates a special trimming program for the specified angle
                    }

                    if (fr.PositionBeem == Atechnology.winDraw.Model.ItemSide.Right)
                    {
                        right = "Р-" + (fr.VisibleID + 1);
                        Values[16] = fr.Profile.Marking;                        // Code3: Right profile code (alphanumeric - optional)
                        Values[28] = ((int)fr.AngleView).ToString();            // ProgAng3: Special trimming program for angle 3 (numeric – optional) if different than zero it indicates a special trimming program for the specified angle
                    }

                    if (fr.PositionBeem == Atechnology.winDraw.Model.ItemSide.Bottom)
                    {
                        bottom = "Р-" + (fr.VisibleID + 1);
                        Values[17] = fr.Profile.Marking;                        // Code4: Bottom profile code (alphanumeric - optional)
                        Values[29] = ((int)fr.AngleView).ToString();            // ProgAng4: Special trimming program for angle 4 (numeric – optional) if different than zero it indicates a special trimming program for the specified angle
                    }
                }

                GetShtrichKod(beems, left, top, right, bottom, out Values[2], out Values[3], out Values[4], out Values[5]);

                // Values[18]                       // MullCode1: Mullion 1 profile code (alphanumeric - optional)
                // Values[19]                       // MullCode2: Mullion 2 profile code (alphanumeric - optional)
                // Values[20]                       // MullPos1: Mullion 1 position (numeric – compulsory if exist)
                // Values[21]                       // MullPos2: Mullion 2 position (numeric – compulsory if exist)
                // Values[22]                       // ExtSurfTr: External surface treatment (numeric - optional): it’s 0 if not present, 1 if present
                // Values[23]                       // IntSurfTr: Internal surface treatment (numeric - optional) : it’s 0 if not present, 1 if present
                

                Values[24] = kvp.Value.ColorInside.GetID().ToString() + "_" + kvp.Value.ColorOutside.GetID().ToString();    // Color: Color (alphanumeric - optional)
               // Values[25]

                Values[30] = "1";                   // LoadPos1: Load position 1 (alphanumeric – optional)
                // Values[31]                       // LoadPos2: Load position 2 (alphanumeric - optional)
                Values[32] = "1";                   // UnloadPos1: Unload position 1 (alphanumeric - optional)
                // Values[33]                       // UnloadPos2: Unload position 2 (alphanumeric - optional)
                // Values[34]                       //  Info1: Generic information 1 (alphanumeric - optional)
                // Values[35]                       // Info2: Generic information 2 (alphanumeric - optional)
                // Values[36]                       // Info3: Generic information 3 (alphanumeric - optional)
                // Values[37]                       // Info4: Generic information 4 (alphanumeric - optional)
                // Values[38]                       // Info5: Generic information 5 (alphanumeric - optional)
                // Values[39]                       // Rinf1: presenza rinforzo (0/1 – optional)
                // Values[40]                       // Rinf2: presenza rinforzo (0/1 – optional)
                // Values[41]                       // Rinf3: presenza rinforzo (0/1 – optional)
                // Values[42]                       // Rinf4: presenza rinforzo (0/1 – optional)

            }
            #endregion

            for (int i = 1; i < countPos; i++)
            {
                if (Values[i] == null)
                {
                    Values[i] = string.Empty;
                }
            }

            return result = string.Join(";", Values);

        }

        public override string GetDocument(KeyValuePair<int, clsModel> kvp, DataTable beamTable)
        {
            string Result = GetDescriptionFrame(kvp, beamTable);


            return Result;
        }
    }

    /// <summary>
    /// Выгрузка на Урбан
    /// </summary>
    internal class WeldDocument_Urban : WeldDocument
    {

        public override string GetDocument(KeyValuePair<int, clsModel> kvp, DataTable beamTable)
        {
            string result = string.Empty;

            return result;
        }
    }

    /// <summary>
    /// Документ на пилу
    /// </summary>
    internal class SawDocument
    {
        private readonly DataRow _docRow;

        private readonly List<SawWorkpiece> _SawWorkpieceList;

        private Dictionary<string, int> SumCount = new Dictionary<string, int>();

        // Возвращает загатовку по идентификатору загатовки(рисунка)
        internal SawWorkpiece GetPicWriter(int idOptimDocPic)
        {
            return _SawWorkpieceList.FirstOrDefault(pw => pw.IdOptimDocPic == idOptimDocPic);
        }

        public SawWorkpiece GetNext(List<SawBeam> Prev, string Article, int IdColor1, int IdColor2)
        {
            if (_SawWorkpieceList.Count == 0) return null;
            SawWorkpiece result = _SawWorkpieceList[0];

            if (Prev != null)
            {

                // поиск балки в которой наибольшее кол-во отрезков из предыдущей
                result = Next(Prev, Article, IdColor1, IdColor2);
                if (result == null)
                    result = Next1(Prev, Article, IdColor1, IdColor2);

                if (result == null && _SawWorkpieceList.Count > 0)
                    result = _SawWorkpieceList[0];
            }

           // _SawWorkpieceList.Remove(result);
            return result;
        }

        #region тесты по подаче\запросу
        // по наибольшему вхождению
        private SawWorkpiece Next1(List<SawBeam> Prev, string Article, int IdColor1, int IdColor2)
        {
            int count_in = 0;
            int count_in_prev = 0;
            SawWorkpiece result = null;

            List<SawWorkpiece> ArrayArticle = this._SawWorkpieceList.Where(p => p.Article == Article && p.IdColor1 == IdColor1 && p.IdColor2 == IdColor2).ToList();
            if (ArrayArticle.Count == 0)
                return this._SawWorkpieceList[0];

            foreach (SawWorkpiece sw in this._SawWorkpieceList.Where(p => p.Article == Article))
            {
                count_in = 0;

                foreach (SawBeam sb in sw.SawBeamList)
                {
                    foreach (SawBeam sb_prev in Prev)
                    {
                        if (sb_prev.ManufactName == sb.ManufactName && sb_prev.NumPos == sb.NumPos)
                        {
                            count_in++;
                        }
                    }
                }

                if (count_in_prev < count_in)
                {
                    count_in_prev = count_in;
                    result = sw;
                }


            }

            return result;
        }

        // по замкнутости контура
        private void ClearSumCount()
        {
            foreach (string key in SumCount.Keys)
            {
                int value = 0;
                SumCount.TryGetValue(key, out value);
                if ( value >= 4)
                    SumCount.Remove(key);

            }

        }

        #endregion

        private SawWorkpiece Next(List<SawBeam> Prev, string Article, int IdColor1, int IdColor2)
        {
            ClearSumCount();

            int count_in = 0;
            int count_in_prev = 0;
            SawWorkpiece result = null;

            List<SawWorkpiece> ArrayArticle = this._SawWorkpieceList.Where(p => p.Article == Article && p.IdColor1 == IdColor1 && p.IdColor2 == IdColor2).ToList();
            if (ArrayArticle.Count == 0)
                result = this._SawWorkpieceList[0];

            foreach (SawWorkpiece sw in this._SawWorkpieceList.Where(p => p.Article == Article && p.IdColor1 == IdColor1 && p.IdColor2 == IdColor2))
            {
                count_in = 0;

                foreach (SawBeam sb in sw.SawBeamList)
                {
                    foreach (string key in SumCount.Keys)
                    {
                        string num = key.Substring(0, key.IndexOf("*"));
                        string manufactname = key.Substring(key.IndexOf("*") + 1);
                        if (sb.ManufactName == manufactname && sb.NumPos == num)
                        {
                            if(SumCount[key] == 3)
                                count_in++;
                        }
                    }
                }

                if (count_in_prev < count_in)
                {
                    count_in_prev = count_in;
                    result = sw;
                }


            }


            if (count_in_prev == 0)
                result = null;

            if (result != null)
            {
                string key = string.Empty;
                int value = 0;

                foreach (SawBeam saw in result.SawBeamList)
                {
                    key = saw.NumPos.ToString() + "*" + saw.ManufactName;
                    value = 0;

                    if (SumCount.ContainsKey(key))
                    {
                        SumCount.TryGetValue(key, out value);
                        SumCount[key] = value + 1;

                        
                    }
                    else
                        SumCount.Add(key, 1);
                }
            }


            return result;
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

            //Dictionary<string, string> Files = new Dictionary<string, string>();
            //string midfileName;
            int IdColor1, IdColor2;

            #region Простой перебор всех балок
            /*foreach (var picWriters in _SawWorkpieceList)
            {
                docText += "\r\n" + picWriters.GetPicAndBeamDescription();
            }
            string fileNames = Path.Combine(folderName, (string)_docRow["docname"] + ".txt");
            File.WriteAllText(fileNames, docText);

            return; */
            #endregion



            SawWorkpiece picWriter = GetNext(null, string.Empty, 0, 0);
            while (picWriter != null)
            {
                /*string filename;

                if (picWriter.IdColor1 != 1 || picWriter.IdColor2 != 1)
                {
                    filename = "_color_" + picWriter.IdColor1 + "_" + picWriter.IdColor2;
                }
                else
                    filename = "";

                if (Files.ContainsKey(filename))
                    Files[filename] += "\r\n" + picWriter.GetPicAndBeamDescription();
                else
                {
                    Files.Add(filename, WriteString() + "\r\n" + picWriter.GetPicAndBeamDescription());
                }
*/
                docText += "\r\n" + picWriter.GetPicAndBeamDescription();

                List<SawBeam> SB = picWriter.SawBeamList;
                string Article = picWriter.Article;
                IdColor1 = picWriter.IdColor1;
                IdColor2 = picWriter.IdColor2;

                _SawWorkpieceList.Remove(picWriter);
                picWriter = GetNext(SB, Article, IdColor1, IdColor2);

            }

            /*foreach (KeyValuePair<string, string> kvp in Files)
            {
                string fileName = Path.Combine(folderName, (string)_docRow["docname"] + kvp.Key + ".txt");
                File.WriteAllText(fileName, kvp.Value);
            }*/
            
            string fileName = Path.Combine(folderName, (string)_docRow["docname"] + ".txt");
            File.WriteAllText(fileName, docText);
        }
    }
}

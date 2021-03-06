﻿using Atechnology.winDraw.Classes;
using Atechnology.winDraw.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace OptimBaseProf
{
    public class Weld
    {

        public string ConstructionName {    get
            { return AgreeName + " " + NumPos; }
                                        }

        string AgreeName;
        string NumPos;
        int idorderitem;
        clsModel model;

        string[] EmigySctrichKode = new string[6];




    }


    internal class SawBeam
    {

        internal IBeamStore<SawBeam> Store { get; set; }

        internal SawBeam(DataRow beamRow, clsModel model)
        {
            _beamRow = beamRow;
            Model = model;
            _Beam = _GetBeam();

            // Заполнение идентификаторов для связи с документами и загатовками.
            IdOptimDoc = (int)_beamRow["idoptimdoc"];
            IdOptimDocPic = (int)_beamRow["idoptimdocpic"];
            IdOptimDocPos = (int)_beamRow["idoptimdocpos"];
            ManufactName = (string)_beamRow["manufact_name"];
        }

        //E.S. OSTATOK
        internal SawBeam(DataRow beamRow)
        {
            _beamRow = beamRow;
            Model = null;
            _Beam = null;

            // Заполнение идентификаторов для связи с документами и загатовками.
            IdOptimDoc = (int)_beamRow["idoptimdoc"];
            IdOptimDocPic = (int)_beamRow["idoptimdocpic"];
            IdOptimDocPos = (int)_beamRow["idoptimdocpos"];
            ManufactName = (string)_beamRow["manufact_name"];
            RemPartName = _beamRow["modelpart"] == DBNull.Value ? "" : (string)_beamRow["modelpart"];
        }

        internal SawBeam(DataRow beamRow, clsModel model, int Qu)
        {
            _beamRow = beamRow;
            Model = model;
            // _qu = Qu;
            _Beam = _GetBeam();

            // Заполнение идентификаторов для связи с документами и загатовками.
            IdOptimDoc = (int)_beamRow["idoptimdoc"];
            IdOptimDocPic = (int)_beamRow["idoptimdocpic"];
            IdOptimDocPos = (int)_beamRow["idoptimdocpos"];
            ManufactName = (string)_beamRow["manufact_name"];
        }

        // Идентификаторы для связи с документами и загатовками.
        internal readonly int IdOptimDoc;
        internal readonly int IdOptimDocPic;
        internal readonly int IdOptimDocPos;
        internal readonly string ManufactName; // Номер производственного задания.
        internal readonly string RemPartName;      // заполняется для остатков: тип остатка: импост, рама, створка
        internal string File_DocName{get; set;}
        // private int _qu;     // количество таких изделий
        public string RemainderName { get { return _beamRow["remaindername"].ToString(); } }
        public string ModelPartName { get { return _beamRow["modelpart"].ToString(); } }

        public clsBeem ClsBeem
        {
            get
            {
                return _Beam;
            }
        }

        private DataRow _beamRow;



        private readonly clsModel Model;

        private readonly clsBeem _Beam;

        public clsBeem Beam
        {
            get
            {
                return _Beam;
            }

        }

        private clsBeem _GetBeam()
        {
            string modelPart = (string)_beamRow["modelpart"];

            //if (modelPart != "OSTATOK")
            //{

                // Получить "номер" балки из спецификации(modelcalc).
                // удаляем первые два символа("C-" или "Р-" или "И-").
                int numberBeam = Convert.ToInt32(modelPart.Remove(0, 2));

                // Предположительно, что "порядковый номер + 1" балки из модели соответствует номеру балки из спецификации(modelcalc) в поле modelpart(Это касается балок Рамы из Frame, балок Створки - Leaf и балок Импоста Imposts).
                if (modelPart.StartsWith("Р-"))
                {
                    return Model.Frame[numberBeam - 1];
                }

                if (modelPart.StartsWith("C-") || modelPart.StartsWith("С-"))
                {
                    // Может быть несколько створок
                    return Model.Leafs.SelectMany(l => l).ToArray()[numberBeam - 1];
                }

                if (modelPart.StartsWith("И-"))
                {
                    try
                    {
                        return Model.Imposts[numberBeam - 1];
                    }
                    catch
                    {
                        return null;
                    }
                }

            /*}
            else
            {
                //OSTATOK
                return 0;
            }*/


            string exceptionMessage = String.Format("Не удалось определить тип балки. idmodelcalc = {0}.", (int)_beamRow["idmodelcalc"]);

            throw new Exception(exceptionMessage);
        }

        private string GetField12()
        {
            //return string.Format("{0,8}{1,5}", ManufactName, NumPos);
            return  _beamRow["c1kod"].ToString();
        }

        private string GetField23_Reminder()
        {
            return string.Format("{0,8}{1,5}{2,4}", DateTime.Now.ToString("yyyyMMdd"), string.Empty, string.Empty);
        }
        private string GetField23()
        {
           // return string.Format("{0,8}{1,5}{2,4}", ManufactName, NumPos, LayoutArea);
            return string.Format("{0,8}{1,5}{2,4}", _beamRow["agreename"].ToString(), NumPos, LayoutArea);
        }

        private string GetField24()
        {
            int arm_thick = (int)_beamRow["arm_thick"];

            if (this._Beam != null)
                return string.Format("{0,4}  {1} {2,4}", (int)_beamRow["thick"] - (int)_beamRow["welding_seam"], Position, arm_thick);
            // return string.Format("{0,4}  {1} {2,4}", (int)_beamRow["thick"], Position, arm_thick);
            else
                return string.Format("{0,4}  {1} {2,4}", (int)_beamRow["thick"] - (int)_beamRow["welding_seam"], _beamRow["agreename"], arm_thick);
        }

        private string GetField25_Reminder()
        {
            return string.Concat(GetCartNumber(), "-", GetCellNumber());
        }

        private string GetField25()
        {
            if (Model == null) return string.Empty;
            // ---------------------------Номер тележки и ячейки ------------------------------
            string result = string.Concat(GetCartNumber(), "-", GetCellNumber()); // Номер телеги и ячейки

           // if (this._Beam == null) return result;

            // ------------------- Толщина заполения -----------------------------

            // Получить заполнители, для этой балки
            // Логика: Взять заполнители из модели с типом "Стеклопакет" или "Сэндвич"
            // и соприкасающийся с текущей балкой()
            var regions = Model.VisibleRegions.Where(

                                                        region => (region.Fill.FillType != FillType.NotFill) // Любой другой отличный от NotFill будет либо сэндвич(Sandwich) либо стеклопакет(GlassPack, Unknown). PuzzleFill - не встречался.
                                                        && region.FillConture.SelectMany(conture => conture.Beams).FirstOrDefault(beam => beam == _Beam) != null);

            // Если есть заполнение
            if (regions.Any())
            {
                var thicknes = regions.Select(f => f.Fill.Thikness).Distinct();

                if (thicknes.Count() == 1)
                {
                    // Если количество уникальных толщина заполенения 1 то выводим ее.
                    result += "  " + thicknes.First();
                }
            }


            // -------------------------Указываем позицию ручки для створки с ручкой

            // Для балки створки указываем позицию ручки.
            if (_Beam.BalkaType == ModelPart.StvorkaItem)
            {
                int handlePosition = ((clsLeafBeem)_Beam).PosHandle;
                if (handlePosition != 0 && ((clsLeafBeem)_Beam).Leaf.HandleType != Atechnology.winDraw.HandleType.Нет_ручки)
                {
                    result += "  R:" + handlePosition.ToString();
                    if (Math.Abs(((int)_beamRow["thick"] - (int)_beamRow["welding_seam"] ) / 2 - handlePosition) <= 1)
                        result += " [1/2]";
                }
            }

            return result;
        }

        private string GetField27_old()
        {
            //if (this._Beam == null) return string.Empty;
            #region
            //if (_Beam.BalkaType == ModelPart.RamaItem && _Beam.ConnectImpostPoints.Count() > 0)
            //{
            //    if (_Beam.PositionBeem == ItemSide.Top || _Beam.PositionBeem == ItemSide.Bottom)//Верх низ
            //    {
            //        return _Beam.ConnectImpostPoints
            //            .Select(i => i.x)
            //            .OrderBy(x => x)
            //            .Select(x => x.ToString())
            //            .Aggregate((result, x) => result += "/" + x);
            //    }
            //    else // Лево, право
            //    {
            //        return _Beam.ConnectImpostPoints
            //            .Select(i => i.y)
            //            .OrderBy(y => y)
            //            .Select(y => y.ToString())
            //            .Aggregate((result, y) => result += "/" + y);
            //    }

            //    return string.Empty;
            //}
            //else
            //{
            //    return string.Empty;
            //}

            #endregion


            #region old 14/04/2016
            /* List<double> distances = new List<double>();

            // Получить точки соприкосновения балки с импостами для горизонтальных балок
            var impostPointsX = _Beam.ConnectImpostPointsRealX;

            foreach (clsPoint xPoint in impostPointsX)
            {
                double x = 0;
                if (_Beam.BalkaType == ModelPart.Impost)
                {
                    // Эта точка оперделена методом подбора, т.к. Point1 не подшла
                    x = _Beam.LineC1.x1;
                }
                else
                {
                    x = _Beam.Point1.x;
                }

                double distance = Math.Abs(x - xPoint.x);

                distances.Add(distance);

            }
            
            
            // Получить точки соприкосновения балки с импостами для вертикальных балок
            var impostPointsY = _Beam.ConnectImpostPointsRealY;

            foreach (clsPoint yPoint in impostPointsY)
            {
                double y = 0;
                if (_Beam.BalkaType == ModelPart.Impost )
                {
                    // Эта точка оперделена методом подбора, т.к. Point1 не подшла
                    y = _Beam.LineC1.y1;
                }
                else
                {
                    y = _Beam.Point1.y;
                }

                double distance = Math.Abs(y - yPoint.y);

                distances.Add(distance);
            } */
            #endregion


            List<double> distances = new List<double>();
            // Получить точки соприкосновения балки с импостами для горизонтальных балок
            var impostPointsX = _Beam.ConnectImpostPointsRealX;                             
            List<double> BufXList = new List<double>();

            // массив точек
            foreach (clsPoint xPoint in impostPointsX)
            {
                BufXList.Add( xPoint.x);
            }

            if (BufXList.Count > 0)
            {
                BufXList.Sort();        // Сортировка на всякий случай

                double x = 0;
                if (_Beam.BalkaType == ModelPart.Impost)
                {
                    // Эта точка оперделена методом подбора, т.к. Point1 не подшла
                    x = _Beam.LineC1.x1;
                }
                else
                {
                    x = _Beam.Point1.x;
                }
                double delta = Math.Abs(x - _Beam.Lenght);      // отступ
                distances.Add(Math.Abs(BufXList[0] - delta));   // первый импост
                double midlpoint = BufXList[0];                 // точка предыдущего импоста

                for (int j = 1; j < BufXList.Count; j++)
                {
                    distances.Add(Math.Abs(BufXList[j] - midlpoint));
                    midlpoint = BufXList[j];
                }

                distances.Add(Math.Abs(x - BufXList[BufXList.Count - 1]));
            }
            // Описание растояний на которых нужно сделать "надпилы" у балок
            //string result = distances.Aggregate((r, d) => r += "/" + d.ToString());

            // Получить точки соприкосновения балки с импостами для вертикальных балок
            var impostPointsY = _Beam.ConnectImpostPointsRealY;
            List<double> BufYList = new List<double>();

            // массив точек
            foreach (clsPoint yPoint in impostPointsY)
            {
                BufYList.Add(yPoint.y);
            }

            if (BufYList.Count > 0)
            {
                BufYList.Sort();        // Сортировка на всякий случай

                double y = 0;
                if (_Beam.BalkaType == ModelPart.Impost)
                {
                    // Эта точка оперделена методом подбора, т.к. Point1 не подшла
                    y = _Beam.LineC1.y1;
                }
                else
                {
                    y = _Beam.Point1.y;
                }
                double delta = Math.Abs(y - _Beam.Lenght);      // отступ
                distances.Add(Math.Abs(BufYList[0] - delta));   // первый импост
                double midlpoint = BufYList[0];                 // точка предыдущего импоста

                for (int j = 1; j < BufYList.Count; j++)
                {
                    distances.Add(Math.Abs(BufYList[j] - midlpoint));
                    midlpoint = BufYList[j];
                }

                distances.Add(Math.Abs(y - BufYList[BufYList.Count - 1]));
            }




            string result = string.Join("/", distances.Select(d => Math.Round(d).ToString()).ToArray());

            return result;
        }

        private string GetField27()
        {
            string result = string.Empty;
            List<double> distances = new List<double>();

            if (_beamRow["leng"] != DBNull.Value && _beamRow["imppos"] != DBNull.Value)
            {
                int length = (int)_beamRow["leng"];
                List<int> imppos = _beamRow["imppos"].ToString().Split(',').Select(p => int.Parse(p)).ToList();

                imppos.Sort();

                if ((_Beam.x1 >= _Beam.x2 && _Beam.y1 >= _Beam.y2) ||
                    (_Beam.BalkaType == ModelPart.Impost && _Beam.x1 <= _Beam.x2 && _Beam.y1 <= _Beam.y2))
                {
                    distances.Add(imppos[0]);   // первый импост
                    double midlpoint = imppos[0];                 // точка предыдущего импоста

                    for (int j = 1; j < imppos.Count; j++)
                    {
                        distances.Add(Math.Abs(imppos[j] - midlpoint));
                        midlpoint = imppos[j];
                    }

                    distances.Add(Math.Abs(length - imppos[imppos.Count - 1]));
                }
                else
                {
                    
                        int cnt = imppos.Count - 1;
                        distances.Add(length - imppos[cnt]);                     // первый импост
                        double midlpoint = imppos[cnt];                          // точка предыдущего импоста

                        for (int j = cnt - 1; j >= 0; j--)
                        {
                            distances.Add(Math.Abs(midlpoint - imppos[j]));
                            midlpoint = imppos[j];
                        }

                        distances.Add(Math.Abs(imppos[0]));
                    }
                
            }

            return distances.Count > 0 ? this.CutPosition + " " + string.Join(" / ", distances.Select(d => Math.Round(d).ToString()).ToArray()) : string.Empty;
        }

        // Возвращает область расположения на Рисунке
        public string LayoutArea
        {
            get
            {
                if (_Beam == null) return string.Empty;
                //OSTATOK
               // if (_Beam == null)
                    //return "0";

                // Балка рамы
                if (_Beam.BalkaType == ModelPart.RamaItem)
                    return "1";

                // Балка створки
                if (_Beam.BalkaType == ModelPart.StvorkaItem)
                {

                    clsLeafBeem beam = (clsLeafBeem)_Beam;

                    string leafNumber = string.Concat("S", beam.Leaf.Name.Remove(0, 8));

                    return leafNumber;
                }

                // Импост
                if (_Beam.BalkaType == ModelPart.Impost || _Beam.BalkaType == ModelPart.Shtulp)
                {
                    string modelPart = (string)_beamRow["modelpart"];
                    // Получить "номер" балки-импоста из спецификации(modelcalc).
                    // Удаляем "И-".
                    int impostNumber = Convert.ToInt32(modelPart.Remove(0, 2));


                    clsImpost impost = (clsImpost)_Beam;

                    string impostMark = string.Empty;

                    // Если есть створка то, один тип маркировки
                    if (impost.Leaf != null)
                    {
                        string leafMarkName = impost.Leaf.Name.Replace("Створка ", "S");


                        impostMark = string.Concat(leafMarkName, "_", impostNumber);
                    }
                    else // Нет створки - другой тип маркировки
                    {
                        impostMark = string.Concat("R_", impostNumber);
                    }

                    return impostMark;
                }

                string exceptionMessage = String.Format("Не возможно определить маркировку. idmodelcalc = {0}", _beamRow["idmodelcalc"]);
                throw new Exception(exceptionMessage);
            }
        }


        public string Position
        {
            get
            {
               // if (_Beam == null) return "OSTATOK";

                if (_Beam.BalkaType == ModelPart.RamaItem || _Beam.BalkaType == ModelPart.StvorkaItem)
                {
                    //return _Beam.PositionBeem.ToString();
                    switch (_Beam.PositionBeem.ToString().ToUpper())
                    {
                        case "BOTTOM": return "NIZ"; 
                        case "TOP": return "VERH"; 
                        case "LEFT": return "LEVO"; 
                        case "RIGHT": return "PRAVO"; 
                        default: return "OTHER";
                    }
                }

                if (_Beam.BalkaType == ModelPart.Impost || _Beam.BalkaType == ModelPart.Shtulp)
                {
                    if (_Beam.Point1.x == _Beam.Point2.x)
                        return "VERT.";
                        
                    else if (_Beam.Point1.y == _Beam.Point2.y)
                        return "GORIZ.";
                        
                    return "Other";
                }

                throw new Exception("Не удалось определить позицию балки из того, что не удалось определить тип балки");
            }
        }


        public string CutPosition
        {
            get
            {
                // if (_Beam == null) return "OSTATOK";

                if (_Beam.BalkaType == ModelPart.RamaItem || _Beam.BalkaType == ModelPart.StvorkaItem)
                {
                    //return _Beam.PositionBeem.ToString();
                    switch (_Beam.PositionBeem.ToString().ToUpper())
                    {
                        case "BOTTOM": return "N";
                        case "TOP": return "V";
                        case "LEFT": return "L";
                        case "RIGHT": return "P";
                        default: return "O";
                    }
                }

                if (_Beam.BalkaType == ModelPart.Impost || _Beam.BalkaType == ModelPart.Shtulp)
                {
                    if (_Beam.Point1.x == _Beam.Point2.x)
                        return "V.";

                    else if (_Beam.Point1.y == _Beam.Point2.y)
                        return "G.";

                    return "O";
                }

                throw new Exception("Не удалось определить позицию балки из того, что не удалось определить тип балки");
            }
        }


        // Номер позиции изделия(в которое входит створка) в заказе
        public string NumPos
        {
            get
            {
                string numPos = _beamRow["numpos"].ToString();
                return numPos;
            }
        }

        public int Num
        {
            get {
                if (NumPos.IndexOf("-") < 0)
                    return 1;
                else
                {
                    string buf = NumPos.Substring(NumPos.IndexOf("-") + 1);
                    return Int16.Parse(buf);
                }
            }

        }

        public bool IsRemark;


        public CartCell<SawBeam> CartCell
        {
            get
            {
                if (Store != null)
                {
                    return Store.GetCartCell(this);
                }
                else return new CartCell<SawBeam>();
            }
        }

        private string GetCartNumber()
        {
            if (CartCell != null)
                return CartCell.CartNumberString;
            else
                return string.Empty;
        }

        private string GetCellNumber()
        {
            if (CartCell != null)
                return CartCell.CellNumberString;
            else
                return string.Empty;
        }

        // Возращает строку с информацией по балке выводимую в конечный документ
        public string GetString()
        {
            //if (this._Beam.BalkaType == ModelPart.Porog)
              //  return string.Empty;

            if (this._Beam == null && this.RemainderName != string.Empty) return GetString_Reminder();
            else return GetString_partcutting();

        }
        public string GetString_Reminder()
        {
            int countPos = 28;
            string[] Values = new string[countPos];
            Values[1] = "P";
            Values[2] = ((int)_beamRow["thick"]).ToString("0000") + "0";
            Values[3] = string.Empty;
            Values[4] = "0900";
            Values[5] = "0900";
            Values[6] = _beamRow["modelpart"].ToString().Contains("_OTHOD_") ? "" : GetCartNumber(); // Номер телеги
            Values[7] = _beamRow["modelpart"].ToString().Contains("_OTHOD_") ? "" : GetCellNumber(); // Номер ячейки
            Values[8] = string.Empty;
            Values[9] = _beamRow["remaindername"].ToString();
            Values[10] = string.Empty;
            Values[11] = string.Empty;
            Values[12] = string.Empty; // modelpart
            Values[13] = string.Empty;
            Values[14] = string.Empty;
            Values[15] = string.Empty;
            Values[16] = string.Empty;
            Values[17] = string.Empty;
            Values[18] = string.Empty;
            Values[19] = string.Empty;
            Values[20] = string.Empty;
            Values[21] = string.Empty;
            Values[22] = (Int64.Parse(_beamRow["bar_code"].ToString())).ToString("000000000000000000000");
            Values[23] = GetField23_Reminder();
            Values[24] = string.Empty;
            Values[25] = _beamRow["modelpart"].ToString().Contains("_OTHOD_") ? "" : GetField25_Reminder();
            Values[26] = File_DocName;//(string)_beamRow["profilename"];

            string result = string.Join(",", Values).Remove(0, 1);
            return result;
        }

        public string GetAngle(decimal Ang)
        {
            string result = string.Empty;
            int iAng = (int)(Math.Round(Ang));

            switch (iAng)
            {
                case 45: result = "0450"; break;
                case 135: result = "1350"; break;
                default: result = "0900"; break;
            }

            return result;
        }


        public string GetString_partcutting()
        {

            int countPos = 28;
            string[] Values = new string[countPos];
            Values[1] = "P";
            Values[2] = ((int)_beamRow["thick"]).ToString("0000") + "0"; // Длина балки
            // Values[2] = string.Concat((int)_beamRow["thick"], "0"); // Длина балки(плюс на конце ноль)
            Values[3] = string.Empty;

            if (_Beam == null)
            {
                Values[4] = "90";
                Values[5] = "90";
            }
            else if (_Beam.BalkaType != ModelPart.RamaItem)
            {
                Values[4] = GetAngle(180 - (_Beam == null ? 90 : _Beam.Cutting_Angle1));//(180 - _Beam.Cutting_Angle1).ToString("000.0").Replace(",", "");
                Values[5] = GetAngle(_Beam == null ? 90 : _Beam.Cutting_Angle2);// _Beam.Cutting_Angle2.ToString("000.0").Replace(",", "");
            }
            else
            {
                Values[4] = GetAngle(180 - (_Beam == null ? 90 : _Beam.Cutting_Angle2));//(180 - _Beam.Cutting_Angle1).ToString("000.0").Replace(",", "");
                Values[5] = GetAngle(_Beam == null ? 90 : _Beam.Cutting_Angle1);// _Beam.Cutting_Angle2.ToString("000.0").Replace(",", "");
            }
            // Values[4] = (180 - _Beam.Cutting_Angle1).ToString("F").Replace(",", ".");
            //  Values[5] = _Beam.Cutting_Angle2.ToString("F").Replace(",", ".");
            Values[6] = GetCartNumber(); // Номер телеги
            Values[7] = GetCellNumber(); // Номер ячейки
            Values[8] = string.Empty;
            Values[9] = _Beam == null ? string.Empty : _Beam.BalkaType.ToString().Replace("Item", string.Empty);
            Values[10] = string.Empty;
            Values[11] = string.Empty;
            Values[12] = GetField12(); //(string)_beamRow["agreename"];
            Values[13] = string.Empty;
            Values[14] = string.Empty;
            Values[15] = string.Empty;
            Values[16] = string.Empty;
            Values[17] = string.Empty;
            Values[18] = string.Empty;
            Values[19] = string.Empty;
            Values[20] = string.Empty;
            Values[21] = string.Empty;
            Values[22] = (string)_beamRow["bar_code"];
            Values[23] = GetField23();
            Values[24] = GetField24();
            Values[25] = GetField25();
            Values[26] = File_DocName; // _Beam == null ? "" : _Beam.Profile.Marking;     // Тип профиля
            Values[27] = GetField27();             // Положение импростов на балке


            for (int i = 1; i < countPos; i++)
            {
                if (Values[i] == null)
                {
                    Values[i] = string.Concat("Не заполнено. пос: ", i);
                }
            }

            string result = string.Join(",", Values).Remove(0, 1);
            return result;
        }


    }
}

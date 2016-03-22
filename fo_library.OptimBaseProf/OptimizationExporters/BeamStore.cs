﻿using Atechnology.winDraw.Classes;
using Atechnology.winDraw.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OptimBaseProf
{
    internal class BeamStore : IBeamStore<SawBeam>
    {
        private static int _MAX_COUNT_REMAINDER_LEAF = 10;
        private static int _MAX_COUNT_REMAINDER_FRAME = 10;
        private static int _MAX_COUNT_REMAINDER_IMPOST = 10;
        // Словарь створок со значение номеров ячеек и тележек для балок, входящих в эти створки.
        private Dictionary<clsLeaf, CartCell<SawBeam>> leafCartCellNumber = new Dictionary<clsLeaf, CartCell<SawBeam>>();
        private int leafCartNumber = 1;
        private int leafCellNumber = 0;

        // Словарь модели со значение номеров ячеек и тележек для балок рамы, входящ в эту модель.
        private Dictionary<clsModel, CartCell<SawBeam>> modelCartCellNumber = new Dictionary<clsModel, CartCell<SawBeam>>();
        private int frameCartNumber = 1;
        private int frameCellNumber = 0;

        // Словарь произовдственный номер со значение номеров ячеек и тележек для импостов входящих в договор с таким номером.
        private List<KeyValuePair<string, CartCell<SawBeam>>> manufactNameCartCellNumberList = new List<KeyValuePair<string, CartCell<SawBeam>>>();
        private int impostCartNumber = 1;
        private int impostCellNumber = 0;

        // Словарь произовдственный номер со значение номеров ячеек и тележек для остатков 
        private List<KeyValuePair<string, CartCell<SawBeam>>> OstatokCartCellNumberList_Leaf = new List<KeyValuePair<string, CartCell<SawBeam>>>();
        private int OstatokCartNumber_Leaf = 1;
        private int OstatokCellNumber_Leaf = 0;

        private List<KeyValuePair<string, CartCell<SawBeam>>> OstatokCartCellNumberList_Rama = new List<KeyValuePair<string, CartCell<SawBeam>>>();
        private int OstatokCartNumber_Rama = 1;
        private int OstatokCellNumber_Rama = 0;

        private List<KeyValuePair<string, CartCell<SawBeam>>> OstatokCartCellNumberList_Impost = new List<KeyValuePair<string, CartCell<SawBeam>>>();
        private int OstatokCartNumber_Impost = 1;
        private int OstatokCellNumber_Impost = 0;

        // Получить ячейку в которой лежить балка
        public CartCell<SawBeam> GetCartCell(SawBeam sawBeam)
        {
            if (sawBeam.ClsBeem == null) // ostatok
            {
                if (sawBeam.RemPartName.Contains("И-"))
                {
                    var kvPair = OstatokCartCellNumberList_Impost.FirstOrDefault(kv => kv.Key == "RemImpost"
                                                                                               && kv.Value.FirstOrDefault(beam => beam == sawBeam) != null);
                    if (kvPair.Key != null)
                        return kvPair.Value;
                }
                if (sawBeam.RemPartName.Contains("C-") || sawBeam.RemPartName.Contains("С-"))
                {
                    var kvPair = OstatokCartCellNumberList_Leaf.FirstOrDefault(kv => kv.Key == "RemLeaf"
                                                                                               && kv.Value.FirstOrDefault(beam => beam == sawBeam) != null);
                    if (kvPair.Key != null)
                        return kvPair.Value;
                }
                if (sawBeam.RemPartName.Contains("Р-"))
                {
                    var kvPair = OstatokCartCellNumberList_Rama.FirstOrDefault(kv => kv.Key == "RemFrame"
                                                                                              && kv.Value.FirstOrDefault(beam => beam == sawBeam) != null);
                    if (kvPair.Key != null)
                        return kvPair.Value;
                }
            }
            else
            {
                if (sawBeam.ClsBeem.BalkaType == ModelPart.StvorkaItem)
                {
                    clsLeaf leaf = ((clsLeafBeem)sawBeam.ClsBeem).Leaf;

                    if (leafCartCellNumber.ContainsKey(leaf))
                    {
                        return leafCartCellNumber[leaf];
                    }

                    throw new Exception("Балка створки отсутствует в хранилище. idoptimdocpos = " + sawBeam.IdOptimDocPos);
                }

                if (sawBeam.ClsBeem.BalkaType == ModelPart.RamaItem)
                {
                    if (modelCartCellNumber.ContainsKey(sawBeam.ClsBeem.Model))
                    {
                        return modelCartCellNumber[sawBeam.ClsBeem.Model];
                    }

                    throw new Exception("Балка рамы отсутствует в хранилище. idoptimdocpos = " + sawBeam.IdOptimDocPos);
                }

                if (sawBeam.ClsBeem.BalkaType == ModelPart.Impost || sawBeam.ClsBeem.BalkaType == ModelPart.Shtulp)
                {
                    var kvPair = manufactNameCartCellNumberList.FirstOrDefault(kv => kv.Key == sawBeam.ManufactName
                                                                                               && kv.Value.FirstOrDefault(beam => beam == sawBeam) != null);
                    if (kvPair.Key != null)
                        return kvPair.Value;

                    throw new Exception("В хранилище не найдена ячейка для данного импоста. idoptimdocpos = " + sawBeam.IdOptimDocPos);
                }
            }

            throw new Exception("При размещении в хранилище тип балки не определен. idoptimdocpos = " + sawBeam.IdOptimDocPos);
        }

        // Заполнение хранилища балками
        public void FillStore(IEnumerable<SawBeam> sawBeams)
        {
            var beams = sawBeams
                .OrderBy(beam => beam.ManufactName);
            //.Select(beam => beam.ClsBeem);

            foreach (var beam in beams)
            {
                if (beam.ClsBeem == null)
                {
                    PutOstatok(beam);
                }
                else
                {
                    if (beam.ClsBeem.BalkaType == ModelPart.StvorkaItem)
                    {
                        PutLeafBeam(beam);
                    }

                    if (beam.ClsBeem.BalkaType == ModelPart.RamaItem)
                    {
                        PutFrameBeam(beam);
                    }

                    if (beam.ClsBeem.BalkaType == ModelPart.Impost || beam.ClsBeem.BalkaType == ModelPart.Shtulp)
                    {
                        PutImpost(beam);
                    }
                }
                
                beam.Store = this;
            }
        }



        // положить балку створки в ячейку
        private void PutLeafBeam(SawBeam sawBeam)
        {

            if (!leafCartCellNumber.ContainsKey(((clsLeafBeem)sawBeam.ClsBeem).Leaf))
            {
                if (++leafCellNumber == 11)
                {
                    leafCellNumber = 1;
                    leafCartNumber++;
                }

                CartCell<SawBeam> cartCell = new CartCell<SawBeam>(leafCartNumber, leafCellNumber, "F", string.Empty);

                leafCartCellNumber.Add(((clsLeafBeem)sawBeam.ClsBeem).Leaf, cartCell);
            }
        }

        // положить балку рамы в ячейку
        private void PutFrameBeam(SawBeam sawBeam)
        {
            if (!modelCartCellNumber.ContainsKey(sawBeam.ClsBeem.Model))
            {
                if (++frameCellNumber == 11)
                {
                    frameCellNumber = 1;
                    frameCartNumber++;
                }

                CartCell<SawBeam> cartCell = new CartCell<SawBeam>(frameCartNumber, frameCellNumber, "B", string.Empty);

                modelCartCellNumber.Add(sawBeam.ClsBeem.Model, cartCell);
            }
        }

        // положить импост в ячейку
        private void PutImpost(SawBeam sawBeam)
        {

            // получить ячейку с таким же пр. номером и количество балок в ней меньшае 8.
            var manufactOldEmptyCartCell = manufactNameCartCellNumberList
                .FirstOrDefault(kv => kv.Key == sawBeam.ManufactName && kv.Value.Count() != 8);

            if (manufactOldEmptyCartCell.Key != null)
            {
                manufactOldEmptyCartCell.Value.Add(sawBeam);
            }
            else // Иначе созать новую ячейку
            {
                if (++impostCellNumber == 11) // в тележке должно быть 10 ячеек
                {
                    // взять новыю тележку с номер больше на 1.
                    impostCartNumber++;
                    // номер ячеек сбрость до 1.
                    impostCellNumber = 1;

                }

                // Создать новую ячейку
                CartCell<SawBeam> cartCell = new CartCell<SawBeam>(impostCartNumber, impostCellNumber, "S", string.Empty);
                // Добавить в ячейку балку
                cartCell.Add(sawBeam);

                // Добавить
                manufactNameCartCellNumberList.Add(new KeyValuePair<string, CartCell<SawBeam>>(sawBeam.ManufactName, cartCell));
            }

        }

        // положить остаток в ячейку
        private void PutOstatok(SawBeam sawBeam)
        {
            switch (sawBeam.RemPartName)
            {
                case "И-0": Put_RemImpost(sawBeam); break;
                case "Р-0": Put_RemFrame(sawBeam); break;
                case "C-0": Put_RemLeaf(sawBeam); break;
                case "С-0": Put_RemLeaf(sawBeam); break;
            }
        }

        private void Put_RemLeaf(SawBeam sawBeam)
        {

            // получить ячейку с таким же пр. номером и количество балок в ней меньшае 8.
            var OstatokCartCell = OstatokCartCellNumberList_Leaf
                .FirstOrDefault(kv => kv.Key == "RemLeaf" && kv.Value.Count() != _MAX_COUNT_REMAINDER_LEAF);

            if (OstatokCartCell.Key != null)
            {
                OstatokCartCell.Value.Add(sawBeam);
            }
            else // Иначе созать новую ячейку
            {
                if (++OstatokCellNumber_Leaf == 11) // в тележке должно быть 10 ячеек
                {
                    // взять новыю тележку с номер больше на 1.
                    OstatokCartNumber_Leaf++;
                    // номер ячеек сбрость до 1.
                    OstatokCellNumber_Leaf = 1;

                }

                // Создать новую ячейку
                CartCell<SawBeam> cartCell = new CartCell<SawBeam>(OstatokCartNumber_Leaf, OstatokCellNumber_Leaf, "OF", string.Empty);
                // Добавить в ячейку балку
                cartCell.Add(sawBeam);

                // Добавить
                OstatokCartCellNumberList_Leaf.Add(new KeyValuePair<string, CartCell<SawBeam>>("RemLeaf", cartCell));
            }

        }

        private void Put_RemFrame(SawBeam sawBeam) 
        {

            // получить ячейку с таким же пр. номером и количество балок в ней меньшае 8.
            var OstatokCartCell = OstatokCartCellNumberList_Rama
                .FirstOrDefault(kv => kv.Key == "RemFrame" && kv.Value.Count() != _MAX_COUNT_REMAINDER_FRAME);

            if (OstatokCartCell.Key != null)
            {
                OstatokCartCell.Value.Add(sawBeam);
            }
            else // Иначе созать новую ячейку
            {
                if (++OstatokCellNumber_Rama == 11) // в тележке должно быть 10 ячеек
                {
                    // взять новыю тележку с номер больше на 1.
                    OstatokCartNumber_Rama++;
                    // номер ячеек сбрость до 1.
                    OstatokCellNumber_Rama = 1;

                }

                // Создать новую ячейку
                CartCell<SawBeam> cartCell = new CartCell<SawBeam>(OstatokCartNumber_Rama, OstatokCellNumber_Rama, "OB", string.Empty);
                // Добавить в ячейку балку
                cartCell.Add(sawBeam);

                // Добавить
                OstatokCartCellNumberList_Rama.Add(new KeyValuePair<string, CartCell<SawBeam>>("RemFrame", cartCell));
            }

        }

        private void Put_RemImpost(SawBeam sawBeam) 
        {

            // получить ячейку с таким же пр. номером и количество балок в ней меньшае 8.
            var OstatokCartCell = OstatokCartCellNumberList_Impost
                .FirstOrDefault(kv => kv.Key == "RemImpost" && kv.Value.Count() != _MAX_COUNT_REMAINDER_IMPOST);

            if (OstatokCartCell.Key != null)
            {
                OstatokCartCell.Value.Add(sawBeam);
            }
            else // Иначе созать новую ячейку
            {
                if (++OstatokCellNumber_Impost == 11) // в тележке должно быть 10 ячеек
                {
                    // взять новыю тележку с номер больше на 1.
                    OstatokCellNumber_Impost++;
                    // номер ячеек сбрость до 1.
                    OstatokCellNumber_Impost = 1;

                }

                // Создать новую ячейку
                CartCell<SawBeam> cartCell = new CartCell<SawBeam>(OstatokCellNumber_Impost, OstatokCellNumber_Impost, "OS", string.Empty);
                // Добавить в ячейку балку
                cartCell.Add(sawBeam);

                // Добавить
                OstatokCartCellNumberList_Impost.Add(new KeyValuePair<string, CartCell<SawBeam>>("RemImpost", cartCell));
            }

        }
    }
}
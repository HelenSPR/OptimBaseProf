using Atechnology.winDraw.Classes;
using Atechnology.winDraw.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.Export.OptimizationExporters
{
    internal class BeamStore : IBeamStore<SawBeam>
    {
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

        // Получить ячейку в которой лежить балка
        public CartCell<SawBeam> GetCartCell(SawBeam sawBeam)
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
                                                                                           && kv.Value.FirstOrDefault(beam => beam == sawBeam)!= null);
                if(kvPair.Key != null)
                return kvPair.Value;

                throw new Exception("В хранилище не найдена ячейка для данного импоста. idoptimdocpos = " + sawBeam.IdOptimDocPos);
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
                beam.Store = this;
            }
        }



        // положить балку створки в ячейку
        private void PutLeafBeam(SawBeam sawBeam)
        {
           
            if(!leafCartCellNumber.ContainsKey(((clsLeafBeem)sawBeam.ClsBeem).Leaf))
            {
                if (++leafCellNumber == 11)
                {
                    leafCellNumber = 1;
                    leafCartNumber++;
                }

                CartCell<SawBeam> cartCell = new CartCell<SawBeam>(leafCartNumber, leafCellNumber, "S", string.Empty);

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

                CartCell<SawBeam> cartCell = new CartCell<SawBeam>(frameCartNumber, frameCellNumber, "R", string.Empty);

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
                CartCell<SawBeam> cartCell = new CartCell<SawBeam>(impostCartNumber, impostCellNumber, "I", string.Empty);
                // Добавить в ячейку балку
                cartCell.Add(sawBeam);

                // Добавить
                manufactNameCartCellNumberList.Add(new KeyValuePair<string, CartCell<SawBeam>>(sawBeam.ManufactName, cartCell));
            }

        }


    }
}

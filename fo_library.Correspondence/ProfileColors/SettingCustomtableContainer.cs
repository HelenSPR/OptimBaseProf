using fo_library.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Xml.Linq;
using System.Xml;
using System.IO;

namespace fo_library.Correspondence.ProfileColors
{
    public class SettingCustomtableContainer : IContainer
    {

        private static SettingCustomtableContainer instance;

        public static SettingCustomtableContainer CreateContainer()
        {
            if (instance == null)
                instance = new SettingCustomtableContainer();

            return instance;
        }

        private SettingCustomtableContainer()
        {
            // Заполнить
            this.RefreshContainer();
        }

        // Загрузка данных соответствия
        public void RefreshContainer()
        {
            // Выбрать запись с таблицей цвета для профиля
            var setting = ModelSettings.CurrentRepository.Settings.First(s => s.idsetting == 1084);


            // разархивировать значение поля setting.customtable и получить xml-таблицу соответствия
            byte[] byteTable = Atechnology.Components.ZipArchiver.UnZip(setting.customtable.ToArray());

            MemoryStream msTable = new MemoryStream(byteTable);
            XmlReader xmlTableReader = XmlReader.Create(msTable);
            

            // получение xml-таблицы соответствия
            XElement xTable = XElement.Load(xmlTableReader);

            msTable.Close();
            xmlTableReader.Close();

            this.SetDictionaries(xTable);
        }


        private void SetDictionaries(XElement xTable)
        {
            _ProfileIdDefaultColorId = new Dictionary<int, int>();
            _ProfileIdColorGroupIDs = new Dictionary<int, int[]>();

            foreach (var xe in xTable.Elements("values"))
            {
                _ProfileIdDefaultColorId.Add((int)xe.Element("ProfileId"), (int) xe.Element("DefaultColorId"));

                string[] strClrGrIds = xe.Element("ColorGroupIds").Value.Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);

                if (strClrGrIds.Length != 0)
                {
                    int[] intClrGrIds = new int[strClrGrIds.Length];


                    for (int i = 0; i < intClrGrIds.Length; i++)
                    {
                        intClrGrIds[i] = Convert.ToInt32(strClrGrIds[i]);
                    }

                    _ProfileIdColorGroupIDs.Add((int)xe.Element("ProfileId"),intClrGrIds);
                }
            }
        }

        private Dictionary<int, int[]> _ProfileIdColorGroupIDs;

        private Dictionary<int, int> _ProfileIdDefaultColorId;

        public int GetDefaultColorIdByProfileId(int profileId)
        {
            return this._ProfileIdDefaultColorId[profileId];
        }

        public int[] GetColorGroupIdsByProfileId(int profileId)
        {
            return this._ProfileIdColorGroupIDs[profileId];
        }
    }
}

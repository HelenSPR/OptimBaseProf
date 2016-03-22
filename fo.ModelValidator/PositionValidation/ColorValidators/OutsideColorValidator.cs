using Atechnology.ecad.Calc.winDraw;
using Atechnology.ecad.Document.Classes;
using Atechnology.winDraw.Model;
using Atechnology.winDraw.Model.Settings;
using fo_library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.Validation
{
    internal class OutsideColorValidator : ColorValidator
    {
        internal OutsideColorValidator(OrderCalcPosition orderCalcPostion)
            : base(orderCalcPostion, orderCalcPostion.CalcModel.ColorOut, orderCalcPostion.CalcModel.ColorOutGroupName, "Внешний")
        {

        }

        protected override void SetNewColor(color newColor)
        {
            this.orderCalcPostion.CalcModel.ColorOut = newColor.name;
            this.orderCalcPostion.CalcModel.ColorOutGroupName = newColor.colorgroup1.name;

            ConstructionColor nativeColor = SettingsLoad.currentSettings.GetConstructionColorByID(newColor.idcolor);

            this.orderCalcPostion.NativeModel.ChangeColors(null, nativeColor);
        }
    }
}

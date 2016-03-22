using fo_library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Atechnology.winDraw.Model;
using Atechnology.ecad.Document.Classes;
using Atechnology.winDraw.Model.Settings;
using Atechnology.ecad.Calc.winDraw;

namespace fo_library.Validation
{
    internal class InsideColorValidator : ColorValidator
    {
        internal InsideColorValidator(OrderCalcPosition orderCalcPostion)
            : base(orderCalcPostion, orderCalcPostion.CalcModel.ColorIn, orderCalcPostion.CalcModel.ColorInGroupName, "Внутренний")
        {

        }

        protected override void SetNewColor(color newColor)
        {
            this.orderCalcPostion.CalcModel.ColorIn = newColor.name;
            this.orderCalcPostion.CalcModel.ColorInGroupName = newColor.colorgroup1.name;

            ConstructionColor nativeColor = SettingsLoad.currentSettings.GetConstructionColorByID(newColor.idcolor);

            this.orderCalcPostion.NativeModel.ChangeColors(nativeColor, null);
        }
    }
}

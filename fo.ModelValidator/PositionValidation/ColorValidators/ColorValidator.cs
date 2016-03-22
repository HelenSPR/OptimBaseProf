using Atechnology.ecad.Calc.winDraw;
using Atechnology.ecad.Document.Classes;
using Atechnology.winDraw.Classes;
using Atechnology.winDraw.Model;
using Atechnology.winDraw.Model.Settings;
using fo_library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fo_library.Validation
{
    
    internal abstract class ColorValidator
    {


        protected OrderCalcPosition orderCalcPostion;

        protected readonly string colorname;

        protected readonly string colorgroupname;

        protected readonly string side;

        protected ColorValidator(OrderCalcPosition orderCalcPostion, string colorname, string colorgroupname, string side)
        {
            this.orderCalcPostion = orderCalcPostion;

         
            this.colorname = colorname;

            this.colorgroupname = colorgroupname;

            this.side = side;
        }


        

        abstract protected void SetNewColor(color newColor);

        public string Validate()
        {
            var color = ModelSettings.CurrentRepository.Colors
                .FirstOrDefault(c => c.name == colorname
                                      && c.colorgroup1.name == colorgroupname
                                      && !c.deleted.HasValue);
           
            if (color == null)
            {
                
               



                int defaultColorId = Correspondence.Correspondences.GetDefaultColorIdByProfileId(orderCalcPostion.NativeModel.ProfileSystem.ID);

                

                color = ModelSettings.CurrentRepository.Colors.FirstOrDefault(c => c.idcolor == defaultColorId);



                string unfoundedcolor = string.Concat(colorgroupname, "/", colorname);
                string defaultcolor = string.Concat(color.colorgroup1.name, "/", color.name);

                SetNewColor(color);

               

                string msg = string.Format("{0} цвет \"{1}\" изделия устарел. Выставлен цвет по умолчанию: \"{2}\"!"
                    , side
                    , unfoundedcolor
                    , defaultcolor);

                

                return msg;
            }

            return string.Empty;
        }

     

       
    }
}

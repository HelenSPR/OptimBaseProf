﻿using fo_library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.Choosing
{
    public class GlassCoverObjectSignValueChoosingModel : SignStringValueChoosingModel
    {
        public GlassCoverObjectSignValueChoosingModel(IRepository repository, int idorder)
            : base(repository, idorder, 185)
        {
        }

        protected override string GetDefaultSignValue()
        {
            return _Repository.SignValues.First(sv => sv.idsignvalue == 681).strvalue;
        }
    }
}
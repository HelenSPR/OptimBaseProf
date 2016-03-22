using System;
using System.Collections.Generic;
using System.Text;

namespace fo_library.Correspondence.ProfileColors
{
    public interface IContainer
    {
        int GetDefaultColorIdByProfileId(int profileId);

        int[] GetColorGroupIdsByProfileId(int profileId);

        void RefreshContainer();
    }
}

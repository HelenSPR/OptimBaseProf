using fo_library.Correspondence.ProfileColors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.Correspondence
{
    public static class Correspondences
    {
        public static int GetDefaultColorIdByProfileId(int profileId)
        {
            var container = SettingCustomtableContainer.CreateContainer();
            return container.GetDefaultColorIdByProfileId(profileId);
        }

        public static int[] GetColorGroupIdsByProfileId(int profileId)
        {
            var container = SettingCustomtableContainer.CreateContainer();
            return container.GetColorGroupIdsByProfileId(profileId);
        }
    }
}

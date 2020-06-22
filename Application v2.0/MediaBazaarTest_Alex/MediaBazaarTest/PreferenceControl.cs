using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarTest
{
    class PreferenceControl
    {
        List<Preference> preferences;
        PreferenceDataControl pdc;

        public PreferenceControl()
        {
            preferences = new List<Preference>();
            pdc = new PreferenceDataControl();
            foreach (Preference p in pdc.GetAllPreferences())
            { preferences.Add(p); }
        }

        public List<Preference> GetAllPreferences()
        { return preferences; }

        public Preference GetPreferenceByUserId(int userId)
        {
            foreach (Preference p in preferences)
            {
                if (p.UserId == userId)
                { return p; }
            }
            return null;
        }
    }
}

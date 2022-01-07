using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxies
{
    class InteriorOfficeProxy : IShowInfo
    {
        private InteriorOffice _InteriorOffice;
        public InteriorOfficeProxy(InteriorOffice InteriorOffice)
        {
            _InteriorOffice = InteriorOffice;
        }
        public void ShowChildren()
        {
            _InteriorOffice.ShowChildren();
        }

        public void ShowID()
        {
            _InteriorOffice.ShowID();
        }

        public void ShowPassport()
        {
            _InteriorOffice.ShowPassport();
        }
    }
}

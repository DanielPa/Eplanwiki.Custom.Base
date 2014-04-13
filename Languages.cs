using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eplanwiki.Custom.Base
{
    public class Languages
    {
        public ISOCode AlternativeLanguage { get; private set; }
        public ISOCode GuiLanguage { get; private set; }
        public ISOCode HelpLanguage { get; private set; }   
    }
}

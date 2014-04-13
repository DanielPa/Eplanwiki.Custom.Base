using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eplanwiki.Custom.Base
{
    public class LanguageList : System.Collections.ArrayList
    {        
        public ISOCode.Language get_Language(int index)
        {
            return (ISOCode.Language)this[index] ;                     
        }        
    }
}

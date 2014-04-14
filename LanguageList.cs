/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/. */

﻿using System;
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

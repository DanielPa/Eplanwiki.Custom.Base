using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Specialized;

namespace Eplanwiki.Custom.Base
{
    public class MultiLangString
    {        
        StringDictionary MLS = new StringDictionary();
        //fertig
        public MultiLangString()
        {    
            
            foreach (var lang in Enum.GetValues(typeof(ISOCode.Language)))
            {
                MLS.Add(lang.ToString(), string.Empty);
            }
        }
        

       
        //fertig
        public void AddString(ISOCode.Language lang, String val)
        {
            if (MLS.ContainsKey(lang.ToString()))
            {
                MLS[lang.ToString()] = val;
            }
        }
        //fertig
        public void Clear()
        {
            MLS.Clear();
            foreach (var lang in Enum.GetValues(typeof(ISOCode.Language)))
            {
                MLS.Add(lang.ToString(), string.Empty);
            }
        }
        //fertig
        public Boolean ContainsData()
        {
            foreach (var item in MLS.Values)
            {
                if (item.ToString() != string.Empty)
                {
                    return true;
                }
            }
            return false;
        }

        //fertig 
        public void DeleteAllStringsExceptFor(LanguageList goodLanguages)
        {
            LanguageList badLanguages = new LanguageList();

            foreach (var lang in Enum.GetValues(typeof(ISOCode.Language)).Cast<ISOCode.Language>())
            {
                badLanguages.Add(lang);   
            }
            for (int i = 0; i < goodLanguages.Count; i++)
            {
                badLanguages.Remove(goodLanguages[i]);
            }

            for (int i = 0; i < badLanguages.Count; i++)
            {
                this.DeleteString((ISOCode.Language)badLanguages[i]);
            }

        }
        //fertig
        public void DeleteString(ISOCode.Language badLanguage)
        {
            MLS[badLanguage.ToString()] = string.Empty;
        }

        //fertig
        public String GetAsString()
        {
            string concatString = string.Empty;

            foreach (DictionaryEntry de in MLS)
            {
                if (de.Value.ToString() != string.Empty)
                {
                    concatString +=  de.Key.ToString().Remove(0, 2) + "@" + de.Value.ToString() + ";";                
                }
            }
            return concatString;
        }

        //prüfen was zu tun ist
        public string GetEMultiLangString()
        {
            throw new System.NotImplementedException();
        }

        //fertig
        public Int32 GetLanguageList(LanguageList rLanguageListe)
        {
            LanguageList sinnloseListe = new LanguageList();
            sinnloseListe = rLanguageListe;
            sinnloseListe.Clear();
            Int32 counter = 0;
            foreach (var lang in Enum.GetValues(typeof(ISOCode.Language)).Cast<ISOCode.Language>())
            {
                if (this.GetString(lang) != string.Empty)
                {
                    counter++;
                }
            }
            return counter;
        }

        //fertig
        public String GetString(ISOCode.Language lang)
        {
            if (MLS.ContainsKey(lang.ToString()))
            {
                return MLS[lang.ToString()];
            }
            else
            {
                return MLS[ISOCode.Language.L___.ToString()];
            }
        }

        //fertig unterschied zu GetString(ISOCode.Language lang) ???
        public String GetStringToDisplay(ISOCode.Language lang)
        {
            return this.GetString(lang);
        }

        //fertig
        public Boolean IsEqual(ref MultiLangString otherVal)
        {
            Boolean answer = true;       
            foreach (var lang in Enum.GetValues(typeof(ISOCode.Language)).Cast<ISOCode.Language>())
            {
                if (answer&& MLS[lang.ToString()]!= null)
                {
                    answer = MLS[lang.ToString()].Equals(otherVal.GetString(lang));
                }
            }
            return answer;
        }

        //fertig
        public void SetAsString(String val)
        {
            MLS = StringParser(val);
        }

        public Boolean Translatable()
        {
            throw new System.NotImplementedException();
        }


        //fertig
        private StringDictionary StringParser(String mlString)
        {
            StringDictionary mls = new StringDictionary();

            char[] delimiterChars = { ';' };
            string[] mlStrings = mlString.Split(delimiterChars);
            foreach (string item in mlStrings)
            {
                char[] atChar = {'@'};
                string[] slString = item.Split(atChar);
                if (slString[0] != "")
                {
                    foreach (var lang in Enum.GetValues(typeof(ISOCode.Language)))
                    {
                        if (lang.ToString().Contains(slString[0]))
                        {
                            mls[lang.ToString()] = slString[1];
                        }

                    }
                }

            }
            return mls;
        }
    }
}

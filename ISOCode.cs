/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;

namespace Eplanwiki.Custom.Base
{
    public class ISOCode
    {
        //fertig
        public enum Language
        {
            //alle ISO-Codes angelegt noch nicht überprüft
            L___,       //unknown language (used for setting language-independant strings)  
            L_ar_BH,    //Arabic (Bahrain)  
            L_ar_DZ,    //Arabic (Algeria)  
            L_af_ZA,    //Afrikaans (South Africa)  
            L_am_AM,  //Armenian  
            L_ar_AE,  //Arabic (United Arab Emirates)  
            L_ar_EG,  //Arabic (Egypt)  
            L_ar_IQ,  //Arabic (Iraq)  
            L_ar_JO,  //Arabic (Jordan)  
            L_ar_KW,  //Arabic (Kuwait)  
            L_ar_LB,  //Arabic (Lebanon)  
            L_bg_BG,  //Bulgarian (Bulgaria)  
            L_ar_LY,  //Arabic (Libya)  
            L_ar_MA,  //Arabic (Morocco)  
            L_ar_OM,  //Arabic (Oman)  
            L_ar_QA,  //Arabic (Qatar)  
            L_ar_SA,  //Arabic (Saudi Arabia)  
            L_ca_ES,  //Catalan (Spain)  
            L_ar_SY,  //Arabic (Syria)  
            L_cs_CZ,  //Czech (Czech Republic)  
            L_ar_TN,  //Arabic (Tunisia)  
            L_da_DK,  //Danish (Denmark)  
            L_de_DE,  //German (Germany)  
            L_dz_BT,  //Dzongkha (Bhutan)  
            L_el_GR,  //Greek (Greece)  
            L_en_US,  //English (United States)  
            L_ar_YE,  //Arabic (Yemen)  
            L_es_ES,  //Spanish (Spain)  
            L_et_EE,  //Estonian (Estonia)  
            L_en_AU,  //English (Australia)  
            L_en_CA,  //English (Canada)  
            L_fi_FI,  //Finnish (Finland)  
            L_en_IE,  //English (Ireland)  
            L_fo_FO,  //Faroese (Faroe Islands)  
            L_fr_FR,  //French (France)  
            L_en_NZ,  //English (New Zealand)  
            L_en_ZA,  //English (South Africa)  
            L_es_AR,  //Spanish (Argentina)  
            L_es_BO,  //Spanish (Bolivia)  
            L_es_CL,  //Spanish (Chile)  
            L_es_CO,  //Spanish (Colombia)  
            L_es_CR,  //Spanish (Costa Rica)  
            L_es_DO,  //Spanish (Dominican Republic)  
            L_he_IL,  //Hebrew (Israel)  
            L_hi_IN,  //Hindi (India)  
            L_hr_HR,  //Croatian (Croatia)  
            L_hu_HU,  //Hungarian (Hungary)  
            L_es_EC,  //Spanish (Ecuador)  
            L_es_GT,  //Spanish (Guatemala)  
            L_id_ID,  //Indonesian (Indonesia)  
            L_es_HN,  //Spanish (Honduras)  
            L_es_MX,  //Spanish (Mexico)  
            L_is_IS,  //Icelandic (Iceland)  
            L_it_IT,  //Italian (Italy)  
            L_es_NI,  //Spanish (Nicaragua)  
            L_ja_JP,  //Japanese (Japan)  
            L_es_PA,  //Spanish (Panama)  
            L_ka_GE,  //Georgian (Georgia)  
            L_kk_KZ,  //Kazakh (Kazakhstan)  
            L_kl_GL,  //Kalaallisut (Greenland)  
            L_km_KH,  //Khmer (Cambodia)  
            L_es_PE,  //Spanish (Peru)  
            L_ko_KR,  //Korean (South Korea)  
            L_es_PR,  //Spanish (Puerto Rico)  
            L_es_PY,  //Spanish (Paraguay)  
            L_es_SV,  //Spanish (El Salvador)  
            L_ky_CY,  //Kirghiz (Cyrillic)  
            L_es_UY,  //Spanish (Uruguay)  
            L_es_VE,  //Spanish (Venezuela)  
            L_fr_BE,  //French (Belgium)  
            L_fr_CA,  //French (Canada)  
            L_lt_LT,  //Lithuanian (Lithuania)  
            L_lv_LV,  //Latvian (Latvia)  
            L_ms_BN,  //Malay (Brunei)  
            L_nl_BE,  //Dutch (Belgium)  
            L_mk_MK,  //Macedonian (Macedonia)  
            L_pt_BR,  //Portuguese (Brazil)  
            L_sq_AL,  //Albanian (Albania)  
            L_sr_CY,  //Serbian (Cyrillic)  
            L_sr_LT,  //Serbian (Latin)  
            L_ms_MY,  //Malay (Malaysia)  
            L_mt_MT,  //Maltese (Malta)  
            L_my_BU,  //Burmese  
            L_ss_SZ,  //Swazi  
            L_su_SD,  //Sudanese  
            L_nl_NL,  //Dutch (Netherlands)  
            L_no_NO,  //Norwegian  
            L_sv_FI,  //Swedish (Finland)  
            L_sv_SE,  //Swedish (Sweden)  
            L_sy_SY,  //Syriac (Syria)  
            L_th_TH,  //Thai (Thailand)  
            L_pl_PL,  //Polish (Poland)  
            L_tr_TR,  //Turkish  
            L_pt_PT,  //Portuguese (Portugal)  
            L_uk_UA,  //Ukrainian (Ukraine)  
            L_ur_IN,  //Urdu (India)  
            L_ur_PK,  //Urdu (Pakistan)  
            L_ro_RO,  //Romanian (Romania)  
            L_ru_RU,  //Russian (Russia)  
            L_vi_VN,  //Vietnamese (Vietnam)  
            L_zh_CN,  //Chinese (China)  
            L_zh_HK,  //Chinese (Hong Kong S.A.R., China)  
            L_zh_MO,  //Chinese (Macao S.A.R., China)  
            L_zh_SG,  //Chinese (Singapore)  
            L_zh_TW,  //Chinese (Taiwan)  
            L_sk_SK,  //Slovak (Slovakia)  
            L_sl_SI,  //Slovenian (Slovenia)  
            L_uz_CY,  //Uzbek (Cyrillic)  
            L_uz_LT,  //Uzbek (Latin)  
            L_so_SO,  //Somali (Somalia)  
            L_en_EN,  //English (England)  
            L_bs_BA,  //Bosnisch (Lateinisch, Bosnien und Herzegowina)  
            L_hr_BA,  //Kroatisch (Bosnien und Herzegowina)  
            L_sr_BA,  //Serbisch (Lateinisch, Bosnien und Herzegowina)  
            L_fa_IR,  //Farsi  
            L_yy_XX,   //unknown language (used when importing from EPLAN 5) 
            
        }

        private Language language = ISOCode.Language.L___;
                
        //fertig
        public Int32 GetAllLanguages(ref LanguageList lstLanguages)
        {
            return lstLanguages.Count;
        }

        //fertig
        public Int32 GetAllLongNames(ref StringCollection collLanguages)
        {
            return collLanguages.Count;
        }

        //fertig
        public String GetLongName()
        {
            return "??_??"; 
        }
        

        //fertig
        public String GetLongName(ISOCode.Language lang)
        {
            switch (lang)
            {
                case Language.L___: return "__ unknown language";  
                    
                case Language.L_ar_BH: return "ar_BH Arabic (Bahrain)";  
                    
                case Language.L_ar_DZ: return "ar_DZ Arabic (Algeria)";  
                    
                case Language.L_af_ZA: return "af_ZA Afrikaans (South Africa)";  
                    
                case Language.L_am_AM: return "am_AM Armenian";  
                    
                case Language.L_ar_AE: return "ar_AE Arabic (United Arab Emirates)";  
                    
                case Language.L_ar_EG: return "ar_EG Arabic (Egypt)";  
                    
                case Language.L_ar_IQ: return "ar_IQ Arabic (Iraq)";  
                    
                case Language.L_ar_JO: return "ar_JO Arabic (Jordan)";  
                    
                case Language.L_ar_KW: return "ar_KW Arabic (Kuwait)";  
                    
                case Language.L_ar_LB: return "ar_LB Arabic (Lebanon)";  
                    
                case Language.L_bg_BG: return "bg_BG Bulgarian (Bulgaria)";  
                    
                case Language.L_ar_LY: return "ar_LY Arabic (Libya)";  
                    
                case Language.L_ar_MA: return "ar_MA Arabic (Morocco)";  
                    
                case Language.L_ar_OM: return "ar_OM Arabic (Oman)";  
                    
                case Language.L_ar_QA: return "ar_QA Arabic (Qatar)";  
                    
                case Language.L_ar_SA: return "ar_SA Arabic (Saudi Arabia)";  
                    
                case Language.L_ca_ES: return "ca_ES Catalan (Spain)";  
                    
                case Language.L_ar_SY: return "ar_SY Arabic (Syria)";  
                    
                case Language.L_cs_CZ: return "cs_CZ Czech (Czech Republic)";  
                    
                case Language.L_ar_TN: return "ar_TN Arabic (Tunisia)";  
                    
                case Language.L_da_DK: return "da_DK Danish (Denmark)";  
                    
                case Language.L_de_DE: return "de_DE German (Germany)";  
                    
                case Language.L_dz_BT: return "dz_BT Dzongkha (Bhutan)";  
                    
                case Language.L_el_GR: return "el_GR Greek (Greece)";  
                    
                case Language.L_en_US: return "en_US English (United States)";  
                    
                case Language.L_ar_YE: return "ar_YE Arabic (Yemen)";  
                    
                case Language.L_es_ES: return "es_ES Spanish (Spain)";  
                    
                case Language.L_et_EE: return "et_EE Estonian (Estonia)";  
                    
                case Language.L_en_AU: return "en_AU English (Australia)";  
                    
                case Language.L_en_CA: return "en_CA English (Canada)";  
                    
                case Language.L_fi_FI: return "fi_FI Finnish (Finland)";  
                    
                case Language.L_en_IE: return "en_IE English (Ireland)";  
                    
                case Language.L_fo_FO: return "fo_FO Faroese (Faroe Islands)";  
                    
                case Language.L_fr_FR: return "fr_FR French (France)";  
                    
                case Language.L_en_NZ: return "en_NZ English (New Zealand)";  
                    
                case Language.L_en_ZA: return "en_ZA English (South Africa)";  
                    
                case Language.L_es_AR: return "es_AR Spanish (Argentina)";  
                    
                case Language.L_es_BO: return "es_BO Spanish (Bolivia)";  
                    
                case Language.L_es_CL: return "es_CL Spanish (Chile)";  
                    
                case Language.L_es_CO: return "es_CO Spanish (Colombia)";  
                    
                case Language.L_es_CR: return "es_CR Spanish (Costa Rica)";  
                    
                case Language.L_es_DO: return "es_DO Spanish (Dominican Republic)";  
                    
                case Language.L_he_IL: return "he_IL Hebrew (Israel)";  
                    
                case Language.L_hi_IN: return "hi_IN Hindi (India)";  
                    
                case Language.L_hr_HR: return "hr_HR Croatian (Croatia)";  
                    
                case Language.L_hu_HU: return "hu_HU Hungarian (Hungary)";  
                    
                case Language.L_es_EC: return "es_EC Spanish (Ecuador)";  
                    
                case Language.L_es_GT: return "es_GT Spanish (Guatemala)";  
                    
                case Language.L_id_ID: return "id_ID Indonesian (Indonesia)";  
                    
                case Language.L_es_HN: return "es_HN Spanish (Honduras)";  
                    
                case Language.L_es_MX: return "es_MX Spanish (Mexico)";  
                    
                case Language.L_is_IS: return "is_IS Icelandic (Iceland)";  
                    
                case Language.L_it_IT: return "it_IT Italian (Italy)";  
                    
                case Language.L_es_NI: return "es_NI Spanish (Nicaragua)";  
                    
                case Language.L_ja_JP: return "ja_JP Japanese (Japan)";  
                    
                case Language.L_es_PA: return "es_PA Spanish (Panama)";  
                    
                case Language.L_ka_GE: return "ka_GE Georgian (Georgia)";  
                    
                case Language.L_kk_KZ: return "kk_KZ Kazakh (Kazakhstan)";  
                    
                case Language.L_kl_GL: return "kl_GL Kalaallisut (Greenland)";  
                    
                case Language.L_km_KH: return "km_KH Khmer (Cambodia)";  
                    
                case Language.L_es_PE: return "es_PE Spanish (Peru)";  
                    
                case Language.L_ko_KR: return "ko_KR Korean (South Korea)";  
                    
                case Language.L_es_PR: return "es_PR Spanish (Puerto Rico)";  
                    
                case Language.L_es_PY: return "es_PY Spanish (Paraguay)";  
                    
                case Language.L_es_SV: return "es_SV Spanish (El Salvador)";  
                    
                case Language.L_ky_CY: return "ky_CY Kirghiz (Cyrillic)";  
                    
                case Language.L_es_UY: return "es_UY Spanish (Uruguay)";  
                    
                case Language.L_es_VE: return "es_VE Spanish (Venezuela)";  
                    
                case Language.L_fr_BE: return "fr_BE French (Belgium)";  
                    
                case Language.L_fr_CA: return "fr_CA French (Canada)";  
                    
                case Language.L_lt_LT: return "lt_LT Lithuanian (Lithuania)";  
                    
                case Language.L_lv_LV: return "lv_LV Latvian (Latvia)";  
                    
                case Language.L_ms_BN: return "ms_BN Malay (Brunei)";  
                    
                case Language.L_nl_BE: return "nl_BE Dutch (Belgium)";  
                    
                case Language.L_mk_MK: return "mk_MK Macedonian (Macedonia)";  
                    
                case Language.L_pt_BR: return "pt_BR Portuguese (Brazil)";  
                    
                case Language.L_sq_AL: return "sq_AL Albanian (Albania)";  
                    
                case Language.L_sr_CY: return "sr_CY Serbian (Cyrillic)";  
                    
                case Language.L_sr_LT: return "sr_LT Serbian (Latin)";  
                    
                case Language.L_ms_MY: return "ms_MY Malay (Malaysia)";  
                    
                case Language.L_mt_MT: return "mt_MT Maltese (Malta)";  
                    
                case Language.L_my_BU: return "my_BU Burmese";  
                    
                case Language.L_ss_SZ: return "ss_SZ Swazi";  
                    
                case Language.L_su_SD: return "su_SD Sudanese";  
                    
                case Language.L_nl_NL: return "nl_NL Dutch (Netherlands)";  
                    
                case Language.L_no_NO: return "no_NO Norwegian";  
                    
                case Language.L_sv_FI: return "sv_FI Swedish (Finland)";  
                    
                case Language.L_sv_SE: return "sv_SE Swedish (Sweden)";  
                    
                case Language.L_sy_SY: return "sy_SY Syriac (Syria)";  
                    
                case Language.L_th_TH: return "th_TH Thai (Thailand)";  
                    
                case Language.L_pl_PL: return "pl_PL Polish (Poland)";  
                    
                case Language.L_tr_TR: return "tr_TR Turkish";  
                    
                case Language.L_pt_PT: return "pt_PT Portuguese (Portugal)";  
                    
                case Language.L_uk_UA: return "uk_UA Ukrainian (Ukraine)";  
                    
                case Language.L_ur_IN: return "ur_IN Urdu (India)";  
                    
                case Language.L_ur_PK: return "ur_PK Urdu (Pakistan)";  
                    
                case Language.L_ro_RO: return "ro_RO Romanian (Romania)";  
                    
                case Language.L_ru_RU: return "ru_RU Russian (Russia)";  
                    
                case Language.L_vi_VN: return "vi_VN Vietnamese (Vietnam)";  
                    
                case Language.L_zh_CN: return "zh_CN Chinese (China)";  
                    
                case Language.L_zh_HK: return "zh_HK Chinese (Hong Kong S.A.R., China)";  
                    
                case Language.L_zh_MO: return "zh_MO Chinese (Macao S.A.R., China)";  
                    
                case Language.L_zh_SG: return "zh_SG Chinese (Singapore)";  
                    
                case Language.L_zh_TW: return "zh_TW Chinese (Taiwan)";  
                    
                case Language.L_sk_SK: return "sk_SK Slovak (Slovakia)";  
                    
                case Language.L_sl_SI: return "sl_SI Slovenian (Slovenia)";  
                    
                case Language.L_uz_CY: return "uz_CY Uzbek (Cyrillic)";  
                    
                case Language.L_uz_LT: return "uz_LT Uzbek (Latin)";  
                    
                case Language.L_so_SO: return "so_SO Somali (Somalia)";  
                    
                case Language.L_en_EN: return "en_EN English (England)";  
                    
                case Language.L_bs_BA: return "bs_BA Bosnisch (Lateinisch, Bosnien und Herzegowina)";  
                    
                case Language.L_hr_BA: return "hr_BA Kroatisch (Bosnien und Herzegowina)";  
                    
                case Language.L_sr_BA: return "sr_BA Serbisch (Lateinisch, Bosnien und Herzegowina)";  
                    
                case Language.L_fa_IR: return "fa_IR Farsi";  
                    
                case Language.L_yy_XX: return "yy_XX unknown language (used when importing from EPLAN 5)"; 
                    
                default: return "??_??";
                    
            }
            
        }
        //fertig
        public String GetLongName(String strLang)
        {       
            return GetLongName(GetNumber(strLang));           
        }
        //fertig
        public Language GetNumber()
        {
            return language;
        }
        //fertig
        public Language GetNumber(String strLang)
        {
            string langStr = "L_" + strLang;
            foreach (var lang in Enum.GetValues(typeof(ISOCode.Language)).Cast<ISOCode.Language>())
            {
                if (langStr.Equals(lang.ToString()))
                {
                    return lang;
                }

            }
            foreach (var lang in Enum.GetValues(typeof(ISOCode.Language)).Cast<ISOCode.Language>())
            {
                if (strLang.Equals(lang.ToString().Substring(2, 2)))
                {
                    return lang;
                }

            }
            return Language.L___;
        }

        public String GetString()
        {
            return null;
        }

        public String GetString(Language lang)
        {
            return null;
        }

        public Boolean IsValid()
        {
            return false;
        }

        public void SetNumber(Language lang)
        {
            language = lang;
        }

        public void SetString(String lang) 
        {
        }
    }
}

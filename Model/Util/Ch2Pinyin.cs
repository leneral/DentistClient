using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.International.Converters.PinYinConverter;

namespace Model.Util
{
    public class Ch2Pinyin
    {
        public static string ToPinyin(string word)
        {
            //foreach (var item in _word)
            //{
            //    if (ChineseChar.IsValidChar(item)) 
            //    {
            //        ChineseChar chars = new ChineseChar(item);
            //        pinyin += string.Format("{0}", chars.Pinyins[0]);
            //    }
            //}
            return
                (from item in word where ChineseChar.IsValidChar(item) select new ChineseChar(item)).Aggregate(
                    string.Empty, (current, chars) => current + string.Format("{0}", chars.Pinyins[0]));
        }


    }
}
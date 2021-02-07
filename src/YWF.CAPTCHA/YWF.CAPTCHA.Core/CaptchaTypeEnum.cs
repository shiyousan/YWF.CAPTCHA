using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YWF.CAPTCHA.Core
{
    [Flags]
    public enum CaptchaTypeEnum
    {
        All=0,
        //纯数字
        Number = 1,
        //数学计算
        Math = 2,
        //汉字
        ChineseCharacter = 4,
        //英文大写字母
        EnglishUpperCase = 8,
        //英文小写字母
        EnglishLowerCase = 16
    }
    //public enum Captcha
}

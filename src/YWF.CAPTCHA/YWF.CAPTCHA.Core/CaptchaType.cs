using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YWF.CAPTCHA.Core
{
    public enum CaptchaType
    {
        //纯文本
        PlainText,
        //数学计算
        Math
    }

    [Flags]
    public enum CaptchaTextType
    {
        All=0,
        //纯数字
        Number = 1,
        //汉字
        ChineseCharacter = 2,
        //英文大写字母
        EnglishUpperCase = 4,
        //英文小写字母
        EnglishLowerCase = 8
    }
}

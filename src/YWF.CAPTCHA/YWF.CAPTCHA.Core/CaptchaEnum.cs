using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YWF.CAPTCHA.Core
{
    /// <summary>
    /// 验证码类型
    /// 纯文本和数学计算
    /// </summary>
    public enum CaptchaType
    {
        //纯文本
        PlainText,
        //数学计算
        Math
    }

    /// <summary>
    /// 验证码数学运算符
    /// 加减乘除
    /// </summary>
    public enum CaptchaMathOperator
    {
        Addition, Subtraction, Multiplication, Division
    }

    /// <summary>
    /// 验证码纯文本类型
    /// </summary>
    [Flags]
    public enum CaptchaTextType
    {
        All = 0,
        //纯数字
        Number = 1,
        //汉字
        ChineseCharacter = 2,
        //英文大写字母
        EnglishUpperCase = 4,
        //英文小写字母
        EnglishLowerCase = 8
    }

    /// <summary>
    /// 验证码噪点
    /// </summary>
    [Flags]
    public enum CaptchaNoiseStyle
    {
        //干扰线
        Line = 1,
        //噪点
        Point = 2,
        //干扰字母
        Letter = 4
    }
}

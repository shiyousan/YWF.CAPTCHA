using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YWF.CAPTCHA.Core
{
    public class CaptchaOption
    {
        /// <summary>
        /// 禁止出现的代码字符，不区分大小写
        /// 可用于过滤一些脏话单词
        /// </summary>
        public IList<string> BanCodeLetterList { get; set; } = new List<string>() { "FUCK", "SHIT" };
        /// <summary>
        /// 禁止出现的数字
        /// 可用于过滤一些不吉利数字组合
        /// </summary>
        public IList<string> BanNumberLetterList { get; set; } = new List<string>() { "44","514"};
        public CaptchaOption()
        {
            //foreach (string letter in BanCodeLetterList)
            //{
            //    codeLetters = codeLetters.Replace(letter, string.Empty);
            //}

            //foreach (string letter in BanNumberLetterList)
            //{
            //    numberLetters = numberLetters.Replace(letter, string.Empty);
            //}
        }
        /// <summary>
        /// 验证码类型，默认纯文本
        /// </summary>
        public CaptchaType Type { get; set; } = CaptchaType.PlainText;
        /// <summary>
        /// 验证码文本类型，默认英文大写
        /// </summary>
        public CaptchaTextType TextType { get; set; } = CaptchaTextType.EnglishLowerCase;
        /// <summary>
        /// 验证码数学运算符，默认加法
        /// </summary>
        public CaptchaMathOperator MathOperator { get; set; } = CaptchaMathOperator.Addition;
        /// <summary>
        /// 验证码噪点，默认干扰线和噪点
        /// </summary>
        public CaptchaNoiseStyle NoiseStyle { get; set; } = CaptchaNoiseStyle.Point | CaptchaNoiseStyle.Line;
        /// <summary>
        /// 验证码文本类型代码长度
        /// 默认且建议采用随机长度，可提高部分安全性，防止被简单破解
        /// </summary>
        public int CodeLength { get; set; } = GetRandomCodeLength();
        ///// <summary>
        ///// 验证码文本最小长度，大于等于该值
        ///// </summary>
        //public int CodeMinLength { get; set; } = 4;
        ///// <summary>
        ///// 验证码文本最大长度,小于该值
        ///// </summary>
        //public int CodeMaxLength { get; set; } = 6;

        /// <summary>
        /// 获取随机验证码长度，默认长度大于等于4，小于6
        /// </summary>
        /// <returns></returns>
        public static int GetRandomCodeLength()
        {
            return GetRandomCodeLength(4, 6);
        }
        /// <summary>
        /// 获取随机验证码长度
        /// </summary>
        /// <param name="min">验证码文本最小长度，大于等于该值</param>
        /// <param name="max">验证码文本最大长度,小于该值</param>
        /// <returns></returns>
        public static int GetRandomCodeLength(int min, int max)
        {
            return new Random().Next(min, max);
        }
        /// <summary>
        /// 验证码图片尺寸
        /// </summary>
        public Size ImageSize { get; set; }
    }
}

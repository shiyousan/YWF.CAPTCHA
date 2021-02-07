using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YWF.CAPTCHA.Core
{
    public class CaptchaOption
    {
        /// <summary>
        /// 验证码字符
        /// 考虑用户体验，建议避免数字0、1，英文字符i、I、o、O
        /// ，根据情况可自行选择，例如数字5、英文字符s、S也是容易混淆的字符
        /// </summary>
        private const string upperCaseLetters = "ABCDEFGHJKLMNPQRSTUVWXYZ";
        private const string lowerCaseLetters = "abcdefghjklmnpqrstuvwxyz";
        private const string numberLetters = "23456789";
        
    }
}

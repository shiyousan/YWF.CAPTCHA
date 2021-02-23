using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YWF.CAPTCHA.Core;

namespace YWF.CAPTCHA.Sample.Controllers
{
    public class WidgetController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("get-captcha-image")]
        public ActionResult GetCaptchaImage()
        {
            int width = 100;
            int height = 36;
            var captchaCode = CaptchaCore.GenerateCaptchaCode();
            var result = CaptchaCore.GenerateCaptchaImage(width, height, captchaCode);
            HttpContext.Session["CaptchaCode"]= result.CaptchaCode;
            Stream s = new MemoryStream(result.CaptchaByteData); 
            return new FileStreamResult(s, "image/png");
        }

        public ActionResult GetCaptcha()
        {
            return View();
        }
        public ActionResult CaptchaTest()
        {
            return null;
            //int width = 100;
            //int height = 36;
            //var captchaCode = Captcha.GenerateCaptchaCode();
            //var result = Captcha.GenerateCaptchaImage(width, height, captchaCode);
            //HttpContext.Session.SetString("CaptchaCode", result.CaptchaCode);
            //Stream stream = new MemoryStream(result.CaptchaByteData);
            //return new FileStreamResult(stream, "image/png");


            //using (System.Drawing.Bitmap _bitmap = new System.Drawing.Bitmap(95, 30))
            //{
            //    using (System.Drawing.Graphics _g = System.Drawing.Graphics.FromImage(_bitmap))
            //    {
            //        Random _random = new Random();
            //        //获取随机生成的验证码
            //        string _codeStr = CreateRandomCode(_random);
            //        //清除背景色
            //        _g.Clear(Color.White);
            //        //设置验证码渐变画刷
            //        System.Drawing.Drawing2D.LinearGradientBrush _brush = new System.Drawing.Drawing2D.LinearGradientBrush(new Rectangle(0, 0, _bitmap.Width, _bitmap.Height), Color.Blue, Color.Green, 30f);

            //        //绘制验证码
            //        _g.DrawString(_codeStr, new Font("微软雅黑", 17, FontStyle.Bold), _brush, new PointF(0, 0));
            //        //绘制干扰图形
            //        DrawDisturb(_bitmap, _g, _random);
            //        //绘制边框
            //        _g.DrawRectangle(new Pen(Color.Silver, 2f), 1, 1, _bitmap.Width - 2, _bitmap.Height - 2);
            //        //将验证码图片输出
            //        _bitmap.Save(context.Response.OutputStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            //        //将验证码保存到Session中
            //        context.Session["CheckCode"] = _codeStr;
            //        _codeStr = null;
            //    }
            //}
        }
    }
}
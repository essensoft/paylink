using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 互联网网站场景
    /// </summary>
    public class WebInfo : WeChatPayObject
    {
        /// <summary>
        /// 互联网网站域名
        /// </summary>
        /// <remarks>
        /// 1、如为PC端商城、智能终端等场景，可上传官网链接。
        /// 2、网站域名需ICP备案，若备案主体与申请主体不同，请上传加盖公章的网站授权函。
        /// <para>示例值：http://www.qq.com</para>
        /// </remarks>
        [JsonPropertyName("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// 网站授权函
        /// </summary>
        /// <remarks>
        /// 1、若备案主体与申请主体不同，请务必上传加盖公章的网站授权函。
        /// 2、请填写通过图片上传API预先上传图片生成好的MediaID。
        /// <para>示例值： 47ZC6GC-vnrbEnyVBDIUv0OF4wFNIO4kqg05InE4d2I6_H7I4</para>
        /// </remarks>
        [JsonPropertyName("web_authorisation")]
        public string WebAuthorisation { get; set; }

        /// <summary>
        /// 互联网网站对应的商家APPID
        /// </summary>
        /// <remarks>
        /// 1、可填写已认证的公众号、小程序、应用的APPID，其中公众号APPID需是已认证的服务 号、政府或媒体类型的订阅号；
        /// 2、完成进件后，系统发起特约商户号与该AppID的绑定（即配置为sub_appid，可在发起支付时传入）
        ///    （1）若APPID主体与商家主体一致，则直接完成绑定；
        ///    （2）若APPID主体与商家主体不一致，则商户签约时显示《联合营运承诺函》，并且 AppID的管理员需登录公众平台确认绑定意愿；（ 暂不支持绑定异主体的应用APPID）。
        /// <para>示例值：wx1234567890123456</para>
        /// </remarks>
        [JsonPropertyName("web_appid")]
        public string WebAppid { get; set; }
    }
}

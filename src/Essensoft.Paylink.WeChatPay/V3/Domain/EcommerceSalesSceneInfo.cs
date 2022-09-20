using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 店铺信息
    /// </summary>
    public class EcommerceSalesSceneInfo : WeChatPayObject
    {
        /// <summary>
        /// 店铺名称
        /// </summary>
        /// <remarks>
        /// 请填写店铺全称。
        /// <para>示例值：爱烧烤</para>
        /// </remarks>
        [JsonPropertyName("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 店铺链接
        /// </summary>
        /// <remarks>
        /// 1、店铺二维码or店铺链接二选一必填。
        /// 2、请填写店铺主页链接，需符合网站规范。
        /// <para>示例值：http://www.qq.com</para>
        /// </remarks>
        [JsonPropertyName("store_url")]
        public string StoreUrl { get; set; }

        /// <summary>
        /// 店铺二维码
        /// </summary>
        /// <remarks>
        /// 1、店铺二维码 or 店铺链接二选一必填。
        /// 2、若为电商小程序，可上传店铺页面的小程序二维码。
        /// 3、请填写通过图片上传API预先上传图片生成好的MediaID，仅能上传1张图片 。
        /// <para>示例值：jTpGmxUX3FBWVQ5NJTZvlKX_gdU4cRz7z5NxpnFuAxhBTEO_PvWkfSCJ3zVIn001D8daLC-ehEuo0BJqRTvDujqhThn4ReFxikqJ5YW6zFQ</para>
        /// </remarks>
        [JsonPropertyName("store_qr_code")]
        public string StoreQrCode { get; set; }

        /// <summary>
        /// 小程序AppID
        /// </summary>
        /// <remarks>
        /// 1、商户自定义字段，可填写已认证的小程序AppID，认证主体需与二级商户主体一致；
        /// 2、完成入驻后， 系统发起二级商户号与该AppID的绑定（即配置为sub_appid，可在发起支付时传入）
        /// <para>示例值：wxa123344545577</para>
        /// </remarks>
        [JsonPropertyName("mini_program_sub_appid")]
        public string MiniProgramSubAppid { get; set; }
    }
}

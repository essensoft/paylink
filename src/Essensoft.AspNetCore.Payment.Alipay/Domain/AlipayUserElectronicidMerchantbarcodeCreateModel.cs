using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserElectronicidMerchantbarcodeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserElectronicidMerchantbarcodeCreateModel : AlipayObject
    {
        /// <summary>
        /// 动态码过期时间，单位秒，当type为DYNAMIC时为必填参数
        /// </summary>
        [JsonProperty("expire_time")]
        public long ExpireTime { get; set; }

        /// <summary>
        /// 生成商家网证二维码的类型，用于区分二维码有效期类型，动态二维码：DYNAMIC，静态二维码：STATIC
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// 商户提供的唯一标识，不感知大小写等问题，支付宝只做透传，当用户扫商户时，商户会拿到的这个透传值
        /// </summary>
        [JsonProperty("unique_id")]
        public string UniqueId { get; set; }
    }
}

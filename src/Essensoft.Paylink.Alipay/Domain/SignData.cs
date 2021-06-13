using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// SignData Data Structure.
    /// </summary>
    public class SignData : AlipayObject
    {
        /// <summary>
        /// 签名商户开放平台应用APPID
        /// </summary>
        [JsonPropertyName("ori_app_id")]
        public string OriAppId { get; set; }

        /// <summary>
        /// 编码类型（大小写敏感）
        /// </summary>
        [JsonPropertyName("ori_char_set")]
        public string OriCharSet { get; set; }

        /// <summary>
        /// ori_out_biz_no_001
        /// </summary>
        [JsonPropertyName("ori_out_biz_no")]
        public string OriOutBizNo { get; set; }

        /// <summary>
        /// 签名密文
        /// </summary>
        [JsonPropertyName("ori_sign")]
        public string OriSign { get; set; }

        /// <summary>
        /// 签名算法（大小写敏感）
        /// </summary>
        [JsonPropertyName("ori_sign_type")]
        public string OriSignType { get; set; }

        /// <summary>
        /// 2088041181118800
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }
    }
}

using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ShopMerchantInfo Data Structure.
    /// </summary>
    public class ShopMerchantInfo : AlipayObject
    {
        /// <summary>
        /// isv定义的商家id（isv侧唯一）
        /// </summary>
        [JsonPropertyName("isv_mid")]
        public string IsvMid { get; set; }

        /// <summary>
        /// 商家名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商家id
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 签约模式(self_help：商户自助开通、isv_help_smid：ISV代smid开通、isv_help_pid：ISV代pid开通)
        /// </summary>
        [JsonPropertyName("sign_mode")]
        public string SignMode { get; set; }

        /// <summary>
        /// 间连商家smid(间连必传)
        /// </summary>
        [JsonPropertyName("smid")]
        public string Smid { get; set; }
    }
}

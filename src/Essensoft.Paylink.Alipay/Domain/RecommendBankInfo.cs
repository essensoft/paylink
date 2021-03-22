using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// RecommendBankInfo Data Structure.
    /// </summary>
    public class RecommendBankInfo : AlipayObject
    {
        /// <summary>
        /// 银行跳转的安卓的包名
        /// </summary>
        [JsonPropertyName("android_package_name")]
        public string AndroidPackageName { get; set; }

        /// <summary>
        /// 银行跳转的安卓schema
        /// </summary>
        [JsonPropertyName("android_schema")]
        public string AndroidSchema { get; set; }

        /// <summary>
        /// 银行编号
        /// </summary>
        [JsonPropertyName("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 银行渠道图标地址
        /// </summary>
        [JsonPropertyName("bank_icon_url")]
        public string BankIconUrl { get; set; }

        /// <summary>
        /// 银行名称
        /// </summary>
        [JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 银行渠道是否可用
        /// </summary>
        [JsonPropertyName("enable")]
        public bool Enable { get; set; }

        /// <summary>
        /// 银行跳转的iosschema
        /// </summary>
        [JsonPropertyName("ios_schema")]
        public string IosSchema { get; set; }

        /// <summary>
        /// 银行渠道备注说明
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }
    }
}

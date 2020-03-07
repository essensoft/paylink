using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCreditAutofinanceVidGetModel Data Structure.
    /// </summary>
    public class AlipayCreditAutofinanceVidGetModel : AlipayObject
    {
        /// <summary>
        /// 机构编号
        /// </summary>
        [JsonPropertyName("orgcode")]
        public string Orgcode { get; set; }

        /// <summary>
        /// 支付宝账号数字ID
        /// </summary>
        [JsonPropertyName("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// 当前安装的支付宝钱包版本号
        /// </summary>
        [JsonPropertyName("version")]
        public string Version { get; set; }
    }
}

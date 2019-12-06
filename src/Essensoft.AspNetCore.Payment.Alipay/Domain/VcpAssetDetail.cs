using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// VcpAssetDetail Data Structure.
    /// </summary>
    public class VcpAssetDetail : AlipayObject
    {
        /// <summary>
        /// 资金金额
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 资产金额
        /// </summary>
        [JsonPropertyName("assetamount")]
        public string Assetamount { get; set; }

        /// <summary>
        /// 正常充值
        /// </summary>
        [JsonPropertyName("assetusechannel")]
        public string Assetusechannel { get; set; }

        /// <summary>
        /// 收款用户id
        /// </summary>
        [JsonPropertyName("settleuserid")]
        public string Settleuserid { get; set; }
    }
}

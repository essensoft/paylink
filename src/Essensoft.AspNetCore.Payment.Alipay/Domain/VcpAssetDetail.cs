using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// VcpAssetDetail Data Structure.
    /// </summary>
    [Serializable]
    public class VcpAssetDetail : AlipayObject
    {
        /// <summary>
        /// 资金金额
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 资产金额
        /// </summary>
        [JsonProperty("assetamount")]
        public string Assetamount { get; set; }

        /// <summary>
        /// 正常充值
        /// </summary>
        [JsonProperty("assetusechannel")]
        public string Assetusechannel { get; set; }

        /// <summary>
        /// 收款用户id
        /// </summary>
        [JsonProperty("settleuserid")]
        public string Settleuserid { get; set; }
    }
}

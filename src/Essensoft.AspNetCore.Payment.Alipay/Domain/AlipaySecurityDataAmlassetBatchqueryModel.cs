using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityDataAmlassetBatchqueryModel Data Structure.
    /// </summary>
    public class AlipaySecurityDataAmlassetBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 资产的类型，包括LABEL、AML_LIST等
        /// </summary>
        [JsonPropertyName("asset_type")]
        public string AssetType { get; set; }

        /// <summary>
        /// 合作客户
        /// </summary>
        [JsonPropertyName("client")]
        public string Client { get; set; }

        /// <summary>
        /// 名单or资产标签ID
        /// </summary>
        [JsonPropertyName("lid")]
        public string Lid { get; set; }

        /// <summary>
        /// 客户ID列表
        /// </summary>
        [JsonPropertyName("uids")]
        public List<string> Uids { get; set; }
    }
}

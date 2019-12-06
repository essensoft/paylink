using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataAiserviceSmartpriceMerchanteffectQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceSmartpriceMerchanteffectQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商家效果展示列表返回值
        /// </summary>
        [JsonPropertyName("result")]
        public List<MerchantEffectQueryResult> Result { get; set; }

        /// <summary>
        /// 最小定价单元,返回为""代表统计了该商户下所有定价单元指标之和
        /// </summary>
        [JsonPropertyName("unit_id")]
        public string UnitId { get; set; }
    }
}

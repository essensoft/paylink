using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayDataAiserviceBikepriceGetResponse.
    /// </summary>
    public class AlipayDataAiserviceBikepriceGetResponse : AlipayResponse
    {
        /// <summary>
        /// 返回结果列表
        /// </summary>
        [JsonPropertyName("result")]
        public List<CardPriceResponseItem> Result { get; set; }
    }
}

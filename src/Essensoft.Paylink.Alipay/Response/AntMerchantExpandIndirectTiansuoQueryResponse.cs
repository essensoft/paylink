using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandIndirectTiansuoQueryResponse.
    /// </summary>
    public class AntMerchantExpandIndirectTiansuoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 间连商户pid和对应名称信息
        /// </summary>
        [JsonPropertyName("indirect_isv_info")]
        public List<IndirectIsvInfo> IndirectIsvInfo { get; set; }
    }
}

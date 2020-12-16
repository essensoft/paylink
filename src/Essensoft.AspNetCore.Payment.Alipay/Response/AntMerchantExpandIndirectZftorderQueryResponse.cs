using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandIndirectZftorderQueryResponse.
    /// </summary>
    public class AntMerchantExpandIndirectZftorderQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 直付通二级商户进件申请单信息
        /// </summary>
        [JsonPropertyName("orders")]
        public List<ZftSubMerchantOrder> Orders { get; set; }
    }
}

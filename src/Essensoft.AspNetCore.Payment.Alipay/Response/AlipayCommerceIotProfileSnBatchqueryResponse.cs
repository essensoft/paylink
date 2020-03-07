using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotProfileSnBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceIotProfileSnBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// sn列表
        /// </summary>
        [JsonPropertyName("sn_list")]
        public List<ProfileSnDetail> SnList { get; set; }
    }
}

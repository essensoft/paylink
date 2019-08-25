using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayTradeRoyaltyRelationBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeRoyaltyRelationBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 外部请求号。32个字符以内，可包含字母、数字、下划线。需保证在商户端不重复。
        /// </summary>
        [JsonProperty("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 第几页，从1开始。不填默认为1
        /// </summary>
        [JsonProperty("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页面大小。每页记录数，取值范围是(0,100]。不填默认为20
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; }
    }
}

using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppBillSearchResponse.
    /// </summary>
    public class AlipayEbppBillSearchResponse : AlipayResponse
    {
        /// <summary>
        /// 已经缓存的的key
        /// </summary>
        [JsonPropertyName("cachekey")]
        public string Cachekey { get; set; }

        /// <summary>
        /// 实时查询欠费单返回对象
        /// </summary>
        [JsonPropertyName("inst_bill_info_list")]
        public List<QueryInstBillInfo> InstBillInfoList { get; set; }
    }
}

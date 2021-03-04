using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEbppProdmodeChargeoffinstQueryResponse.
    /// </summary>
    public class AlipayEbppProdmodeChargeoffinstQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 销账机构下拉列表
        /// </summary>
        [JsonPropertyName("data_list")]
        public List<BizListDataInfo> DataList { get; set; }
    }
}

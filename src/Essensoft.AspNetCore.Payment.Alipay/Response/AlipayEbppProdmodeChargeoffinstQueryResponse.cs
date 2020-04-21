using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
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

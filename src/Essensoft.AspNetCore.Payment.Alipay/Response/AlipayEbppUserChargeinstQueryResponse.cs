using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppUserChargeinstQueryResponse.
    /// </summary>
    public class AlipayEbppUserChargeinstQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 提供给邦道的接口，查询用户常缴机构与常住城市信息，该对象为输出具体内容。
        /// </summary>
        [JsonPropertyName("data_list")]
        public List<QueryUserChargeInstAndAreaInfo> DataList { get; set; }
    }
}

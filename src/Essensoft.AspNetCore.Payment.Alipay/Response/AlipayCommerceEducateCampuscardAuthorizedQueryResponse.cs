using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceEducateCampuscardAuthorizedQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateCampuscardAuthorizedQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 学生的校园卡列表
        /// </summary>
        [JsonPropertyName("alipay_card_simple_list")]
        public List<SchoolCardSimpleInfo> AlipayCardSimpleList { get; set; }
    }
}

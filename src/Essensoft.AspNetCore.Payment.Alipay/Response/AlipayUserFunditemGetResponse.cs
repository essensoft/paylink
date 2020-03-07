using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserFunditemGetResponse.
    /// </summary>
    public class AlipayUserFunditemGetResponse : AlipayResponse
    {
        /// <summary>
        /// 查询得到的消费记录详细信息（主记录+资金明细列表）
        /// </summary>
        [JsonPropertyName("fund_detail_item_aopmodel")]
        public FundDetailItemAOPModel FundDetailItemAopmodel { get; set; }
    }
}

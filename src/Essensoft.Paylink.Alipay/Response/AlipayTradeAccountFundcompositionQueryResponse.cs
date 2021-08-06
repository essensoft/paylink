using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayTradeAccountFundcompositionQueryResponse.
    /// </summary>
    public class AlipayTradeAccountFundcompositionQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 专户账号
        /// </summary>
        [JsonPropertyName("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 银行专户的转入资金明细
        /// </summary>
        [JsonPropertyName("card_amount_detail_list")]
        public List<CardAmountDetailVO> CardAmountDetailList { get; set; }
    }
}

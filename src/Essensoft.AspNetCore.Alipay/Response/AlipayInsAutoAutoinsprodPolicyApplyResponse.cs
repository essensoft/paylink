using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Alipay.Domain;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodPolicyApplyResponse.
    /// </summary>
    public class AlipayInsAutoAutoinsprodPolicyApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 车险询价申请号
        /// </summary>
        [JsonProperty("enquiry_biz_id")]
        public string EnquiryBizId { get; set; }

        /// <summary>
        /// 报价ID
        /// </summary>
        [JsonProperty("quote_biz_id")]
        public string QuoteBizId { get; set; }

        /// <summary>
        /// 车险订单交易信息
        /// </summary>
        [JsonProperty("trade_infos")]
        public List<InsTradeInfo> TradeInfos { get; set; }

        /// <summary>
        /// 吱口令
        /// </summary>
        [JsonProperty("zhi_link")]
        public string ZhiLink { get; set; }
    }
}

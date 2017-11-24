using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Alipay.Domain;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodQuoteApplyResponse.
    /// </summary>
    public class AlipayInsAutoAutoinsprodQuoteApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 车险询价申请号
        /// </summary>
        [JsonProperty("enquiry_biz_id")]
        public string EnquiryBizId { get; set; }

        /// <summary>
        /// 报价返回信息
        /// </summary>
        [JsonProperty("quote_infos")]
        public List<QuoteInfo> QuoteInfos { get; set; }
    }
}

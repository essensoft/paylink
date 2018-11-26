using System.Collections.Generic;
using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
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
        [XmlElement("enquiry_biz_id")]
        public string EnquiryBizId { get; set; }

        /// <summary>
        /// 报价返回信息
        /// </summary>
        [JsonProperty("quote_infos")]
        [XmlArray("quote_infos")]
        [XmlArrayItem("quote_info")]
        public List<QuoteInfo> QuoteInfos { get; set; }
    }
}

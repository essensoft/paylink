using System.Collections.Generic;
using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankFinanceYulibaoPriceQueryResponse.
    /// </summary>
    public class MybankFinanceYulibaoPriceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 余利宝行情信息列表
        /// </summary>
        [JsonProperty("ylb_price_detail_infos")]
        [XmlArray("ylb_price_detail_infos")]
        [XmlArrayItem("y_l_b_price_detail_info")]
        public List<YLBPriceDetailInfo> YlbPriceDetailInfos { get; set; }
    }
}

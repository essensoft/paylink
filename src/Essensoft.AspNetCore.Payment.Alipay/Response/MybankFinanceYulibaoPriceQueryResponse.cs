using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

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
        [JsonPropertyName("ylb_price_detail_infos")]
        public List<YLBPriceDetailInfo> YlbPriceDetailInfos { get; set; }
    }
}

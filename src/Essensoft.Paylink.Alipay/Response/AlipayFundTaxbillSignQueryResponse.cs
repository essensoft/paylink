using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayFundTaxbillSignQueryResponse.
    /// </summary>
    public class AlipayFundTaxbillSignQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 场景码
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 签约信息列表
        /// </summary>
        [JsonPropertyName("result_list")]
        public List<EsignResult> ResultList { get; set; }
    }
}

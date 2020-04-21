using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasTravelRateCurrencyBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayOverseasTravelRateCurrencyBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 业务类型: 1.MBARCODE（支持境外当面付的币种）； 2.CLASS_RATE（支持分级汇率的币种）； 3.为空时默认查询所有的币种；
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 业务扩展参数
        /// </summary>
        [JsonPropertyName("extend_param")]
        public string ExtendParam { get; set; }
    }
}

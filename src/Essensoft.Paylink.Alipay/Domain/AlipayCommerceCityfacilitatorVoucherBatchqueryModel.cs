using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorVoucherBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceCityfacilitatorVoucherBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 城市编码请参考查询 <a href="http://www.mca.gov.cn/article/sj/xzqh/">中华人民共和国行政区划代码</a>。 已支持城市：广州 440100，深圳 440300，杭州330100。
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 支付宝交易号列表
        /// </summary>
        [JsonPropertyName("trade_nos")]
        public List<string> TradeNos { get; set; }
    }
}

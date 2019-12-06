using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiTradeKbdeliveryDeliveryApplyResponse.
    /// </summary>
    public class KoubeiTradeKbdeliveryDeliveryApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 附加数据，在查询API和物流变更通知回执中原样返回，该字段主要用于第三方系统携带订单的自定义数据
        /// </summary>
        [JsonPropertyName("attach")]
        public string Attach { get; set; }

        /// <summary>
        /// 物流单成功创建时间  时间格式：yyyyMMddHHmmss
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 返回物流载体信息；  在取餐柜模式下，为返回申请的设备信息
        /// </summary>
        [JsonPropertyName("logistics_external_info")]
        public LogisticsExternalInfo LogisticsExternalInfo { get; set; }

        /// <summary>
        /// 口碑物流单，单号；
        /// </summary>
        [JsonPropertyName("logistics_order_no")]
        public string LogisticsOrderNo { get; set; }
    }
}

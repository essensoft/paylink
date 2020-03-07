using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayBusinessOrderPayResponse.
    /// </summary>
    public class AlipayBusinessOrderPayResponse : AlipayResponse
    {
        /// <summary>
        /// 商户外部订单号
        /// </summary>
        [JsonPropertyName("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单状态  订单待支付:WAIT_PAY（订单成功创建后）,订单完成：ORDER_SUCCESS（订单支付完成后）,订单关闭：ORDER_CLOSED（订单超时后、商户主动撤销后、退款完成后）
        /// </summary>
        [JsonPropertyName("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 本次支付工具结果列表。注：该接口场景下payer_info无ext_profile_list信息
        /// </summary>
        [JsonPropertyName("paytool_list")]
        public List<PaytoolResultDetail> PaytoolList { get; set; }
    }
}

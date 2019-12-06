using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBusinessOrderPayModel Data Structure.
    /// </summary>
    public class AlipayBusinessOrderPayModel : AlipayObject
    {
        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 支付工具请求列表。支持将现金、商户预付卡、POS、支付宝等支付工具一起支付。
        /// </summary>
        [JsonPropertyName("paytool_list")]
        public List<PaytoolRequestDetail> PaytoolList { get; set; }
    }
}

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBusinessOrderPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBusinessOrderPayModel : AlipayObject
    {
        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [JsonProperty("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 支付工具请求列表。支持将现金、商户预付卡、POS、支付宝等支付工具一起支付。
        /// </summary>
        [JsonProperty("paytool_list")]
        public List<PaytoolRequestDetail> PaytoolList { get; set; }
    }
}

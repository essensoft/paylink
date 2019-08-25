using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaMerchantOrderCreditConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantOrderCreditConfirmModel : AlipayObject
    {
        /// <summary>
        /// 商户订单号，必需参数，用于确认芝麻订单，该参数必须与调用接口（zhima.merchant.order.credit.create）时传入的out_order_no一致
        /// </summary>
        [JsonProperty("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 芝麻订单号，必需参数，用于确认芝麻订单，通过调用接口（zhima.merchant.order.credit.create）后获取
        /// </summary>
        [JsonProperty("zm_order_no")]
        public string ZmOrderNo { get; set; }
    }
}

using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEtcMediaGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEtcMediaGetModel : AlipayObject
    {
        /// <summary>
        /// 业务标识。  1：身份证正面照片；  2：身份证背面照片；  3：行驶证正页正面照片；  4：行驶证副页正面照片；  5：车头照片
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 支付宝生成的申请单id
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部业务订单号
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}

using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiBenefitOrderCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiBenefitOrderCloseModel : AlipayObject
    {
        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [JsonProperty("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 商户端业务发生时间(yyyy-MM-dd HH:mm:ss)
        /// </summary>
        [JsonProperty("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 权益订单id
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户请求场景
        /// </summary>
        [JsonProperty("scene")]
        public string Scene { get; set; }
    }
}

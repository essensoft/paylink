using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayTradePrecreateConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradePrecreateConfirmModel : AlipayObject
    {
        /// <summary>
        /// 买家id
        /// </summary>
        [JsonProperty("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家id类型：  蚂蚁通行证，取值：  antid
        /// </summary>
        [JsonProperty("buyer_id_type")]
        public string BuyerIdType { get; set; }

        /// <summary>
        /// 预下单阶段产生的码串，对应预下单订单。
        /// </summary>
        [JsonProperty("confirm_id")]
        public string ConfirmId { get; set; }

        /// <summary>
        /// 预下单阶段的码串类型  订单二维码，取值：qr_code
        /// </summary>
        [JsonProperty("confirm_type")]
        public string ConfirmType { get; set; }

        /// <summary>
        /// 业务扩展参数
        /// </summary>
        [JsonProperty("extend_params")]
        public TradePrecreateConfirmExtendParam ExtendParams { get; set; }

        /// <summary>
        /// 发卡站ID，由支付宝中国分配
        /// </summary>
        [JsonProperty("issuer_id")]
        public string IssuerId { get; set; }
    }
}

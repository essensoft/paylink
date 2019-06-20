using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMallScanpurchaseDiscountdetailModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMallScanpurchaseDiscountdetailModifyModel : AlipayObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("buyer_user_id")]
        public string BuyerUserId { get; set; }

        /// <summary>
        /// 优惠信息列表
        /// </summary>
        [JsonProperty("discount_details")]
        public List<MallDiscountDetail> DiscountDetails { get; set; }

        /// <summary>
        /// 商圈场景订单id。（order_id和trade_no不能都为空）
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 支付宝交易号，（order_id和trade_no不能都为空）
        /// </summary>
        [JsonProperty("trade_no")]
        public string TradeNo { get; set; }
    }
}

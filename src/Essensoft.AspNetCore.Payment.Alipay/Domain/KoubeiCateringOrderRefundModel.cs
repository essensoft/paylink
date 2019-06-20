using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringOrderRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringOrderRefundModel : AlipayObject
    {
        /// <summary>
        /// 退款金额
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 扩展信息，json对象格式，key和value都为字符串
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 口碑端订单号
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// BUSY(店铺太忙，无法接待)/DUPLICATE_ORDER(重复订单)/SHOP_CLOSE(店铺已打烊)/SELL_OUT(菜品售完)/OTHER_REASON(其他原因)/TABLE_NOT_EXIST(桌号不存在)/RECEIVE_TIMEOUT(超时未接单)/ACCEPT_REFUND(协商退款)/LOW_VERSION(收银系统版本过低)/SHOP_NOT_CONNECTED("没有门店绑定关系")/MERCHANT_NOT_AUTHORIZED(商户没有授权)/POS_UNCONNECTED(POS关机或未联网)/DISH_REASON(菜品原因)
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 退款请求id，基于该id做幂等等控制
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }
    }
}

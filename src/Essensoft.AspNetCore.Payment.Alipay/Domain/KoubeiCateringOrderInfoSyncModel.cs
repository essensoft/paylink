using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringOrderInfoSyncModel Data Structure.
    /// </summary>
    public class KoubeiCateringOrderInfoSyncModel : AlipayObject
    {
        /// <summary>
        /// 订单操作类型，RECEIPT—接单、REJECT—拒单、PREPARE—已备餐、DELIVER—已送餐、REFUND—退款、RENEW—反结、ACCEPT_REFUND 接受退款、REJECT_REFUND 拒接退款、TABLE_CHANGE-修改桌号、PARTIAL_REFUND-部分退款、COOKING-下厨、QUEUE_NUM_SYNC-排队顺序同步、CONFIRM_MODIFY_TIME-确认修改预约时间、REJECT_MODIFY_TIME-拒绝修改预约时间
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// 操作内容信息，Map<String,String> actionInfo = new HashMap<String,String>(); actionInfo.put("NO","5100");// 取餐号 JSONObject.toJSONString(actionInfo);拒单原因/主动退款原因/同意退款原因包括:1、RECEIVE_TIMEOUT超时未接单，2、BUSY店铺太忙，无法接待3、DUPLICATE_ORDER重复订单，4、SHOP_CLOSE店铺已打烊5、SELL_OUT菜品售完，5、OTHER_REASON 其他原因，6、TABLE_NOT_EXIST 桌号不存在，7、LOW_VERSION 收银系统版本过低，8、SHOP_NOT_CONNECTED 没有门店绑定关系，9、MERCHANT_NOT_AUTHORIZED 商户没有授权，10、POS_UNCONNECTED POS关机或未联网，11、DISH_REASON 菜品原因;拒绝退款原因包括:1、RECEIVE_TIMEOUT用户已取餐，2、UNDER_LINE_NEGOTIATION和用户协商一致，线下解决，3、OTHER_REASON其他原因，4、ORDER_HAS_PARTIAL_REFUNDED订单发起部分退款，5、ORDER_HAS_REFUNDED订单发起整单退款，6、ORDER_HAS_VERIFIED订单发起核销; 接单时action_info中加桌号(tableNo)，tableNo和no只能传一种，并确定取餐方式;修改桌号时action_info中传tableNo，thirdPayNo:外部订单号,estimatePickUpTime:预计取餐时间，格式为:${xx}-${yy},${xx}和${yy}为数字，单位为分钟；estimatePickUpTimeStamp：预计取餐时间戳，格式为:${xx} 或${xx}-${yy}为时间戳；4、部分退款调用时，out_refund_no为外部退款单号来保证幂等，refund_amount为部分退款金额。5、排队顺序同步时，action_info中加排队序号queueNum。 ；拒绝修改预约时间原因:1、EXCEED_LIMIT 修改次数超限，2、ERROR_STATUS 当前状态不允许修改  ，3、TIME_INVALID 不是有效的预约时间，4、OTHER 其他原因。
        /// </summary>
        [JsonPropertyName("action_info")]
        public string ActionInfo { get; set; }

        /// <summary>
        /// 口碑端自己的订单号
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }
    }
}

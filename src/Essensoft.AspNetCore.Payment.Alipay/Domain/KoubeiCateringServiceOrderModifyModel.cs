using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringServiceOrderModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringServiceOrderModifyModel : AlipayObject
    {
        /// <summary>
        /// 订座信息。仅order_type=book有效
        /// </summary>
        [JsonProperty("book_info")]
        public BookInfoModify BookInfo { get; set; }

        /// <summary>
        /// 口碑订单号
        /// </summary>
        [JsonProperty("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单状态。  如wait_receive表示待接单/待取号；success表示已接单/已取号；close表示已关闭；finish表示已完成；cancel表示已取消。
        /// </summary>
        [JsonProperty("order_state")]
        public string OrderState { get; set; }

        /// <summary>
        /// 订单物流状态。  如果是排队单物流状态，calling表示叫号中；pass_call表示已过号；eated表示已就餐。  如果是订座单物流状态，eated表示已就餐；not_eated表示未就餐；remain表示留座。
        /// </summary>
        [JsonProperty("order_sub_state")]
        public string OrderSubState { get; set; }

        /// <summary>
        /// 订单类型。如book表示订座，如queue表示排队。
        /// </summary>
        [JsonProperty("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [JsonProperty("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 排队信息。仅order_type=queue有效
        /// </summary>
        [JsonProperty("queue_info")]
        public QueueInfoModify QueueInfo { get; set; }

        /// <summary>
        /// 商户拒绝原因
        /// </summary>
        [JsonProperty("refuse_reason")]
        public string RefuseReason { get; set; }

        /// <summary>
        /// 【通用】  TIME_OUT： 超时关闭  SYSTEM_ERROR：系统异常  CUSTOMER_CANCEL： 客人取消  MERCHANT_CANCEL： 商家取消    【仅排队用】  NUMBER_ERROR：人数错误  MERCHANT_OFFLINE：商家服务不在线  NOT_NEED_QUEUE：无需排队  REPEAT_TAKE：重复取号    【仅订座用】  WAIT_CONFIRM：订单等待确认中  REPEAT_BOOK：重复预订  MERCHANT_NOT_ONLINE：商户目前不接受线上预订  MERCHANT_REFUSE：商户拒绝  BOOK_FULL：预约已满  REACH_UPPER_LIMIT：达到上限
        /// </summary>
        [JsonProperty("refuse_type")]
        public string RefuseType { get; set; }

        /// <summary>
        /// 时间戳，用作数据的版本号，取系统当前时间即可
        /// </summary>
        [JsonProperty("sync_timestamp")]
        public string SyncTimestamp { get; set; }

        /// <summary>
        /// 回流数据类型。  common：非实时性数据更新。  标识除queue_wait和queue_wait_time之外其他数据的更新。    real_time：实时性数据更新。  仅queue_wait和queue_wait_time发生变化时使用。  此时仅会取queue_wait和queue_wait_time两个字段。
        /// </summary>
        [JsonProperty("sync_type")]
        public string SyncType { get; set; }
    }
}

using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaMerchantOrderRentSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantOrderRentSyncModel : AlipayObject
    {
        /// <summary>
        /// 外部订单号, 用于定位需要修改的订单
        /// </summary>
        [JsonProperty("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 通过信用租赁接口曾发起扣款的外部交易号，如果sync_type=fund，传入该值有效，如果该笔扣款当前非成功状态，芝麻会标记该笔扣款已成功状态给用户进行展示
        /// </summary>
        [JsonProperty("out_trans_no")]
        public string OutTransNo { get; set; }

        /// <summary>
        /// 被修改订单的新逾期时间，时间至少比当前时间晚一天，不能修改为过去的时间，注意格式为：yyyy-MM-dd HH:mm:ss，如果sync_type=overdue_time，传入该值有效
        /// </summary>
        [JsonProperty("overdue_time")]
        public string OverdueTime { get; set; }

        /// <summary>
        /// 信用套餐产品码，固定值：w1010100000000002734
        /// </summary>
        [JsonProperty("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 操作类型，标记是需要修改资金单状态或者是修改逾期时间，可选值：fund,overdue_time
        /// </summary>
        [JsonProperty("sync_type")]
        public string SyncType { get; set; }

        /// <summary>
        /// 芝麻订单号，用于定位要修改的订单
        /// </summary>
        [JsonProperty("zm_order_no")]
        public string ZmOrderNo { get; set; }
    }
}

using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEtcApplySyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEtcApplySyncModel : AlipayObject
    {
        /// <summary>
        /// 卡片有效期
        /// </summary>
        [JsonProperty("card_expiry_date")]
        public string CardExpiryDate { get; set; }

        /// <summary>
        /// 卡号
        /// </summary>
        [JsonProperty("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 卡片类型
        /// </summary>
        [JsonProperty("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 申请单审核意见
        /// </summary>
        [JsonProperty("censor_info")]
        public string CensorInfo { get; set; }

        /// <summary>
        /// 物流公司编码
        /// </summary>
        [JsonProperty("delivery_code")]
        public string DeliveryCode { get; set; }

        /// <summary>
        /// 物流公司名称
        /// </summary>
        [JsonProperty("delivery_name")]
        public string DeliveryName { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [JsonProperty("delivery_no")]
        public string DeliveryNo { get; set; }

        /// <summary>
        /// 设备有效期
        /// </summary>
        [JsonProperty("device_expiry_date")]
        public string DeviceExpiryDate { get; set; }

        /// <summary>
        /// 设备编号
        /// </summary>
        [JsonProperty("device_no")]
        public string DeviceNo { get; set; }

        /// <summary>
        /// 设备状态  0：未发货  1：已发货  2：运输中  3：已签收  4：已二发  5：已激活  6：退货中  7：已退货  8：换货中
        /// </summary>
        [JsonProperty("device_status")]
        public string DeviceStatus { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [JsonProperty("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 支付宝生成的申请单id
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 0：未提交；  1：审核中；  2：驳回(可重新提交)；  3：不通过(不可重新提交)；  4：通过；  5：撤销；
        /// </summary>
        [JsonProperty("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 最近更新时间
        /// </summary>
        [JsonProperty("order_update_time")]
        public string OrderUpdateTime { get; set; }

        /// <summary>
        /// 比如某种业务标准外部订单号,比如交易外部订单号，代表商户端自己订单号
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}

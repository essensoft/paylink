using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SinglePayDetail Data Structure.
    /// </summary>
    [Serializable]
    public class SinglePayDetail : AlipayObject
    {
        /// <summary>
        /// 支付宝冻结订单号
        /// </summary>
        [JsonProperty("alipay_order_no")]
        [XmlElement("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 本次支付金额
        /// </summary>
        [JsonProperty("amount")]
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time")]
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 最近修改时间
        /// </summary>
        [JsonProperty("modified_time")]
        [XmlElement("modified_time")]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// 本次支付url地址
        /// </summary>
        [JsonProperty("pay_url")]
        [XmlElement("pay_url")]
        public string PayUrl { get; set; }

        /// <summary>
        /// 收款人的userId
        /// </summary>
        [JsonProperty("receive_user_id")]
        [XmlElement("receive_user_id")]
        public string ReceiveUserId { get; set; }

        /// <summary>
        /// 本次支付的支付宝流水号
        /// </summary>
        [JsonProperty("transfer_order_no")]
        [XmlElement("transfer_order_no")]
        public string TransferOrderNo { get; set; }

        /// <summary>
        /// 本次支付的外部单据号
        /// </summary>
        [JsonProperty("transfer_out_order_no")]
        [XmlElement("transfer_out_order_no")]
        public string TransferOutOrderNo { get; set; }
    }
}

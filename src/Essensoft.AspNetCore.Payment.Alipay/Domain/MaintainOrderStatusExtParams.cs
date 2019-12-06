using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MaintainOrderStatusExtParams Data Structure.
    /// </summary>
    public class MaintainOrderStatusExtParams : AlipayObject
    {
        /// <summary>
        /// 编码
        /// </summary>
        [JsonPropertyName("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 快递发货商
        /// </summary>
        [JsonPropertyName("logistics_company")]
        public string LogisticsCompany { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        [JsonPropertyName("logistics_no")]
        public string LogisticsNo { get; set; }

        /// <summary>
        /// 4S订单状态
        /// </summary>
        [JsonPropertyName("order_status_txt")]
        public string OrderStatusTxt { get; set; }

        /// <summary>
        /// 收货地址
        /// </summary>
        [JsonPropertyName("receiver_addr")]
        public string ReceiverAddr { get; set; }

        /// <summary>
        /// 发货地址
        /// </summary>
        [JsonPropertyName("sender_addr")]
        public string SenderAddr { get; set; }
    }
}

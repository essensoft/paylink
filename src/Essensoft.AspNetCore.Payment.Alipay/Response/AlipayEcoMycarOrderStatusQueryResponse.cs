using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoMycarOrderStatusQueryResponse.
    /// </summary>
    public class AlipayEcoMycarOrderStatusQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝交易流水号订单
        /// </summary>
        [JsonPropertyName("alipay_order_id")]
        public string AlipayOrderId { get; set; }

        /// <summary>
        /// 车平台订单
        /// </summary>
        [JsonPropertyName("car_order_id")]
        public string CarOrderId { get; set; }

        /// <summary>
        /// 设备商订单id
        /// </summary>
        [JsonPropertyName("equipment_order_id")]
        public string EquipmentOrderId { get; set; }

        /// <summary>
        /// 支付金额
        /// </summary>
        [JsonPropertyName("pay_money")]
        public string PayMoney { get; set; }

        /// <summary>
        /// 支付状态
        /// </summary>
        [JsonPropertyName("pay_status")]
        public string PayStatus { get; set; }

        /// <summary>
        /// 支付的时间，格式"yyyy-MM-ddHH:mm:ss"
        /// </summary>
        [JsonPropertyName("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 支付方式（1为支付宝在线缴费，2为支付宝代扣缴费）
        /// </summary>
        [JsonPropertyName("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 返回状态  1为成功  0为失败
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}

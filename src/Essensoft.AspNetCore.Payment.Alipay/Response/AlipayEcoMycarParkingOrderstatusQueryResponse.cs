using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoMycarParkingOrderstatusQueryResponse.
    /// </summary>
    public class AlipayEcoMycarParkingOrderstatusQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝交易流水号订单
        /// </summary>
        [JsonProperty("alipay_order_id")]
        [XmlElement("alipay_order_id")]
        public string AlipayOrderId { get; set; }

        /// <summary>
        /// 车平台订单
        /// </summary>
        [JsonProperty("car_order_id")]
        [XmlElement("car_order_id")]
        public string CarOrderId { get; set; }

        /// <summary>
        /// 设备商订单id
        /// </summary>
        [JsonProperty("equipment_order_id")]
        [XmlElement("equipment_order_id")]
        public string EquipmentOrderId { get; set; }

        /// <summary>
        /// 支付金额
        /// </summary>
        [JsonProperty("pay_money")]
        [XmlElement("pay_money")]
        public string PayMoney { get; set; }

        /// <summary>
        /// 支付状态
        /// </summary>
        [JsonProperty("pay_status")]
        [XmlElement("pay_status")]
        public string PayStatus { get; set; }

        /// <summary>
        /// 支付的时间
        /// </summary>
        [JsonProperty("pay_time")]
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 支付方式（1为支付宝在线缴费，2为支付宝代扣缴费）
        /// </summary>
        [JsonProperty("pay_type")]
        [XmlElement("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 返回状态(1为成功,0为失败)
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }
    }
}

using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingPaymentinfoSyncModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarParkingPaymentinfoSyncModel : AlipayObject
    {
        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonPropertyName("car_number")]
        public string CarNumber { get; set; }

        /// <summary>
        /// 智能助理当前的跳转链接
        /// </summary>
        [JsonPropertyName("isv_url")]
        public string IsvUrl { get; set; }

        /// <summary>
        /// 支付宝停车平台ID，由支付宝定义的该停车场标识，同一个isv或商户范围内唯一。通过 alipay.eco.mycar.parking.parkinglotinfo.create(录入停车场信息)接口获取。
        /// </summary>
        [JsonPropertyName("parking_id")]
        public string ParkingId { get; set; }

        /// <summary>
        /// 停车场内缴费后，允许出场的免费时长分钟数
        /// </summary>
        [JsonPropertyName("payment_free_minutes")]
        public long PaymentFreeMinutes { get; set; }

        /// <summary>
        /// 场内缴费时间，格式"YYYY-MM-DD HH:mm:ss"，24小时制，请保证服务器时间准确，场内缴费不应晚于当前网络时间
        /// </summary>
        [JsonPropertyName("payment_time")]
        public string PaymentTime { get; set; }

        /// <summary>
        /// 支付宝业务流水号，用于记录车辆从驶入到驶出的全流程
        /// </summary>
        [JsonPropertyName("serial_no")]
        public string SerialNo { get; set; }
    }
}

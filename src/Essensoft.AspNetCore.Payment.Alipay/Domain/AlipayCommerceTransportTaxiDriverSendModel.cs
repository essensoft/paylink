using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTaxiDriverSendModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportTaxiDriverSendModel : AlipayObject
    {
        /// <summary>
        /// 支付宝账号
        /// </summary>
        [JsonPropertyName("alipay_account")]
        public string AlipayAccount { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonPropertyName("car_no")]
        public string CarNo { get; set; }

        /// <summary>
        /// 司机身份证号
        /// </summary>
        [JsonPropertyName("driver_cert_no")]
        public string DriverCertNo { get; set; }

        /// <summary>
        /// 司机工号
        /// </summary>
        [JsonPropertyName("driver_job_no")]
        public string DriverJobNo { get; set; }

        /// <summary>
        /// 司机姓名
        /// </summary>
        [JsonPropertyName("driver_name")]
        public string DriverName { get; set; }

        /// <summary>
        /// 司机手机号
        /// </summary>
        [JsonPropertyName("driver_phone")]
        public string DriverPhone { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 来源方，由支付宝分配
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }
    }
}

using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoMycarParkingEnterinfoSyncResponse.
    /// </summary>
    public class AlipayEcoMycarParkingEnterinfoSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 当前车辆在支付宝侧的信息，可选返回项为： NORMAL：正常缴费用户 NON-SENSE-PAY：无感支付签约用户
        /// </summary>
        [JsonPropertyName("car_status")]
        public string CarStatus { get; set; }

        /// <summary>
        /// 支付宝业务流水号，用于记录车辆从驶入到驶出的全流程
        /// </summary>
        [JsonPropertyName("serial_no")]
        public string SerialNo { get; set; }
    }
}

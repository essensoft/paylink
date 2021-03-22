using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEcoMycarParkingEnterinfoSyncResponse.
    /// </summary>
    public class AlipayEcoMycarParkingEnterinfoSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 当前车辆是否签约无感代扣
        /// </summary>
        [JsonPropertyName("agreement_status")]
        public string AgreementStatus { get; set; }

        /// <summary>
        /// 当前车辆在支付宝侧的信息，是否可以使用无感支付，可选返回项为： NORMAL：正常缴费用户 NON-SENSE-PAY：可无感支付用户
        /// </summary>
        [JsonPropertyName("car_status")]
        public string CarStatus { get; set; }

        /// <summary>
        /// 当前时间戳(查询签约状态和是否支持无感支付仅代表当前时间点查询结果，不作为最后代扣结果，应在发起代扣前再次查询)
        /// </summary>
        [JsonPropertyName("current_time")]
        public string CurrentTime { get; set; }

        /// <summary>
        /// 支付宝业务流水号，用于记录车辆从驶入到驶出的全流程
        /// </summary>
        [JsonPropertyName("serial_no")]
        public string SerialNo { get; set; }
    }
}

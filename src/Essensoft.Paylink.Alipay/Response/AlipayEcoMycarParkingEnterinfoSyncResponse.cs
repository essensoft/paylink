using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEcoMycarParkingEnterinfoSyncResponse.
    /// </summary>
    public class AlipayEcoMycarParkingEnterinfoSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 用户签约的代扣场景字符集，多个英文逗号分割，当车场为ORC识别车牌的场景，返回值包含PLATE_PAY时，表示代扣协议可用。 当车场为ETC设备识别车牌，返回值包含ETC_PAY时表示协议可用。当用户未签约任何代扣场景时返回NO_AGREEMENT_SCENE
        /// </summary>
        [JsonPropertyName("agreement_scene")]
        public string AgreementScene { get; set; }

        /// <summary>
        /// 该字段已废弃,请使用agreement_scene字段
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

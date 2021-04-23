using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEcoMycarParkingAgreementQueryResponse.
    /// </summary>
    public class AlipayEcoMycarParkingAgreementQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 车牌垫资状态:  0 可垫资  1 不可垫资  2 未知请重试
        /// </summary>
        [JsonPropertyName("advance_status")]
        public string AdvanceStatus { get; set; }

        /// <summary>
        /// 用户签约的代扣场景字符集，多个英文逗号分割，当车场为ORC识别车牌的场景，返回值包含PLATE_PAY时，表示代扣协议可用。 当车场为ETC设备识别车牌，返回值包含ETC_PAY时表示协议可用。当用户未签约代扣场景时返回NO_AGREEMENT_SCENE
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
        /// 有效时间，格式"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [JsonPropertyName("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 仅当当前车场服务商签约了停车无感垫资产品，且指定车牌被当前传入的支付宝用户开通代扣条件下返回
        /// </summary>
        [JsonPropertyName("user_advance_info")]
        public UserAdvanceInfo UserAdvanceInfo { get; set; }
    }
}

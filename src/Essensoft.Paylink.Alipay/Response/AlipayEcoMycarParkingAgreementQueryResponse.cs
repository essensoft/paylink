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
        /// 车牌代扣状态:   -  当不传入uid：  0 车牌支持代扣  1 车牌不支持代扣  -  当传入uid：  0 车牌被指定用户开通代扣  1 车牌不支持代扣  2 车牌被其他用户开通代扣
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

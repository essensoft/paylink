using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntfortuneEquityInstpointPrizeexchangeUseModel Data Structure.
    /// </summary>
    public class AntfortuneEquityInstpointPrizeexchangeUseModel : AlipayObject
    {
        /// <summary>
        /// 手机号码，1864234324324。实物奖品兑换时本字段必填
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 比如某种业务标准外部订单号,比如交易外部订单号，代表商户端自己订单号，同个商户下相同订单号会幂等返回结果。比如：改订单已成功处理，则幂等返回成功；订单处理失败则幂等返回失败
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 兑换的奖品编号，可在财富开放平台配置上架积分奖品后获得
        /// </summary>
        [JsonPropertyName("prize_no")]
        public string PrizeNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}

using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserInviteAwardReceiveResponse.
    /// </summary>
    public class AlipayUserInviteAwardReceiveResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝老用户手机号绑定的脱敏后的账户名 ，多个账号用英文","分割
        /// </summary>
        [JsonPropertyName("alipay_account_no")]
        public string AlipayAccountNo { get; set; }

        /// <summary>
        /// 业务处理结果码（NEW_ALREADY_AWARD:新用户凭证已发放、  NEW_AWARD_SUCESS：新用户凭证发放成功、OLD_AWARD_SUCCESS：老用户凭证成功、OLD_AWARD_OVER_LIMIT：老用户凭证发放次数超过上限、ACTIVITY_CLOSE：活动已结束、ACTIVITY_PAUSE：活动临时暂停）
        /// </summary>
        [JsonPropertyName("biz_result_code")]
        public string BizResultCode { get; set; }

        /// <summary>
        /// 业务结果码对应的中文描述，见业务结果码描述
        /// </summary>
        [JsonPropertyName("biz_result_desc")]
        public string BizResultDesc { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 用户输入的手机号回传
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 用户新老属性（NEW：新用户，OLD：老用户）
        /// </summary>
        [JsonPropertyName("user_attr")]
        public string UserAttr { get; set; }
    }
}

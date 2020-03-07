using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthSpaccountConsultResponse.
    /// </summary>
    public class AlipayFinancialnetAuthSpaccountConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 若已开户，则为脱敏后已开户登录号
        /// </summary>
        [JsonPropertyName("display_opened_account_logon_id")]
        public string DisplayOpenedAccountLogonId { get; set; }

        /// <summary>
        /// 若调用finsign服务失败，返回错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 调用finsign业务失败时，返回的错误文案
        /// </summary>
        [JsonPropertyName("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 若返回true说明调用finsign此服务成功
        /// </summary>
        [JsonPropertyName("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 返回是否已开户，若为true则说明已开户
        /// </summary>
        [JsonPropertyName("opened_account")]
        public bool OpenedAccount { get; set; }

        /// <summary>
        /// 已开专户的uid
        /// </summary>
        [JsonPropertyName("opened_account_user_id")]
        public string OpenedAccountUserId { get; set; }
    }
}

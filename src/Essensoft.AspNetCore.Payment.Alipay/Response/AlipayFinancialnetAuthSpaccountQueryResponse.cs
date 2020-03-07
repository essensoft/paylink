using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthSpaccountQueryResponse.
    /// </summary>
    public class AlipayFinancialnetAuthSpaccountQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 机构专户信息列表
        /// </summary>
        [JsonPropertyName("account_info")]
        public List<SpAccountInfo> AccountInfo { get; set; }

        /// <summary>
        /// 调用finauth服务失败时返回的错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 调用finauth失败时返回的错误描述
        /// </summary>
        [JsonPropertyName("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 调用finauth查询机构专户信息是否成功
        /// </summary>
        [JsonPropertyName("is_success")]
        public string IsSuccess { get; set; }
    }
}

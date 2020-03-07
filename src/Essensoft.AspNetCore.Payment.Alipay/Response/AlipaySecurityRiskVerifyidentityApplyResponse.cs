using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityRiskVerifyidentityApplyResponse.
    /// </summary>
    public class AlipaySecurityRiskVerifyidentityApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 可用性查询失败错误码
        /// </summary>
        [JsonPropertyName("err_code")]
        public string ErrCode { get; set; }

        /// <summary>
        /// 核身可用性查询错误描述
        /// </summary>
        [JsonPropertyName("err_message")]
        public string ErrMessage { get; set; }

        /// <summary>
        /// 系统是否处理成功，true表示系统成功处理，false表示系统异常，系统处理成功不表示业务成功
        /// </summary>
        [JsonPropertyName("is_success")]
        public string IsSuccess { get; set; }

        /// <summary>
        /// 不可用产品集合
        /// </summary>
        [JsonPropertyName("unusable_product_list")]
        public string UnusableProductList { get; set; }

        /// <summary>
        /// 可用产品集合
        /// </summary>
        [JsonPropertyName("usable_product_group")]
        public string UsableProductGroup { get; set; }
    }
}

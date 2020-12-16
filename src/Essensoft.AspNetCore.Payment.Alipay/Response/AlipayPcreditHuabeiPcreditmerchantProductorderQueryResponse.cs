using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditmerchantProductorderQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiPcreditmerchantProductorderQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 业务返回成功与否标志
        /// </summary>
        [JsonPropertyName("biz_success")]
        public bool BizSuccess { get; set; }

        /// <summary>
        /// 订购查询请求对象
        /// </summary>
        [JsonPropertyName("data")]
        public HbProductOrderQueryResponse Data { get; set; }

        /// <summary>
        /// 业务错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 业务错误描述信息
        /// </summary>
        [JsonPropertyName("error_message")]
        public string ErrorMessage { get; set; }
    }
}

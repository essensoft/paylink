using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandBenefitRecordQueryResponse.
    /// </summary>
    public class AntMerchantExpandBenefitRecordQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 业务扩展信息
        /// </summary>
        [JsonPropertyName("biz_ext")]
        public string BizExt { get; set; }

        /// <summary>
        /// 返回的数据,JSON格式
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }

        /// <summary>
        /// 查询失败时，返回的错误信息
        /// </summary>
        [JsonPropertyName("detail_msg")]
        public string DetailMsg { get; set; }

        /// <summary>
        /// 查询失败的错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }
    }
}

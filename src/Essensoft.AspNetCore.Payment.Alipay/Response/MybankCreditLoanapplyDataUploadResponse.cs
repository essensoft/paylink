using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditLoanapplyDataUploadResponse.
    /// </summary>
    public class MybankCreditLoanapplyDataUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 数据在网商银行内部系统的唯一ID。由网商银行融资平台的系统生成，返回给外部机构。
        /// </summary>
        [JsonPropertyName("data_id")]
        public string DataId { get; set; }
    }
}

using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataBillEreceiptApplyResponse.
    /// </summary>
    public class AlipayDataBillEreceiptApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 文件申请号file_id信息。使用file_id可以查询处理状态
        /// </summary>
        [JsonPropertyName("file_id")]
        public string FileId { get; set; }
    }
}

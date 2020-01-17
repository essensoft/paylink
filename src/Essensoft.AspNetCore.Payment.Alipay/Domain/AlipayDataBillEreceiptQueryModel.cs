using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataBillEreceiptQueryModel Data Structure.
    /// </summary>
    public class AlipayDataBillEreceiptQueryModel : AlipayObject
    {
        /// <summary>
        /// 根据申请id查询状态
        /// </summary>
        [JsonPropertyName("file_id")]
        public string FileId { get; set; }
    }
}

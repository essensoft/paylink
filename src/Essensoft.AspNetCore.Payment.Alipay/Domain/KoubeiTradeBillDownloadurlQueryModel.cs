using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiTradeBillDownloadurlQueryModel Data Structure.
    /// </summary>
    public class KoubeiTradeBillDownloadurlQueryModel : AlipayObject
    {
        /// <summary>
        /// 账单数据的产生时间
        /// </summary>
        [JsonPropertyName("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// 对应账单类型，如业务帐
        /// </summary>
        [JsonPropertyName("bill_type")]
        public string BillType { get; set; }

        /// <summary>
        /// 账单的生成类型，如日账单/周账单/月账单
        /// </summary>
        [JsonPropertyName("date_type")]
        public string DateType { get; set; }

        /// <summary>
        /// 查询文件的格式
        /// </summary>
        [JsonPropertyName("file_type")]
        public string FileType { get; set; }
    }
}

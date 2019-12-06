using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoRenthouseBillOrderDownloadModel Data Structure.
    /// </summary>
    public class AlipayEcoRenthouseBillOrderDownloadModel : AlipayObject
    {
        /// <summary>
        /// 查询日期
        /// </summary>
        [JsonPropertyName("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// 商户编号
        /// </summary>
        [JsonPropertyName("merchant_no")]
        public string MerchantNo { get; set; }
    }
}

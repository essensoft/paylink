using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaMerchantCreditlifeRiskApplyModel Data Structure.
    /// </summary>
    public class ZhimaMerchantCreditlifeRiskApplyModel : AlipayObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 证件号，一般为身份证号码
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 接入信用套餐所分配的产品码
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 手机联系方式
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 业务流水号，每一笔业务使用一个新的业务流水号，不能重复
        /// </summary>
        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }
    }
}

using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// PayContractBaseDTO Data Structure.
    /// </summary>
    public class PayContractBaseDTO : AlipayObject
    {
        /// <summary>
        /// 合约号
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 合约来源,集采平台：acep
        /// </summary>
        [JsonPropertyName("agreement_source")]
        public string AgreementSource { get; set; }

        /// <summary>
        /// 业务产品码
        /// </summary>
        [JsonPropertyName("biz_pd_code")]
        public string BizPdCode { get; set; }

        /// <summary>
        /// 幂等号
        /// </summary>
        [JsonPropertyName("idempotent_no")]
        public string IdempotentNo { get; set; }

        /// <summary>
        /// 供应商蚂蚁2088账号
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 供应商来源
        /// </summary>
        [JsonPropertyName("ip_role_source")]
        public string IpRoleSource { get; set; }

        /// <summary>
        /// 端产品码
        /// </summary>
        [JsonPropertyName("pd_code")]
        public string PdCode { get; set; }

        /// <summary>
        /// 签约产品码
        /// </summary>
        [JsonPropertyName("sales_product_code")]
        public string SalesProductCode { get; set; }
    }
}

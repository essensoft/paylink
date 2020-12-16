using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundTransInvoiceResubmitModifyModel Data Structure.
    /// </summary>
    public class AlipayFundTransInvoiceResubmitModifyModel : AlipayObject
    {
        /// <summary>
        /// 业务ID
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 是否是区块链数据 1 是区块链 0 非区块链
        /// </summary>
        [JsonPropertyName("is_block")]
        public string IsBlock { get; set; }

        /// <summary>
        /// 用户标识
        /// </summary>
        [JsonPropertyName("uid_range")]
        public string UidRange { get; set; }
    }
}

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// VoucherModifyInfo Data Structure.
    /// </summary>
    public class VoucherModifyInfo : AlipayObject
    {
        /// <summary>
        /// 追加的适用门店
        /// </summary>
        [JsonPropertyName("suitable_shops")]
        public List<string> SuitableShops { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonPropertyName("voucher_desc")]
        public string VoucherDesc { get; set; }

        /// <summary>
        /// 券id
        /// </summary>
        [JsonPropertyName("voucher_id")]
        public string VoucherId { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        [JsonPropertyName("voucher_name")]
        public string VoucherName { get; set; }

        /// <summary>
        /// 使用须知
        /// </summary>
        [JsonPropertyName("voucher_terms")]
        public List<VoucherTermInfo> VoucherTerms { get; set; }
    }
}

using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SubAccountBaseInfo Data Structure.
    /// </summary>
    public class SubAccountBaseInfo : AlipayObject
    {
        /// <summary>
        /// 主账号
        /// </summary>
        [JsonPropertyName("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 全球化银行缩写
        /// </summary>
        [JsonPropertyName("out_fin_inst_abbreviation")]
        public string OutFinInstAbbreviation { get; set; }

        /// <summary>
        /// 子账号
        /// </summary>
        [JsonPropertyName("sub_account_no")]
        public string SubAccountNo { get; set; }
    }
}

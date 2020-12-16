using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossProdProtocolOrderPreviewModel Data Structure.
    /// </summary>
    public class AlipayBossProdProtocolOrderPreviewModel : AlipayObject
    {
        /// <summary>
        /// 签约账号
        /// </summary>
        [JsonPropertyName("card_nos")]
        public List<string> CardNos { get; set; }

        /// <summary>
        /// 商户联系人信息
        /// </summary>
        [JsonPropertyName("contact_info")]
        public ContactInfomation ContactInfo { get; set; }

        /// <summary>
        /// 是否需要包含个性化价格协议
        /// </summary>
        [JsonPropertyName("include_custom_protocol")]
        public bool IncludeCustomProtocol { get; set; }

        /// <summary>
        /// 商户信息
        /// </summary>
        [JsonPropertyName("merchant_info")]
        public MerchantInformation MerchantInfo { get; set; }

        /// <summary>
        /// 是否需要文件
        /// </summary>
        [JsonPropertyName("need_file")]
        public bool NeedFile { get; set; }

        /// <summary>
        /// 是否需要填充协议模板动态内容（如需要，签约账号，商户信息，联系人信息需要传递）
        /// </summary>
        [JsonPropertyName("need_fill_item")]
        public bool NeedFillItem { get; set; }

        /// <summary>
        /// 是否返回html
        /// </summary>
        [JsonPropertyName("need_html")]
        public bool NeedHtml { get; set; }

        /// <summary>
        /// 销售方案
        /// </summary>
        [JsonPropertyName("sale_plans")]
        public SalePlanInfo SalePlans { get; set; }

        /// <summary>
        /// 系统来源，不填默认为主站
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }
    }
}

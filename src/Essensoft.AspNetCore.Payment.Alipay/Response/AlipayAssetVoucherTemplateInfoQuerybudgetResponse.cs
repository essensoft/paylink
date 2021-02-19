using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayAssetVoucherTemplateInfoQuerybudgetResponse.
    /// </summary>
    public class AlipayAssetVoucherTemplateInfoQuerybudgetResponse : AlipayResponse
    {
        /// <summary>
        /// 券模板预算列表
        /// </summary>
        [JsonPropertyName("template_list")]
        public List<VoucherTemplateBudgetDTO> TemplateList { get; set; }
    }
}

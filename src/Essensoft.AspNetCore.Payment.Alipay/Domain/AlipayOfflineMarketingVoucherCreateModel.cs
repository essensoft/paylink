using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOfflineMarketingVoucherCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketingVoucherCreateModel : AlipayObject
    {
        /// <summary>
        /// 预算信息
        /// </summary>
        [JsonProperty("budget_info")]
        [XmlElement("budget_info")]
        public BudgetInfo BudgetInfo { get; set; }

        /// <summary>
        /// 券码池编号。该值调用：alipay.offline.marketing.voucher.code.upload接口生成
        /// </summary>
        [JsonProperty("code_inventory_id")]
        [XmlElement("code_inventory_id")]
        public string CodeInventoryId { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [JsonProperty("ext_info")]
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 发放规则信息
        /// </summary>
        [JsonProperty("get_rule")]
        [XmlElement("get_rule")]
        public GetRuleInfo GetRule { get; set; }

        /// <summary>
        /// 外部流水号.需商家自己生成并保证每次请求的唯一性
        /// </summary>
        [JsonProperty("out_biz_no")]
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 券模板信息
        /// </summary>
        [JsonProperty("voucher_info")]
        [XmlElement("voucher_info")]
        public VoucherInfo VoucherInfo { get; set; }
    }
}

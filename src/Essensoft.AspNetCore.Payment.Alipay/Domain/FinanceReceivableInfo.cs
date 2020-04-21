using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FinanceReceivableInfo Data Structure.
    /// </summary>
    public class FinanceReceivableInfo : AlipayObject
    {
        /// <summary>
        /// 账款金额，以元为单位，精确到小数点后2位
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 核心企业信息
        /// </summary>
        [JsonPropertyName("core_business_info")]
        public FinanceMemberInfo CoreBusinessInfo { get; set; }

        /// <summary>
        /// 向核心企业授信的配置id(已弃用)，请参考credit_idxs
        /// </summary>
        [JsonPropertyName("credit_ids")]
        public List<string> CreditIds { get; set; }

        /// <summary>
        /// 授信列表
        /// </summary>
        [JsonPropertyName("credit_idxs")]
        public List<FinanceCreditItem> CreditIdxs { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// UTC标准格式
        /// </summary>
        [JsonPropertyName("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 发票信息列表
        /// </summary>
        [JsonPropertyName("invoice_list")]
        public List<FinanceInvoiceInfo> InvoiceList { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 核心企业角度的应收账款编号
        /// </summary>
        [JsonPropertyName("out_asset_id")]
        public string OutAssetId { get; set; }

        /// <summary>
        /// 采购内容信息
        /// </summary>
        [JsonPropertyName("purchase")]
        public FinancePurchaseInfo Purchase { get; set; }

        /// <summary>
        /// 供应商信息
        /// </summary>
        [JsonPropertyName("supplier_info")]
        public FinanceMemberInfo SupplierInfo { get; set; }
    }
}

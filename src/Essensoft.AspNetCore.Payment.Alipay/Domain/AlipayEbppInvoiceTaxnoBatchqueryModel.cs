using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceTaxnoBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceTaxnoBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 默认值为false。true为输出交易信息，false为不输出交易信息。
        /// </summary>
        [JsonPropertyName("enable_trade_out")]
        public string EnableTradeOut { get; set; }

        /// <summary>
        /// 查询结束时间，精确到天（按开票日期查询） start_invoice_date和end_invoice_date传值要求 1.同时为空时，返回最近半年200条数据 2.必须同时为空 或 同时不为空 3.结束日期不能大于当前日期 4.开始时间和结束时间跨度不能超过6个月
        /// </summary>
        [JsonPropertyName("end_invoice_date")]
        public string EndInvoiceDate { get; set; }

        /// <summary>
        /// 查询票种列表  可选值  PLAIN：增值税电子普通发票  SPECIAL：增值税专用发票  PLAIN_INVOICE:增值税普通发票  PAPER_INVOICE:增值税普通发票（卷式）  SALSE_INVOICE:机动车销售统一发票
        /// </summary>
        [JsonPropertyName("invoice_kind_list")]
        public List<string> InvoiceKindList { get; set; }

        /// <summary>
        /// 查询结果上限笔数，最大值20
        /// </summary>
        [JsonPropertyName("limit_size")]
        public long LimitSize { get; set; }

        /// <summary>
        /// 当前页码，为空时默认第一页
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 发票要素获取应用场景  INVOICE_EXPENSE－发票报销
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 查询起始时间，精确到天（按开票日期查询） start_invoice_date和end_invoice_date传值要求 1.同时为空时，返回最近半年200条数据 2.必须同时为空 或 同时不为空 3.结束日期不能大于当前日期 4.开始时间和结束时间跨度不能超过6个月
        /// </summary>
        [JsonPropertyName("start_invoice_date")]
        public string StartInvoiceDate { get; set; }

        /// <summary>
        /// 企业税号
        /// </summary>
        [JsonPropertyName("tax_no")]
        public string TaxNo { get; set; }
    }
}

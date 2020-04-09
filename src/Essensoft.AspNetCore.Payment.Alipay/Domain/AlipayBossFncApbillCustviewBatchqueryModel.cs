using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossFncApbillCustviewBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayBossFncApbillCustviewBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 合约号
        /// </summary>
        [JsonPropertyName("ar_no")]
        public string ArNo { get; set; }

        /// <summary>
        /// 账单关联发票状态列表 [01-未关联；02-部分关联；03-完全关联]
        /// </summary>
        [JsonPropertyName("bill_invoice_link_statuses")]
        public List<string> BillInvoiceLinkStatuses { get; set; }

        /// <summary>
        /// 默人["22"] 账单类型列表{"11":"应收普通日账单","12":"应收调整日账单","13":"应付普通日账单","14":"应付汇总调整日账单","15":"应付明细调整明细调整金额日账单","17":"应付普通日账单","18":"应收延迟日账单","21":"应收月账单","22":"应付月账单","23":"AP预付月账单","24":"通用记账凭证详情单","25":"应收调账月账单","26":"应收延迟月账单","31":"应收普通账单","32":"应收调账账单","33":"应收延迟账单","40":"AP付款单","41":"AP月账单"}
        /// </summary>
        [JsonPropertyName("bill_types")]
        public List<string> BillTypes { get; set; }

        /// <summary>
        /// 业务类型，默认COMMISSION
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 币种编码 如CNY ,156 接口内部会进行币种转换[ 156 -->156;  CNY--> 156]，参考枚举com.alipay.fc.common.lang.money.CurrencyEnum
        /// </summary>
        [JsonPropertyName("ccy")]
        public string Ccy { get; set; }

        /// <summary>
        /// 查询结束月份，格式yyyyMM
        /// </summary>
        [JsonPropertyName("end_month")]
        public string EndMonth { get; set; }

        /// <summary>
        /// 分支机构ID（OU标识）
        /// </summary>
        [JsonPropertyName("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 发票种类{"01":"增值税专用发票","02":"增值税普通发票","05":"其它发票","07":"虚拟发票"}
        /// </summary>
        [JsonPropertyName("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 参与者角色ID
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 起始页；默认1
        /// </summary>
        [JsonPropertyName("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页显示数；默认20，最大建议不超过1000
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 支付状态列表 [01-待结算；02-部分结算；03-结算完成]
        /// </summary>
        [JsonPropertyName("pay_statuses")]
        public List<string> PayStatuses { get; set; }

        /// <summary>
        /// 产品码列表
        /// </summary>
        [JsonPropertyName("pd_codes")]
        public List<string> PdCodes { get; set; }

        /// <summary>
        /// 价格标识
        /// </summary>
        [JsonPropertyName("price_id")]
        public string PriceId { get; set; }

        /// <summary>
        /// 价格政策ID
        /// </summary>
        [JsonPropertyName("price_policy_id")]
        public string PricePolicyId { get; set; }

        /// <summary>
        /// 结算类型 [01-实时结算类型；02-后付类型]
        /// </summary>
        [JsonPropertyName("settle_type")]
        public List<string> SettleType { get; set; }

        /// <summary>
        /// 查询开始月份，格式yyyyMM
        /// </summary>
        [JsonPropertyName("start_month")]
        public string StartMonth { get; set; }
    }
}

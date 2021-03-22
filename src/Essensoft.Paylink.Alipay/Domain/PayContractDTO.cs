using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// PayContractDTO Data Structure.
    /// </summary>
    public class PayContractDTO : AlipayObject
    {
        /// <summary>
        /// 账号扩展属性，主要是国际付款涉及到的swfitcode信息
        /// </summary>
        [JsonPropertyName("account_ext_info")]
        public MapTypeParam AccountExtInfo { get; set; }

        /// <summary>
        /// 账户名称
        /// </summary>
        [JsonPropertyName("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        [JsonPropertyName("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 银行卡:BANKCARD 支付宝账号:ALIPAYACCOUNT
        /// </summary>
        [JsonPropertyName("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// P2P为PO号，O2P为合约号
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 合约来源，与合约号一起确认路由查询合约信息
        /// </summary>
        [JsonPropertyName("agreement_source")]
        public string AgreementSource { get; set; }

        /// <summary>
        /// 业务产品码
        /// </summary>
        [JsonPropertyName("biz_pdcode")]
        public string BizPdcode { get; set; }

        /// <summary>
        /// 支行名称
        /// </summary>
        [JsonPropertyName("branch_name")]
        public string BranchName { get; set; }

        /// <summary>
        /// OU公司代码
        /// </summary>
        [JsonPropertyName("company_code")]
        public string CompanyCode { get; set; }

        /// <summary>
        /// 币种代码，人民币:156
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 幂等号
        /// </summary>
        [JsonPropertyName("idempotent_no")]
        public string IdempotentNo { get; set; }

        /// <summary>
        /// 蚂蚁商户2088账号
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// pid来源
        /// </summary>
        [JsonPropertyName("ip_role_source")]
        public string IpRoleSource { get; set; }

        /// <summary>
        /// 付款条款明细
        /// </summary>
        [JsonPropertyName("pay_contract_items")]
        public List<PayContractItemDTO> PayContractItems { get; set; }

        /// <summary>
        /// 付款类型，货到付款:PAY_AFTER_RECEIPT,阶段付款:MILESTONE
        /// </summary>
        [JsonPropertyName("payment_type")]
        public string PaymentType { get; set; }

        /// <summary>
        /// 端产品码
        /// </summary>
        [JsonPropertyName("pd_code")]
        public string PdCode { get; set; }

        /// <summary>
        /// 签约销售产品码
        /// </summary>
        [JsonPropertyName("sales_product_code")]
        public string SalesProductCode { get; set; }

        /// <summary>
        /// 系统来源
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }
    }
}

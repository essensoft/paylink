using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundBatchTransferModel Data Structure.
    /// </summary>
    public class AlipayFundBatchTransferModel : AlipayObject
    {
        /// <summary>
        /// 代发到账户明细列。biz_code=BATCH_TRANS_ACC时，该参数必填。biz_code为其他值时忽略该参数。
        /// </summary>
        [JsonPropertyName("acc_detail_list")]
        public List<AccTransDetail> AccDetailList { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [JsonPropertyName("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 付款方账单地址，用于反洗钱，biz_scene=GLOBAL时必填。格式: 两位国家编码,账单地址.  账单地址至少提供到市. 账单地址中只能包含如下字符: a-zA-Z0-9()/-?:.'+, 和空格。
        /// </summary>
        [JsonPropertyName("billing_address")]
        public string BillingAddress { get; set; }

        /// <summary>
        /// 批量代发业务标识。        批量代发到账户：BATCH_TRANS_ACC      批量代发到银行卡：BATCH_TRANS_BC
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 批量代发业务场景。    GLOBAL: 全球代发. 除CNY的多币种代发或人民币跨境代发。  LOCAL：中国境内纯人民币代发。
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 扩展参数。使用前需要和支付宝先约定key值。
        /// </summary>
        [JsonPropertyName("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 跨境批量代发场景下，描述批量代发请求，是否针对付汇失败场景下商户所做的重试。  T: 代表重试请求，对应的代发文件明细中alipay_order_no不能为空；  F: 代表非重试请求，对应的代发文件明细中alipay_order_no必须为空。    biz_scene=LOCAL时忽略该参数。
        /// </summary>
        [JsonPropertyName("pay_retry")]
        public string PayRetry { get; set; }

        /// <summary>
        /// 付款方账号，来账场景中填写VA账号。
        /// </summary>
        [JsonPropertyName("payer_account")]
        public string PayerAccount { get; set; }

        /// <summary>
        /// 付款方账号类型.与payer_account配合使用, 如果payer_account是VA账号, 则填写VA.
        /// </summary>
        [JsonPropertyName("payer_account_type")]
        public string PayerAccountType { get; set; }

        /// <summary>
        /// 商户支付给支付宝的币种。     biz_scene=GLOBAL时必填;     biz_scene=LOCAL时忽略该参数。
        /// </summary>
        [JsonPropertyName("payment_currency")]
        public string PaymentCurrency { get; set; }

        /// <summary>
        /// 批量代发产品签约产品码。
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 对客资金交割时效。     biz_scene=GLOBAL时, 如果未填写以合约为准。      biz_scene=LOCAL时, 忽略该参数。
        /// </summary>
        [JsonPropertyName("request_value_time")]
        public string RequestValueTime { get; set; }

        /// <summary>
        /// 签约主体，即签约了批量代发产品的支付宝账号。
        /// </summary>
        [JsonPropertyName("sign_principal")]
        public string SignPrincipal { get; set; }

        /// <summary>
        /// 本次代发明细总数据. 正整数，最小1笔，最大支持1000笔，该字段值会和明细总数做比对校验。
        /// </summary>
        [JsonPropertyName("total_count")]
        public string TotalCount { get; set; }

        /// <summary>
        /// 总转账金额。   biz_scene=LOCAL时，该参数必传。   biz_scene=GLOBAL时，如果明细列中trans_currency只存在一种币种，且值等于payment_currency时，该参数必传，并且total_trans_amount等于明细列中trans_amount累加总和。其他场景下，忽略该参数。
        /// </summary>
        [JsonPropertyName("total_trans_amount")]
        public string TotalTransAmount { get; set; }

        /// <summary>
        /// 转账币种三位英文短码, 用于修饰total_trans_amount.    biz_scene=LOCAL时，该参数选传, 如果传入必须为CNY。    biz_scene=GLOBAL时，如果明细列中trans_currency只存在一种币种，且值等于payment_currency时，该参数必传，与trans_currency相同。其他场景下，忽略该参数。
        /// </summary>
        [JsonPropertyName("total_trans_currency")]
        public string TotalTransCurrency { get; set; }
    }
}

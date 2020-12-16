using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasTaxAdvancedCreateModel Data Structure.
    /// </summary>
    public class AlipayOverseasTaxAdvancedCreateModel : AlipayObject
    {
        /// <summary>
        /// 纸质退税单号，合并退税时需要传多个，逗号分隔，tax_refund_scene_type=09时只支持一个docId
        /// </summary>
        [JsonPropertyName("doc_id")]
        public string DocId { get; set; }

        /// <summary>
        /// 业务扩展参数，用于商户的特定业务信息的传递，json格式
        /// </summary>
        [JsonPropertyName("extend_param")]
        public string ExtendParam { get; set; }

        /// <summary>
        /// 支付宝账号标识号，由identify_account_type指定类型: identify_account_type为barcode表示支付宝钱包付款码，退税公司通过扫描用户支付宝钱包付款码获取，17位到32位的数字. identify_account_type为uid表示支付宝用户Id
        /// </summary>
        [JsonPropertyName("identify_account_no")]
        public string IdentifyAccountNo { get; set; }

        /// <summary>
        /// 支付宝账号标识类型， tax_refund_scene_type=09时传uid，tax_refund_scene_type=10时传barcode
        /// </summary>
        [JsonPropertyName("identify_account_type")]
        public string IdentifyAccountType { get; set; }

        /// <summary>
        /// 国籍，用户护照上的国家码
        /// </summary>
        [JsonPropertyName("nationality")]
        public string Nationality { get; set; }

        /// <summary>
        /// 外部退税商户ID，商户在退税机构的ID
        /// </summary>
        [JsonPropertyName("out_merchant_id")]
        public string OutMerchantId { get; set; }

        /// <summary>
        /// 退税机构业务流水号，唯一，只能包含字母、数字。
        /// </summary>
        [JsonPropertyName("out_tax_refund_no")]
        public string OutTaxRefundNo { get; set; }

        /// <summary>
        /// 护照姓名，用户护照上的英文姓名
        /// </summary>
        [JsonPropertyName("passport_name")]
        public string PassportName { get; set; }

        /// <summary>
        /// 护照号码
        /// </summary>
        [JsonPropertyName("passport_no")]
        public string PassportNo { get; set; }

        /// <summary>
        /// 该笔订单允许的最晚付款时间，逾期将关闭该笔订单。取值范围：1m～15d。m-分钟，h-小时，d-天。 该参数数值不接受小数点，如1.5h，可转换为90m。如果为空，默认15m
        /// </summary>
        [JsonPropertyName("pay_timeout")]
        public string PayTimeout { get; set; }

        /// <summary>
        /// 退税金额，币种由tax_refund_currency指定，精确到币种最小单位，如tax_refund_currency为SGD，币种最小单位为分，100元新币，则tax_refund_amount传入10000
        /// </summary>
        [JsonPropertyName("tax_refund_amount")]
        public string TaxRefundAmount { get; set; }

        /// <summary>
        /// 退税发生国家, ISO标准alpha-2国家代码
        /// </summary>
        [JsonPropertyName("tax_refund_country")]
        public string TaxRefundCountry { get; set; }

        /// <summary>
        /// 退税币种，一般指外币，ISO标准alpha-3币种代码
        /// </summary>
        [JsonPropertyName("tax_refund_currency")]
        public string TaxRefundCurrency { get; set; }

        /// <summary>
        /// 退税场景类型，09 线上预授权退税，10 线下预授权退税
        /// </summary>
        [JsonPropertyName("tax_refund_scene_type")]
        public string TaxRefundSceneType { get; set; }

        /// <summary>
        /// 用户实际收到的退税金额，币种由user_received_currency指定，精确到币种最小单位，如user_received_currency为CNY，币种最小单位为分，100元人民币，则user_received_amount传入10000
        /// </summary>
        [JsonPropertyName("user_received_amount")]
        public string UserReceivedAmount { get; set; }

        /// <summary>
        /// 用户实际收款币种，一般指人民币 CNY，ISO标准alpha-3币种代码
        /// </summary>
        [JsonPropertyName("user_received_currency")]
        public string UserReceivedCurrency { get; set; }
    }
}

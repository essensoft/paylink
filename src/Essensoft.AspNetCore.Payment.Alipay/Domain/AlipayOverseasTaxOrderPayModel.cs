using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasTaxOrderPayModel Data Structure.
    /// </summary>
    public class AlipayOverseasTaxOrderPayModel : AlipayObject
    {
        /// <summary>
        /// 退税数据有效天数，15到30天，超过指定天数未处理的退税单会过期而退税失败
        /// </summary>
        [JsonPropertyName("available_day")]
        public long AvailableDay { get; set; }

        /// <summary>
        /// 业务模式，目前暂只支持 FOREX_TAX_REFUND (外币退税)
        /// </summary>
        [JsonPropertyName("biz_mode")]
        public string BizMode { get; set; }

        /// <summary>
        /// 退税公司名称
        /// </summary>
        [JsonPropertyName("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 用户出境确认时间，格式 : yyyy-MM-dd HH:mm:ss，北京时间24小时制，时区东八区
        /// </summary>
        [JsonPropertyName("confirm_date")]
        public string ConfirmDate { get; set; }

        /// <summary>
        /// 退税国家码，ISO标准alpha-2国家代码
        /// </summary>
        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// 出境口岸
        /// </summary>
        [JsonPropertyName("departure_point")]
        public string DeparturePoint { get; set; }

        /// <summary>
        /// 退税单过期时间，退税单据的有效期是6个月，退税打印时间+6个月，格式 : yyyy-MM-dd HH:mm:ss，北京时间24小时制，时区东八区
        /// </summary>
        [JsonPropertyName("doc_expire_date")]
        public string DocExpireDate { get; set; }

        /// <summary>
        /// 纸质退税单上的ID，由退税公司给出；由字母、数字构成且长度不能小于3且不能大于64。
        /// </summary>
        [JsonPropertyName("doc_id")]
        public string DocId { get; set; }

        /// <summary>
        /// 业务扩展参数，用于商户的特定业务信息的传递,json格式.当identify_account_type为uid,退税公司必须传递支付宝钱包付款码，退税公司通过扫描用户支付宝钱包付款码获取,17位到32位的数字.格式为{"barcodeNo":"barcodeNo"}
        /// </summary>
        [JsonPropertyName("extend_param")]
        public string ExtendParam { get; set; }

        /// <summary>
        /// 支付宝账号标识号，由identify_account_type指定类型:  identify_account_type为barcode表示支付宝钱包付款码，退税公司通过扫描用户支付宝钱包付款码获取，17位到32位的数字.  identify_account_type为uid表示支付宝用户Id,退税公司通过调用alipay.overseas.tax.userinfo.query接口获取
        /// </summary>
        [JsonPropertyName("identify_account_no")]
        public string IdentifyAccountNo { get; set; }

        /// <summary>
        /// 支付宝账号标识类型，  条码退税，取值：barcode,uid
        /// </summary>
        [JsonPropertyName("identify_account_type")]
        public string IdentifyAccountType { get; set; }

        /// <summary>
        /// 国籍，用户护照上的国家码
        /// </summary>
        [JsonPropertyName("nationality")]
        public string Nationality { get; set; }

        /// <summary>
        /// 退税机构业务流水号，唯一，由退税机构生成，只能包含英字母、数字，长度不能小于3且不能大于64
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 护照姓名，用户护照上的英文姓名
        /// </summary>
        [JsonPropertyName("passport_name")]
        public string PassportName { get; set; }

        /// <summary>
        /// 护照号，退税客人的护照号
        /// </summary>
        [JsonPropertyName("passport_no")]
        public string PassportNo { get; set; }

        /// <summary>
        /// 购物金额，退税单上的购物金额，为数字格式，精确到币种最小单位，币种由sales_currency指定，如sales_currency为SGD，币种最小单位为分，100元新币，则sales_amount传入10000.
        /// </summary>
        [JsonPropertyName("sales_amount")]
        public string SalesAmount { get; set; }

        /// <summary>
        /// 购物币种，ISO标准购物国家alpha-3币种代码
        /// </summary>
        [JsonPropertyName("sales_currency")]
        public string SalesCurrency { get; set; }

        /// <summary>
        /// 购物时间，格式 : yyyy-MM-dd HH:mm:ss，北京时间24小时制，时区东八区
        /// </summary>
        [JsonPropertyName("sales_date")]
        public string SalesDate { get; set; }

        /// <summary>
        /// 退税金额，退税公司退税金额，币种由tax_refund_currency指定，精确到币种最小单位，如tax_refund_currency为SGD，币种最小单位为分，100元新币，则tax_refund_amount传入10000.
        /// </summary>
        [JsonPropertyName("tax_refund_amount")]
        public string TaxRefundAmount { get; set; }

        /// <summary>
        /// 退税公司退税币种，一般指外币，ISO标准退税国家alpha-3币种代码
        /// </summary>
        [JsonPropertyName("tax_refund_currency")]
        public string TaxRefundCurrency { get; set; }

        /// <summary>
        /// 退税单打印时间，格式 : yyyy-MM-dd HH:mm:ss，北京时间24小时制，时区东八区
        /// </summary>
        [JsonPropertyName("tax_refund_print_date")]
        public string TaxRefundPrintDate { get; set; }

        /// <summary>
        /// 退税场景类型，03 机场实时退税，目前暂只支持03
        /// </summary>
        [JsonPropertyName("tax_refund_scene_type")]
        public string TaxRefundSceneType { get; set; }

        /// <summary>
        /// 用户实际收到的退税金额，币种由user_received_currency指定，精确到最小币种单位，如user_received_currency为CNY，币种最小单位为分，100元人民币，则user_received_amount传入10000，当biz_mode为FOREX_TAX_REFUND时勿传
        /// </summary>
        [JsonPropertyName("user_received_amount")]
        public string UserReceivedAmount { get; set; }

        /// <summary>
        /// 用户实际收款币种，一般指人民币 CNY，ISO标准退税国家alpha-3币种代码
        /// </summary>
        [JsonPropertyName("user_received_currency")]
        public string UserReceivedCurrency { get; set; }
    }
}

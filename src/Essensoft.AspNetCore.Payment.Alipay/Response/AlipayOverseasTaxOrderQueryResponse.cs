using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOverseasTaxOrderQueryResponse.
    /// </summary>
    public class AlipayOverseasTaxOrderQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用于识别用户支付宝账号的号码，由identify_account_type指定类型:  identify_account_type为barcode表示支付宝钱包付款码，退税公司通过扫描用户支付宝钱包付款码获取
        /// </summary>
        [JsonPropertyName("identify_account_no")]
        public string IdentifyAccountNo { get; set; }

        /// <summary>
        /// 用于识别用户支付宝账号的类型  条码退税，取值：barcode
        /// </summary>
        [JsonPropertyName("identify_account_type")]
        public string IdentifyAccountType { get; set; }

        /// <summary>
        /// 退税机构业务流水号，唯一，由退税机构生成，只能包含英字母、数字，长度不能小于3且不能大于64
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 退税状态，S 表示退税成功；F表示退税失败
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 退税成功时间，只有status为S时才有值，时间格式：YYYY-MM-DD HH:MM:SS，北京时间24小时制，时区东八区
        /// </summary>
        [JsonPropertyName("success_time")]
        public string SuccessTime { get; set; }

        /// <summary>
        /// 支付宝的退税序列号
        /// </summary>
        [JsonPropertyName("tax_no")]
        public string TaxNo { get; set; }
    }
}

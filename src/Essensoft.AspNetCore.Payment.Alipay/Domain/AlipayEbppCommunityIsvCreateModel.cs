using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppCommunityIsvCreateModel Data Structure.
    /// </summary>
    public class AlipayEbppCommunityIsvCreateModel : AlipayObject
    {
        /// <summary>
        /// 更多账单跳转地址
        /// </summary>
        [JsonPropertyName("bill_link_url")]
        public string BillLinkUrl { get; set; }

        /// <summary>
        /// 户号查询电话
        /// </summary>
        [JsonPropertyName("billkey_query_mobile")]
        public string BillkeyQueryMobile { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [JsonPropertyName("isv_app_id")]
        public string IsvAppId { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 服务商的名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 收款账号, 必须为支付宝商户账号
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 返佣账号
        /// </summary>
        [JsonPropertyName("rake_back_acct")]
        public string RakeBackAcct { get; set; }

        /// <summary>
        /// 支付宝：ALIPAY，银行卡：BANK
        /// </summary>
        [JsonPropertyName("rake_back_acct_type")]
        public string RakeBackAcctType { get; set; }

        /// <summary>
        /// 对应的商务人员
        /// </summary>
        [JsonPropertyName("related_bd")]
        public string RelatedBd { get; set; }

        /// <summary>
        /// LE_10("LE_10", "10小区"), BETWEEN10_100("BETWEEN10_100", "10~100小区"), BETWEEN100_500("BETWEEN100_500", "100~500小区"), BETWEEN500_1000("BETWEEN500_1000", GE1000("GE1000", "1000+");
        /// </summary>
        [JsonPropertyName("scale")]
        public string Scale { get; set; }

        /// <summary>
        /// ISV类型 开发者 SYSTEM_PROVIDER 大物业 TOP_PROPERTY_COMP 政府 GOVERMENT
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}

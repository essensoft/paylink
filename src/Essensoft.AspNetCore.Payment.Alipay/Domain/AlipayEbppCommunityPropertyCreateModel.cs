using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppCommunityPropertyCreateModel Data Structure.
    /// </summary>
    public class AlipayEbppCommunityPropertyCreateModel : AlipayObject
    {
        /// <summary>
        /// 外部联系人
        /// </summary>
        [JsonPropertyName("contacts")]
        public List<ExternalContact> Contacts { get; set; }

        /// <summary>
        /// 支付宝为ISV生成的短码, 原则上是ISV名称的拼音首字母大写+YYYYMMDD+防重位
        /// </summary>
        [JsonPropertyName("isv_short_name")]
        public string IsvShortName { get; set; }

        /// <summary>
        /// 商标地址
        /// </summary>
        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 公司备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 物业公司名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 收款账号, 必须为支付宝商户账号
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 公司长介绍
        /// </summary>
        [JsonPropertyName("rich_text")]
        public string RichText { get; set; }

        /// <summary>
        /// 物业公司规模 10小区            LE_10 10~100小区      BETWEEN10_100 100~500小区    BETWEEN100_500 500~1000小区  BETWEEN500_1000 1000+            GE1000
        /// </summary>
        [JsonPropertyName("scale")]
        public string Scale { get; set; }
    }
}

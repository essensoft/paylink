using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneCouponReceiveModel Data Structure.
    /// </summary>
    public class AlipayInsSceneCouponReceiveModel : AlipayObject
    {
        /// <summary>
        /// 投保人
        /// </summary>
        [JsonPropertyName("applicant")]
        public InsPerson Applicant { get; set; }

        /// <summary>
        /// 保险发奖凭证
        /// </summary>
        [JsonPropertyName("certificate")]
        public InsCertificate Certificate { get; set; }

        /// <summary>
        /// 被保险人
        /// </summary>
        [JsonPropertyName("insured")]
        public InsPerson Insured { get; set; }

        /// <summary>
        /// 市场类型;TAOBAO:淘宝平台,ANT: 蚂蚁平台
        /// </summary>
        [JsonPropertyName("market_type")]
        public string MarketType { get; set; }

        /// <summary>
        /// 商户生成的外部业务号,必须保证唯一，幂等控制
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 产品编码;由蚂蚁保险平台分配
        /// </summary>
        [JsonPropertyName("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 产品版本号
        /// </summary>
        [JsonPropertyName("prod_version")]
        public string ProdVersion { get; set; }

        /// <summary>
        /// 服务场景;  propertyPaySuccess:蚂蚁物业支付成功页面
        /// </summary>
        [JsonPropertyName("service_scenario")]
        public string ServiceScenario { get; set; }
    }
}

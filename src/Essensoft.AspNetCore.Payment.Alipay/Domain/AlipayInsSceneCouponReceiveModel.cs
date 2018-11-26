using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneCouponReceiveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneCouponReceiveModel : AlipayObject
    {
        /// <summary>
        /// 投保人
        /// </summary>
        [JsonProperty("applicant")]
        [XmlElement("applicant")]
        public InsPerson Applicant { get; set; }

        /// <summary>
        /// 保险发奖凭证
        /// </summary>
        [JsonProperty("certificate")]
        [XmlElement("certificate")]
        public InsCertificate Certificate { get; set; }

        /// <summary>
        /// 被保险人
        /// </summary>
        [JsonProperty("insured")]
        [XmlElement("insured")]
        public InsPerson Insured { get; set; }

        /// <summary>
        /// 市场类型;TAOBAO:淘宝平台,ANT: 蚂蚁平台
        /// </summary>
        [JsonProperty("market_type")]
        [XmlElement("market_type")]
        public string MarketType { get; set; }

        /// <summary>
        /// 商户生成的外部业务号,必须保证唯一，幂等控制
        /// </summary>
        [JsonProperty("out_biz_no")]
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [JsonProperty("partner_id")]
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 产品编码;由蚂蚁保险平台分配
        /// </summary>
        [JsonProperty("prod_code")]
        [XmlElement("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 产品版本号
        /// </summary>
        [JsonProperty("prod_version")]
        [XmlElement("prod_version")]
        public string ProdVersion { get; set; }

        /// <summary>
        /// 服务场景;  propertyPaySuccess:蚂蚁物业支付成功页面
        /// </summary>
        [JsonProperty("service_scenario")]
        [XmlElement("service_scenario")]
        public string ServiceScenario { get; set; }
    }
}

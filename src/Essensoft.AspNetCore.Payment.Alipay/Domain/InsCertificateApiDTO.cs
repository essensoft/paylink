using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsCertificateApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsCertificateApiDTO : AlipayObject
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonProperty("biz_data")]
        [XmlElement("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 保险凭证号
        /// </summary>
        [JsonProperty("certificate_no")]
        [XmlElement("certificate_no")]
        public string CertificateNo { get; set; }

        /// <summary>
        /// 保险凭证类型
        /// </summary>
        [JsonProperty("certificate_type")]
        [XmlElement("certificate_type")]
        public string CertificateType { get; set; }

        /// <summary>
        /// 生效时间
        /// </summary>
        [JsonProperty("effect_time")]
        [XmlElement("effect_time")]
        public string EffectTime { get; set; }

        /// <summary>
        /// 失效时间
        /// </summary>
        [JsonProperty("expire_time")]
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 面值
        /// </summary>
        [JsonProperty("face_value")]
        [XmlElement("face_value")]
        public string FaceValue { get; set; }

        /// <summary>
        /// 机构保单号
        /// </summary>
        [JsonProperty("ins_policy_no")]
        [XmlElement("ins_policy_no")]
        public string InsPolicyNo { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        [JsonProperty("inst_id")]
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [JsonProperty("order_id")]
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单来源
        /// </summary>
        [JsonProperty("order_source")]
        [XmlElement("order_source")]
        public string OrderSource { get; set; }

        /// <summary>
        /// 外部业务单号
        /// </summary>
        [JsonProperty("out_biz_no")]
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 拥有人uid
        /// </summary>
        [JsonProperty("owner_uid")]
        [XmlElement("owner_uid")]
        public string OwnerUid { get; set; }

        /// <summary>
        /// 保险凭证状态
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 使用时间
        /// </summary>
        [JsonProperty("use_time")]
        [XmlElement("use_time")]
        public string UseTime { get; set; }

        /// <summary>
        /// 使用人uid
        /// </summary>
        [JsonProperty("user_uid")]
        [XmlElement("user_uid")]
        public string UserUid { get; set; }
    }
}

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ArrangementBaseVO Data Structure.
    /// </summary>
    [Serializable]
    public class ArrangementBaseVO : AlipayObject
    {
        /// <summary>
        /// 应用id
        /// </summary>
        [JsonProperty("app_id")]
        [XmlElement("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// 签约机构编码
        /// </summary>
        [JsonProperty("arrangement_institution_code")]
        [XmlElement("arrangement_institution_code")]
        public string ArrangementInstitutionCode { get; set; }

        /// <summary>
        /// 合约名称
        /// </summary>
        [JsonProperty("arrangement_name")]
        [XmlElement("arrangement_name")]
        public string ArrangementName { get; set; }

        /// <summary>
        /// 合约编号
        /// </summary>
        [JsonProperty("arrangement_no")]
        [XmlElement("arrangement_no")]
        public string ArrangementNo { get; set; }

        /// <summary>
        /// 合约类型
        /// </summary>
        [JsonProperty("arrangement_type")]
        [XmlElement("arrangement_type")]
        public string ArrangementType { get; set; }

        /// <summary>
        /// 合约版
        /// </summary>
        [JsonProperty("arrangement_version")]
        [XmlElement("arrangement_version")]
        public string ArrangementVersion { get; set; }

        /// <summary>
        /// 签约渠道来源
        /// </summary>
        [JsonProperty("channel_code")]
        [XmlElement("channel_code")]
        public string ChannelCode { get; set; }

        /// <summary>
        /// 合约失效时间
        /// </summary>
        [JsonProperty("gmt_end")]
        [XmlElement("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 到期时间
        /// </summary>
        [JsonProperty("gmt_expired")]
        [XmlElement("gmt_expired")]
        public string GmtExpired { get; set; }

        /// <summary>
        /// 预计合约失效时间
        /// </summary>
        [JsonProperty("gmt_invalid_due")]
        [XmlElement("gmt_invalid_due")]
        public string GmtInvalidDue { get; set; }

        /// <summary>
        /// 合约签署时间
        /// </summary>
        [JsonProperty("gmt_sign")]
        [XmlElement("gmt_sign")]
        public string GmtSign { get; set; }

        /// <summary>
        /// 预计合约生效时间
        /// </summary>
        [JsonProperty("gmt_vald_due")]
        [XmlElement("gmt_vald_due")]
        public string GmtValdDue { get; set; }

        /// <summary>
        /// 合约版本时间
        /// </summary>
        [JsonProperty("gmt_vrsn")]
        [XmlElement("gmt_vrsn")]
        public string GmtVrsn { get; set; }

        /// <summary>
        /// 参与者角色ID
        /// </summary>
        [JsonProperty("ip_role_id")]
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [JsonProperty("last_moder")]
        [XmlElement("last_moder")]
        public string LastModer { get; set; }

        /// <summary>
        /// 外标类型
        /// </summary>
        [JsonProperty("mark_type")]
        [XmlElement("mark_type")]
        public string MarkType { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("memo")]
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 修改人类型
        /// </summary>
        [JsonProperty("moder_type")]
        [XmlElement("moder_type")]
        public string ModerType { get; set; }

        /// <summary>
        /// 签约产品外标
        /// </summary>
        [JsonProperty("pd_mark")]
        [XmlElement("pd_mark")]
        public string PdMark { get; set; }

        /// <summary>
        /// 产品编码
        /// </summary>
        [JsonProperty("prod_code")]
        [XmlElement("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [JsonProperty("prod_name")]
        [XmlElement("prod_name")]
        public string ProdName { get; set; }

        /// <summary>
        /// 产品版本
        /// </summary>
        [JsonProperty("prod_version")]
        [XmlElement("prod_version")]
        public string ProdVersion { get; set; }

        /// <summary>
        /// ps(产品销售)编码
        /// </summary>
        [JsonProperty("ps_code")]
        [XmlElement("ps_code")]
        public string PsCode { get; set; }

        /// <summary>
        /// ps(产品销售)id
        /// </summary>
        [JsonProperty("ps_id")]
        [XmlElement("ps_id")]
        public string PsId { get; set; }

        /// <summary>
        /// 产品销售名称
        /// </summary>
        [JsonProperty("ps_name")]
        [XmlElement("ps_name")]
        public string PsName { get; set; }

        /// <summary>
        /// 合约状态
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 签约模板产品编码
        /// </summary>
        [JsonProperty("template_prod_code")]
        [XmlElement("template_prod_code")]
        public string TemplateProdCode { get; set; }

        /// <summary>
        /// 签约模板产品版本
        /// </summary>
        [JsonProperty("template_prod_version")]
        [XmlElement("template_prod_version")]
        public string TemplateProdVersion { get; set; }
    }
}

using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ArrangementBaseVO Data Structure.
    /// </summary>
    public class ArrangementBaseVO : AlipayObject
    {
        /// <summary>
        /// 应用id
        /// </summary>
        [JsonPropertyName("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// 签约机构编码
        /// </summary>
        [JsonPropertyName("arrangement_institution_code")]
        public string ArrangementInstitutionCode { get; set; }

        /// <summary>
        /// 合约名称
        /// </summary>
        [JsonPropertyName("arrangement_name")]
        public string ArrangementName { get; set; }

        /// <summary>
        /// 合约编号
        /// </summary>
        [JsonPropertyName("arrangement_no")]
        public string ArrangementNo { get; set; }

        /// <summary>
        /// 合约类型
        /// </summary>
        [JsonPropertyName("arrangement_type")]
        public string ArrangementType { get; set; }

        /// <summary>
        /// 合约版
        /// </summary>
        [JsonPropertyName("arrangement_version")]
        public string ArrangementVersion { get; set; }

        /// <summary>
        /// 签约渠道来源
        /// </summary>
        [JsonPropertyName("channel_code")]
        public string ChannelCode { get; set; }

        /// <summary>
        /// 合约失效时间
        /// </summary>
        [JsonPropertyName("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 到期时间
        /// </summary>
        [JsonPropertyName("gmt_expired")]
        public string GmtExpired { get; set; }

        /// <summary>
        /// 预计合约失效时间
        /// </summary>
        [JsonPropertyName("gmt_invalid_due")]
        public string GmtInvalidDue { get; set; }

        /// <summary>
        /// 合约签署时间
        /// </summary>
        [JsonPropertyName("gmt_sign")]
        public string GmtSign { get; set; }

        /// <summary>
        /// 预计合约生效时间
        /// </summary>
        [JsonPropertyName("gmt_vald_due")]
        public string GmtValdDue { get; set; }

        /// <summary>
        /// 合约版本时间
        /// </summary>
        [JsonPropertyName("gmt_vrsn")]
        public string GmtVrsn { get; set; }

        /// <summary>
        /// 参与者角色ID
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [JsonPropertyName("last_moder")]
        public string LastModer { get; set; }

        /// <summary>
        /// 外标类型
        /// </summary>
        [JsonPropertyName("mark_type")]
        public string MarkType { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 修改人类型
        /// </summary>
        [JsonPropertyName("moder_type")]
        public string ModerType { get; set; }

        /// <summary>
        /// 签约产品外标
        /// </summary>
        [JsonPropertyName("pd_mark")]
        public string PdMark { get; set; }

        /// <summary>
        /// 产品编码
        /// </summary>
        [JsonPropertyName("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [JsonPropertyName("prod_name")]
        public string ProdName { get; set; }

        /// <summary>
        /// 产品版本
        /// </summary>
        [JsonPropertyName("prod_version")]
        public string ProdVersion { get; set; }

        /// <summary>
        /// ps(产品销售)编码
        /// </summary>
        [JsonPropertyName("ps_code")]
        public string PsCode { get; set; }

        /// <summary>
        /// ps(产品销售)id
        /// </summary>
        [JsonPropertyName("ps_id")]
        public string PsId { get; set; }

        /// <summary>
        /// 产品销售名称
        /// </summary>
        [JsonPropertyName("ps_name")]
        public string PsName { get; set; }

        /// <summary>
        /// 合约状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 签约模板产品编码
        /// </summary>
        [JsonPropertyName("template_prod_code")]
        public string TemplateProdCode { get; set; }

        /// <summary>
        /// 签约模板产品版本
        /// </summary>
        [JsonPropertyName("template_prod_version")]
        public string TemplateProdVersion { get; set; }
    }
}

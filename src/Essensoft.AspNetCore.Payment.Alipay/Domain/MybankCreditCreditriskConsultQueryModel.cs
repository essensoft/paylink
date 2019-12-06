using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditCreditriskConsultQueryModel Data Structure.
    /// </summary>
    public class MybankCreditCreditriskConsultQueryModel : AlipayObject
    {
        /// <summary>
        /// 关联实体，咨询者可以添加一些关联实体比方说一个企业、一个会员账号、一个自然人等来作为咨询材料辅助咨询判断
        /// </summary>
        [JsonPropertyName("associate_entitys")]
        public List<InvolvedEntity> AssociateEntitys { get; set; }

        /// <summary>
        /// 扩展数据（map转换为json字符串）
        /// </summary>
        [JsonPropertyName("ext_par")]
        public string ExtPar { get; set; }

        /// <summary>
        /// 银行参与者id，是在网商银行创建会员后生成的id，网商银行会员的唯一标识
        /// </summary>
        [JsonPropertyName("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 银行参与者角色id，是在网商银行创建会员后生成的角色id，网商银行会员角色的唯一标识
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 外部统一编码，外部机构与网商合作的方案产品码，用于标识所属的合作业务，pd_code为空时该字段必传。
        /// </summary>
        [JsonPropertyName("out_uni_code")]
        public string OutUniCode { get; set; }

        /// <summary>
        /// 产品码，授信前准入咨询则为运营产品码，支用准入时可不用传，out_uni_code不为空时，该字段可空
        /// </summary>
        [JsonPropertyName("pd_code")]
        public string PdCode { get; set; }

        /// <summary>
        /// 场景码，表示本次查询应用于哪个场景。目前已有枚举以及对应场景：  1：授信申请前准入判断，2：支用申请准入，3：产品层可贷额度查询，4：预付方案查询，5：授信可贷额度咨询，6.营销额度咨询
        /// </summary>
        [JsonPropertyName("scen")]
        public string Scen { get; set; }

        /// <summary>
        /// 站点类型。枚举ALIPAY,TAOBAO,B2B_CN,B2B_EN,HAVANA,ALICLOUD_CN,DINGDING,ZM,MYBANK,IPAY等
        /// </summary>
        [JsonPropertyName("site")]
        public string Site { get; set; }

        /// <summary>
        /// 站点登录账号
        /// </summary>
        [JsonPropertyName("site_login_id")]
        public string SiteLoginId { get; set; }

        /// <summary>
        /// 站点ID。咨询的客户在对应站点拥有的角色的ID。比方说站点是ALIPAY的话站点ID就是ALIPAY的ID。
        /// </summary>
        [JsonPropertyName("site_user_id")]
        public string SiteUserId { get; set; }
    }
}

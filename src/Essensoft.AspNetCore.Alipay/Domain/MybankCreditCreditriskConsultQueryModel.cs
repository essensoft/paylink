using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// MybankCreditCreditriskConsultQueryModel Data Structure.
    /// </summary>
    public class MybankCreditCreditriskConsultQueryModel : AlipayObject
    {
        /// <summary>
        /// 关联实体，咨询者可以添加一些关联实体比方说一个企业、一个会员账号、一个自然人等来作为咨询材料辅助咨询判断
        /// </summary>
        [JsonProperty("associate_entitys")]
        public List<InvolvedEntity> AssociateEntitys { get; set; }

        /// <summary>
        /// 扩展数据（map转换为json字符串）
        /// </summary>
        [JsonProperty("ext_par")]
        public string ExtPar { get; set; }

        /// <summary>
        /// 银行参与者id，是在网商银行创建会员后生成的id，网商银行会员的唯一标识
        /// </summary>
        [JsonProperty("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 银行参与者角色id，是在网商银行创建会员后生成的角色id，网商银行会员角色的唯一标识
        /// </summary>
        [JsonProperty("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 产品码，授信前准入咨询则为运营产品码
        /// </summary>
        [JsonProperty("pd_code")]
        public string PdCode { get; set; }

        /// <summary>
        /// 场景码，表示本次查询应用于哪个场景。目前已有枚举以及对应场景：  1：授信申请前准入判断
        /// </summary>
        [JsonProperty("scen")]
        public string Scen { get; set; }

        /// <summary>
        /// 站点类型。枚举ALIPAY,TAOBAO,ICBU等
        /// </summary>
        [JsonProperty("site")]
        public string Site { get; set; }

        /// <summary>
        /// 站点ID。咨询的客户在对应站点拥有的角色的ID。比方说站点是ALIPAY的话站点ID就是ALIPAY的ID。
        /// </summary>
        [JsonProperty("site_user_id")]
        public string SiteUserId { get; set; }
    }
}

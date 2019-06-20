using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditLoanapplyPromotionDynamicurlGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoanapplyPromotionDynamicurlGetModel : AlipayObject
    {
        /// <summary>
        /// 机构合约编号，商户接入企业信贷业务时自动分配，获取地址：https://partner.mybank.cn/cooperation/myCooperation.htm，路径：我的合作-查看详情-开发接口调用-接口合约编号；
        /// </summary>
        [JsonProperty("arrangement_no")]
        public string ArrangementNo { get; set; }

        /// <summary>
        /// 部门编码，是网商机构门户内维护的组织结构中部门的唯一编号，由网商机构门户生成后提供给合作机构，参数staff_type为01或03时，此参数必填
        /// </summary>
        [JsonProperty("dept_code")]
        public string DeptCode { get; set; }

        /// <summary>
        /// 渠道编码，是网商机构门户内维护的推广渠道的唯一编号，由网商机构门户生成后提供给合作机构，参数staff_type为01或03时，此参数必填
        /// </summary>
        [JsonProperty("op_ch_code")]
        public string OpChCode { get; set; }

        /// <summary>
        /// 被推荐人的证件名字，当staff_type为03时需要填写，passiver_cert_no + passiver_cert_name或者passiver_id不能同时为空。作用：校验机构提供的用户和支付宝当前登录的用户为同一用户，即用户同人校验
        /// </summary>
        [JsonProperty("passiver_cert_name")]
        public string PassiverCertName { get; set; }

        /// <summary>
        /// 被推荐人的证件号，当staff_type为03时需要填写，passiver_cert_no + passiver_cert_name或者passiver_id不能同时为空。作用：校验机构提供的用户和支付宝当前登录的用户为同一用户，即用户同人校验
        /// </summary>
        [JsonProperty("passiver_cert_no")]
        public string PassiverCertNo { get; set; }

        /// <summary>
        /// 被推荐人的支付宝ID，当staff_type为03时需要填写，passiver_cert_no + passiver_cert_name或者passiver_id不能同时为空。作用：校验机构提供的用户和支付宝当前登录的用户为同一用户，即用户同人校验
        /// </summary>
        [JsonProperty("passiver_id")]
        public string PassiverId { get; set; }

        /// <summary>
        /// 合作推广机构的银行参与者id，是在网商银行创建会员后生成的id，网商银行会员的唯一标识，参数staff_type为01或03时，此参数必填
        /// </summary>
        [JsonProperty("recmd_inst_ip_id")]
        public string RecmdInstIpId { get; set; }

        /// <summary>
        /// 合作推广机构的银行参与者角色id，是在网商银行创建会员后生成的角色id，网商银行会员角色的唯一标识，参数staff_type为01或03时，此参数必填
        /// </summary>
        [JsonProperty("recmd_inst_ip_role_id")]
        public string RecmdInstIpRoleId { get; set; }

        /// <summary>
        /// 请求的实体ID，跟staff_type对应，若staff_type是01则为支付宝账号；若staff_type是02则为生活号在支付宝开放平台对应的app_id；若staff_type是03则为机构在支付宝开放平台对应的app_id
        /// </summary>
        [JsonProperty("staff_id")]
        public string StaffId { get; set; }

        /// <summary>
        /// 请求的主体类型，01表示普通用户类型，02表示生活号类型，03表示机构类型
        /// </summary>
        [JsonProperty("staff_type")]
        public string StaffType { get; set; }
    }
}

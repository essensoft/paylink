using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditLoanapplyApplyCreateModel Data Structure.
    /// </summary>
    public class MybankCreditLoanapplyApplyCreateModel : AlipayObject
    {
        /// <summary>
        /// 客户的支付宝ID，注意：如果site为ALIPAY，此参数login_id和参数alipay_id至少有一个不能为空。
        /// </summary>
        [JsonPropertyName("alipay_id")]
        public string AlipayId { get; set; }

        /// <summary>
        /// 申请金额，默认以元为单位，支持精确到小数点后2位，为了便于传输，调用方需要把double类型的金额转换为string类型
        /// </summary>
        [JsonPropertyName("apply_lmt")]
        public string ApplyLmt { get; set; }

        /// <summary>
        /// 关联实体，申贷主体可以关联一些其他实体比方说一个企业，一个会员账号用来作为申贷材料辅助申贷
        /// </summary>
        [JsonPropertyName("associate_entitys")]
        public List<InvolvedEntity> AssociateEntitys { get; set; }

        /// <summary>
        /// 业务编号，比如当使用一笔订单创建授信申请时，业务编号就是订单号
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 授信申请的场景码，1表示普通客户申请，2表示订单申请，可扩展场景
        /// </summary>
        [JsonPropertyName("biz_scene_no")]
        public string BizSceneNo { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonPropertyName("biz_tag")]
        public string BizTag { get; set; }

        /// <summary>
        /// 客户的身份证号码，如果参数biz_scene_no为1，则为必填
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，01:身份证，如果参数biz_scene_no为1，则为必填
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 联系邮箱
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

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
        /// 会员的登录账号，比如支付宝登录账号，一般为手机号或邮箱，注意：如果site为ALIPAY，此参数login_id和参数alipay_id至少有一个不能为空。
        /// </summary>
        [JsonPropertyName("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 联系手机号
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 客户姓名，如果参数biz_scene_no为1，则为必填
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 运营产品码，平台大数贷机构无须填写
        /// </summary>
        [JsonPropertyName("op_pd_code")]
        public string OpPdCode { get; set; }

        /// <summary>
        /// 外部机构定义的客户编号
        /// </summary>
        [JsonPropertyName("out_mem_id")]
        public string OutMemId { get; set; }

        /// <summary>
        /// 外部统一编码，外部机构与网商合作的方案产品标识，用于标识所属的合作业务，op_pd_code为空时该字段必传。
        /// </summary>
        [JsonPropertyName("out_uni_code")]
        public string OutUniCode { get; set; }

        /// <summary>
        /// 外部流水号,唯一标识客户的一笔贷款申请。格式：日期(8位)+序列号(8位）,序列号是数字，如00000001（必须是16位且符合该格式）。
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// ALIPAY:支付宝  MYBANK:网商银行  TMALL：天猫  TAOBAO：淘宝
        /// </summary>
        [JsonPropertyName("site")]
        public string Site { get; set; }

        /// <summary>
        /// 外部站点用户ID，跟SITE对应，若SITE是ALIPAY则为支付宝ID，若SITE是ICBU则为ICBU 用户ID
        /// </summary>
        [JsonPropertyName("site_user_id")]
        public string SiteUserId { get; set; }
    }
}

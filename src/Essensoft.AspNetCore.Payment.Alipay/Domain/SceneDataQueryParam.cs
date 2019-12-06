using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SceneDataQueryParam Data Structure.
    /// </summary>
    public class SceneDataQueryParam : AlipayObject
    {
        /// <summary>
        /// 网商银行的申请单号，通过alipay.credit.autofinance.loan.apply 接口返回的applyno获取
        /// </summary>
        [JsonPropertyName("app_seqno")]
        public string AppSeqno { get; set; }

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
        /// 外部站点，比如：ALIPAY：支付宝站点，MYBANK：银行会员，B2B_CN：B2B中文站，B2B_EN：B2B国际站，TAOBAO：淘宝
        /// </summary>
        [JsonPropertyName("site")]
        public string Site { get; set; }

        /// <summary>
        /// 外部站点的userid，比如支付宝userid
        /// </summary>
        [JsonPropertyName("site_user_id")]
        public string SiteUserId { get; set; }
    }
}

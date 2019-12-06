using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SceneProdDataQueryParam Data Structure.
    /// </summary>
    public class SceneProdDataQueryParam : AlipayObject
    {
        /// <summary>
        /// 网商银行的申请单号，通过mybank.credit.sceneprod.loan.apply接口返回的applyno获取
        /// </summary>
        [JsonPropertyName("app_seqno")]
        public string AppSeqno { get; set; }

        /// <summary>
        /// 网商银行参与者会员ID
        /// </summary>
        [JsonPropertyName("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 网商银行参与者会员角色ID
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

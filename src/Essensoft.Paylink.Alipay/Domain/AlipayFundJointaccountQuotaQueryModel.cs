using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayFundJointaccountQuotaQueryModel Data Structure.
    /// </summary>
    public class AlipayFundJointaccountQuotaQueryModel : AlipayObject
    {
        /// <summary>
        /// 账户ID
        /// </summary>
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权协议号
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 员工ID
        /// </summary>
        [JsonPropertyName("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 角色：创建方(CREATOR)、参与方(PARTICIPANT)
        /// </summary>
        [JsonPropertyName("operate_role")]
        public string OperateRole { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }
    }
}

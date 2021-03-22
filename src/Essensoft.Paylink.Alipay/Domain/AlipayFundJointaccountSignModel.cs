using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayFundJointaccountSignModel Data Structure.
    /// </summary>
    public class AlipayFundJointaccountSignModel : AlipayObject
    {
        /// <summary>
        /// 账本名称，传空采用默认规则命名，使用公司名称
        /// </summary>
        [JsonPropertyName("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 账户初始额度 未设置额度的账本无法进行支付
        /// </summary>
        [JsonPropertyName("account_quota")]
        public List<JointAccountQuotaDTO> AccountQuota { get; set; }

        /// <summary>
        /// 授权商户列表
        /// </summary>
        [JsonPropertyName("authorized_detail_list")]
        public List<AuthorizeDetailDTO> AuthorizedDetailList { get; set; }

        /// <summary>
        /// 交易授权信息 指定收单商户
        /// </summary>
        [JsonPropertyName("authorized_rule")]
        public AuthorizedRuleDTO AuthorizedRule { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 开户账号： identity_type是ALIPAY_USER_ID填支付宝会员ID（2088开头）； 是ALIPAY_LOGON_ID 填支付宝登录号
        /// </summary>
        [JsonPropertyName("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 账号类型，目前支持如下类型： 1、ALIPAY_USER_ID 支付宝的会员ID 2、ALIPAY_LOGON_ID：支付宝登录号，支持邮箱和手机号格式
        /// </summary>
        [JsonPropertyName("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }
    }
}

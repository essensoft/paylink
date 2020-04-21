using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Participant Data Structure.
    /// </summary>
    public class Participant : AlipayObject
    {
        /// <summary>
        /// 如果identity_type为BANKCARD_NO需传递该参数，涉及属性如下：  inst_name 银行卡卡开户银行  inst_province 银行所在省份  inst_city 银行所在市  inst_branch_name 收款银行所属支行  bank_code 银行卡支行联行号  account_type 银行卡账户类型 1:对公 2：对私
        /// </summary>
        [JsonPropertyName("bankcard_ext_info")]
        public BankcardExtInfo BankcardExtInfo { get; set; }

        /// <summary>
        /// 描述参与方信息的扩展属性，使用前请与支付宝工程师确认
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 参与方的唯一标识
        /// </summary>
        [JsonPropertyName("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 参与方的标识类型，目前支持如下类型：  1、ALIPAY_USER_ID 支付宝的会员ID  2、ALIPAY_LOGON_ID：支付宝登录号，支持邮箱和手机号格式
        /// </summary>
        [JsonPropertyName("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 商户端的用户信息描述，目前可指定如下属性：  merchant_user_id：商户端的用户唯一ID  merchant_user_name：商户端的用户名  merchant_user_nickname：商户端的用户昵称  merchant_user_mobile：商户端的手机号
        /// </summary>
        [JsonPropertyName("merchant_user_info")]
        public string MerchantUserInfo { get; set; }

        /// <summary>
        /// 参与方真实姓名，如果非空，将校验收款支付宝账号姓名一致性。当identity_type=ALIPAY_LOGON_ID时，本字段必填。
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}

using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAgreementBatchQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAgreementBatchQueryModel : AlipayObject
    {
        /// <summary>
        /// 用户的支付宝登录账号，支持邮箱或手机号码格式。本参数与alipay_user_id 不可同时为空，若都填写，则以alipay_user_id 为准。
        /// </summary>
        [JsonProperty("alipay_logon_id")]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// 用户的支付宝账号对应 的支付宝唯一用户号，以 2088 开头的 16 位纯数字 组成;  本参数与 alipay_logon_id 不 可同时为空，若都填写，则 以本参数为准，优先级高于 alipay_logon_id。
        /// </summary>
        [JsonProperty("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 协议产品码，商户和支付宝签约时确定，商户可咨询技术支持。
        /// </summary>
        [JsonProperty("personal_product_code")]
        public string PersonalProductCode { get; set; }

        /// <summary>
        /// 销售产品码，商户签约的支付宝合同所对应的产品码。
        /// </summary>
        [JsonProperty("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 签约协议场景，商户和支付宝签约时确定，商户可咨询技术支持。  该值需要与系统/页面签约接口调用时传入的值保持一致。不传默认查询所有场景
        /// </summary>
        [JsonProperty("sign_scene")]
        public string SignScene { get; set; }

        /// <summary>
        /// 签约第三方主体类型。对于三方协议，表示当前用户和哪一类的第三方主体进行签约。  取值范围:  取值范围：  1. PARTNER（平台商户）;  2. MERCHANT（集团商户），集团下子商户可共享用户签约内容;  默认为PARTNER。
        /// </summary>
        [JsonProperty("third_party_type")]
        public string ThirdPartyType { get; set; }
    }
}

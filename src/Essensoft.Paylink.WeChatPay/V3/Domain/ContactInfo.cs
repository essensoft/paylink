using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 超级管理员信息
    /// </summary>
    public class ContactInfo : WeChatPayObject
    {
        /// <summary>
        /// 超级管理员姓名
        /// </summary>
        /// <remarks>
        /// 1、该字段需进行加密处理，加密方法详见<a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/wechatpay/wechatpay4_3.shtml">《敏感信息加密说明》</a>。(提醒：必须在HTTP头中上送Wechatpay-Serial)
        /// <para>示例值：pVd1HJ6zyvPedzGaV+X3qtmrq9bb9tPttdY+aQ6zBlw0xnOiNW6Hzy7UtC+xriuhZ9evAM+Jv1z0NVa8MRtelw/wDa4SzfeespQO/0kjiwfqdfg==</para>
        /// </remarks>
        [WeChatPayPrivacyProperty]
        [JsonPropertyName("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 超级管理员身份证件号码
        /// </summary>
        /// <remarks>
        /// 1、“超级管理员身份证号码”与“超级管理员微信openid”，二选一必填。
        /// 2、超级管理员签约时，校验微信号绑定的银行卡实名信息，是否与该证件号码一致。
        /// 3、可传身份证、来往内地通行证、来往大陆通行证、护照等证件号码。
        /// 4、该字段需进行加密处理，加密方法详见<a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/wechatpay/wechatpay4_3.shtml">《敏感信息加密说明》</a>。(提醒：必须在HTTP头中上送Wechatpay-Serial)
        /// <para>示例值：pVd1HJ6zyvPedzGaV+X3qtWKIjOv/69bDnuC4EL5Kz4jBHLiCyOb+tI0m2qhZ9evAM+Jv1z0NVa8MRtelw/wDa4SzfeespQO/0kjiwfqdfg==</para>
        /// </remarks>
        [WeChatPayPrivacyProperty]
        [JsonPropertyName("contact_id_number")]
        public string ContactIdNumber { get; set; }

        /// <summary>
        /// 超级管理员微信openid
        /// </summary>
        /// <remarks>
        /// 1、“超级管理员身份证件号码”与“超级管理员微信openid”，二选一必填。
        /// 2、超级管理员签约时，校验微信号是否与该微信openid一致。
        /// <para>示例值：pVd1HJ6zyvPedzGaV+X/2C+xriudjD5APomty7/mYNxLMpRSvWKIjOv/69bD2qhZ9evAM+Jv1z0NVa8MRtelw/wDa4SzfeespQO/0kjiwfqdfg==</para>
        /// </remarks>
        [WeChatPayPrivacyProperty]
        [JsonPropertyName("openid")]
        public string OpenId { get; set; }

        /// <summary>
        /// 联系手机
        /// </summary>
        /// <remarks>
        /// 1、11位数字。
        /// 2、用于接收微信支付的重要管理信息及日常操作验证码。
        /// 3、该字段需进行加密处理，加密方法详见<a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/wechatpay/wechatpay4_3.shtml">《敏感信息加密说明》</a>。(提醒：必须在HTTP头中上送Wechatpay-Serial)
        /// <para>示例值：pVd1HJ6zyvPedzGaV+Xv/69bDnuC4EL5Kz4jBHLiCyOb+tI0m2qhZ9evAM+Jv1z0NVa8MRtelw/wDa4SzfeespQO/0kjiwfqdfg==</para>
        /// </remarks>
        [WeChatPayPrivacyProperty]
        [JsonPropertyName("mobile_phone")]
        public string MobilePhone { get; set; }

        /// <summary>
        /// 联系邮箱
        /// </summary>
        /// <remarks>
        /// 1、用于接收微信支付的开户邮件及日常业务通知。
        /// 2、需要带@，遵循邮箱格式校验，该字段需进行加密处理，加密方法详见<a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/wechatpay/wechatpay4_3.shtml">《敏感信息加密说明》</a>。(提醒：必须在HTTP头中上送Wechatpay-Serial)
        /// <para>示例值：pVd1HJ6zyvPedzGaV+P/2qIdGdONoDzZelrxCl/NWWKIjOv/69bDnuC4EL5Kz4jBHLiCyOa8MRtelw/wDa4SzfeespQO/0kjiwfqdfg==</para>
        /// </remarks>
        [WeChatPayPrivacyProperty]
        [JsonPropertyName("contact_email")]
        public string ContactEmail { get; set; }
    }
}

using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 其他类型证件信息
    /// </summary>
    public class IdDocInfo : WeChatPayObject
    {
        /// <summary>
        /// 证件正面照片
        /// </summary>
        /// <remarks>
        /// 1、证件类型不为“身份证”"时，上传证件正面照片。
        /// 2、可上传1张图片，请填写通过图片上传API接口预先上传图片生成好的MediaID。
        /// 3、请上传彩色照片or彩色扫描件or复印件（需加盖公章鲜章），可添加“微信支付”相关水印（如微信支付认证）。
        /// <para>示例值：jTpGmxUX3FBWVQ5NJTZvlKX_gdU4cRz7z5NxpnFuAxhBTEO_PvWkfSCJ3zVIn001D8daLC-ehEuo0BJqRTvDujqhThn4ReFxikqJ5YW6zFQ</para>
        /// </remarks>
        [JsonPropertyName("id_doc_copy")]
        public string IdDocCopy { get; set; }

        /// <summary>
        /// 证件反面照片
        /// </summary>
        /// <remarks>
        /// 1、若证件类型为往来通行证、外国人居留证、港澳居住证、台湾居住证时，上传证件反面照片。
        /// 2、若证件类型为护照，无需上传反面照片
        /// 3、可上传1张图片，请填写通过图片上传API接口预先上传图片生成好的MediaID。
        /// 4、请上传彩色照片or彩色扫描件or复印件（需加盖公章鲜章），可添加“微信支付”相关水印（如微信支付认证）。
        /// <para>示例值：jTpGmxUX3FBWVQ5NJTZvlKX_gdU4cRz7z5NxpnFuAxhBTEO_PvWkfSCJ3zVIn001D8daLC-ehEuo0BJqRTvDujqhThn4ReFxikqJ5YW6zFQ</para>
        /// </remarks>
        [JsonPropertyName("id_doc_copy_back")]
        public string IdDocCopyBack { get; set; }

        /// <summary>
        /// 证件姓名
        /// </summary>
        /// <remarks>
        /// 1、请填写经营者/法定代表人的证件姓名，2~30个中文字符、英文字符、符号
        /// 2、该字段需进行加密处理，加密方法详见<a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/wechatpay/wechatpay4_3.shtml">敏感信息加密说明</a>。(提醒：必须在HTTP头中上送Wechatpay-Serial)
        /// <para>示例值：pVd1HJ6NxLMpRSvWKIjOv/69bDnuC4EL5Kz4jBHLiCyOb+tI0m2qhZ9evAM+Jv1z0NVa8MRtelw/wDa4SzfeespQO/0kjiwfqdfg==</para>
        /// </remarks>
        [WeChatPayPrivacyProperty]
        [JsonPropertyName("id_doc_name")]
        public string IdDocName { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        /// <remarks>
        /// 1、请填写经营者/法定代表人的证件号码
        /// 2、8-30位数字|字母|连字符，该字段需进行加密处理，加密方法详见<a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/wechatpay/wechatpay4_3.shtml">敏感信息加密说明</a>。(提醒：必须在HTTP头中上送Wechatpay-Serial)
        /// <para>示例值：AOZdYGISxo4V4oASq6ZFonjTtgjjgKsadIKHXtb3JZKGZjduGdtkRJJp0/0eow96uY1Pk7Rq79Jtt7+I8juwEc4P4TG5xzchG/5IL9DBd+Z0zZXkw==</para>
        /// </remarks>
        [WeChatPayPrivacyProperty]
        [JsonPropertyName("id_doc_number")]
        public string IdDocNumber { get; set; }

        /// <summary>
        /// 证件居住地址
        /// </summary>
        /// <remarks>
        /// 1、主体类型为企业时，需要填写。其他主体类型，无需上传。
        /// 2、请按照证件上住址填写，若证件上无住址则按照实际住址填写，如广东省深圳市南山区xx路xx号xx室。
        /// 3、该字段需进行加密处理，加密方法详见<a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/wechatpay/wechatpay4_3.shtml">敏感信息加密说明</a>。(提醒：必须在HTTP头中上送Wechatpay-Serial)
        /// <para>示例值：pVd1HJ6zyvPedzGaV+X3qtmrq9bb9tPROvwia4ibL+F6mfjbzQIzfb3HHLEjZ4YiR/cJiCrZxnAqi+pjeKIEdkwzXRAI7FUhrf2qhZ9evAM+Jv1z0NVa8MRtelw/wDa4SzfeespQO/0kjiwfqdfg==</para>
        /// </remarks>
        [WeChatPayPrivacyProperty]
        [JsonPropertyName("id_doc_address")]
        public string IdDocAddress { get; set; }

        /// <summary>
        /// 证件有效期开始时间
        /// </summary>
        /// <remarks>
        /// 1、选填，请按照示例值填写。
        /// 2、结束时间大于开始时间。
        /// <para>示例值：2019-06-06</para>
        /// </remarks>
        [JsonPropertyName("doc_period_begin")]
        public string DocPeriodBegin { get; set; }

        /// <summary>
        /// 证件有效期结束时间
        /// </summary>
        /// <remarks>
        /// 1、必填，请按照示例值填写。
        /// 2、若证件有效期为长期，请填写：长期。
        /// 3、结束时间大于开始时间。
        /// 4、证件有效期需大于60天。
        /// <para>示例值：2026-06-06</para>
        /// </remarks>
        [JsonPropertyName("doc_period_end")]
        public string DocPeriodEnd { get; set; }
    }
}

using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 身份证信息
    /// </summary>
    public class IdCardInfo : WeChatPayObject
    {
        /// <summary>
        /// 身份证人像面照片
        /// </summary>
        /// <remarks>
        /// 1、请上传个体户经营者/法人的身份证人像面照片
        /// 2、可上传1张图片，请填写通过图片上传API接口预先上传图片生成好的MediaID
        /// 3、请上传彩色照片or彩色扫描件or复印件（需加盖公章鲜章），可添加“微信支付”相关水印（如微信支付认证）。
        /// <para>示例值：jTpGmxUX3FBWVQ5NJTZvlKX_gdU4cRz7z5NxpnFuAxhBTEO_PvWkfSCJ3zVIn001D8daLC-ehEuo0BJqRTvDujqhThn4ReFxikqJ5YW6zFQ</para>
        /// </remarks>
        [JsonPropertyName("id_card_copy")]
        public string IdCardCopy { get; set; }

        /// <summary>
        /// 身份证国徽面照片
        /// </summary>
        /// <remarks>
        /// 1、请上传个体户经营者/法定代表人的身份证国徽面照片
        /// 2、可上传1张图片，请填写通过图片上传API接口预先上传图片生成好的MediaID
        /// 3、请上传彩色照片or彩色扫描件or复印件（需加盖公章鲜章），可添加“微信支付”相关水印（如微信支付认证）。
        /// <para>示例值：47ZC6GC-vnrbEny__Ie_An5-tCpqxucuxi-vByf3Gjm7KE53JXvGy9tqZm2XAUf-4KGprrKhpVBDIUv0OF4wFNIO4kqg05InE4d2I6_H7I4</para>
        /// </remarks>
        [JsonPropertyName("id_card_national")]
        public string IdCardNational { get; set; }

        /// <summary>
        /// 身份证姓名
        /// </summary>
        /// <remarks>
        /// 1、请填写个体户经营者/法定代表人对应身份证的姓名，2~30个中文字符、英文字符、符号。
        /// 2、该字段需进行加密处理，加密方法详见<a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/wechatpay/wechatpay4_3.shtml">敏感信息加密说明</a>。(提醒：必须在HTTP头中上送Wechatpay-Serial)
        /// <para>示例值：pVd1HJ6zyvPedzGaV+X3qtmrq9bb9tPRDm2qhZ9evAM+Jv1z0NVa8MRtelw/wDa4SzfeespQO/0kjiwfqdfg==</para>
        /// </remarks>
        [WeChatPayPrivacyProperty]
        [JsonPropertyName("id_card_name")]
        public string IdCardName { get; set; }

        /// <summary>
        /// 身份证号码
        /// </summary>
        /// <remarks>
        /// 1、请填写个体户经营者/法定代表人对应身份证的号码。
        /// 2、15位数字或17位数字+1位数字|X，该字段需进行加密处理，加密方法详见<a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/wechatpay/wechatpay4_3.shtml">敏感信息加密说明</a>。(提醒：必须在HTTP头中上送Wechatpay-Serial)
        /// <para>示例值：AOZdYGISxo4y44/UgZ69bdagEcGe+vLYiKrzcrodtkRJJp0/0eow96uY1Pk7Rq79Jtt7+I8juwEc4P4TG5xzchG/5IL9DBd+Z0zZXkw==</para>
        /// </remarks>
        [WeChatPayPrivacyProperty]
        [JsonPropertyName("id_card_number")]
        public string IdCardNumber { get; set; }

        /// <summary>
        /// 身份证居住地址
        /// </summary>
        /// <remarks>
        /// 1、主体类型为企业时，需要填写。其他主体类型，无需上传。
        /// 2、请按照身份证住址填写，如广东省深圳市南山区xx路xx号xx室
        /// 3、该字段需进行加密处理，加密方法详见<a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/wechatpay/wechatpay4_3.shtml">敏感信息加密说明</a>。(提醒：必须在HTTP头中上送Wechatpay-Serial)
        /// <para>示例值：pVd1HJ6zyvPedzGaV+X3qtmrq9bb9tPROvwia4ibL+F6mfjbzQIzfb3HHLEjZ4YiR/cJiCrZxnAqiEL5Kz4jBHLiCyOb+tI0m2qhZ9evAM+Jv1z0NVa8MRtelw/wDa4SzfeespQO/0kjiwfqdfg==</para>
        /// </remarks>
        [WeChatPayPrivacyProperty]
        [JsonPropertyName("id_card_address")]
        public string IdCardAddress { get; set; }

        /// <summary>
        /// 身份证有效期开始时间
        /// </summary>
        /// <remarks>
        /// 1、必填，请按照示例值填写。
        /// 2、结束时间大于开始时间。
        /// <para>示例值：2026-06-06</para>
        /// </remarks>
        [JsonPropertyName("card_period_begin")]
        public string CardPeriodBegin { get; set; }

        /// <summary>
        /// 身份证有效期结束时间
        /// </summary>
        /// <remarks>
        /// 1、必填，请按照示例值填写。
        /// 2、若证件有效期为长期，请填写：长期。
        /// 3、结束时间大于开始时间。
        /// 4、证件有效期需大于60天。
        /// <para>示例值：2026-06-06</para>
        /// </remarks>
        [JsonPropertyName("card_period_end")]
        public string CardPeriodEnd { get; set; }
    }
}

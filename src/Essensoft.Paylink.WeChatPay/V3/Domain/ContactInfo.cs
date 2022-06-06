using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 超级管理员信息
    /// </summary>
    public class ContactInfo : WeChatPayObject
    {
        /// <summary>
        /// 超级管理员类型
        /// </summary>
        /// <remarks>
        /// 1、主体为“个体工商户/企业/政府机关/事业单位/社会组织”，可选择：LEGAL：经营者/法人，SUPER：经办人 。（经办人：经商户授权办理微信支付业务的人员）。
        /// 枚举值：
        /// LEGAL：经营者/法人
        /// SUPER：经办人
        /// <para>示例值：LEGAL</para>
        /// </remarks>
        [JsonPropertyName("contact_type")]
        public string ContactType { get; set; }

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
        /// 超级管理员证件类型
        /// </summary>
        /// <remarks>
        /// 当超级管理员类型是经办人时，请上传超级管理员证件类型。
        /// IDENTIFICATION_TYPE_IDCARD：中国大陆居民-身份证
        /// IDENTIFICATION_TYPE_OVERSEA_PASSPORT：其他国家或地区居民-护照
        /// IDENTIFICATION_TYPE_HONGKONG_PASSPORT：中国香港居民-来往内地通行证
        /// IDENTIFICATION_TYPE_MACAO_PASSPORT：中国澳门居民-来往内地通行证
        /// IDENTIFICATION_TYPE_TAIWAN_PASSPORT：中国台湾居民-来往大陆通行证
        /// IDENTIFICATION_TYPE_FOREIGN_RESIDENT：外国人居留证
        /// IDENTIFICATION_TYPE_HONGKONG_MACAO_RESIDENT：港澳居民证
        /// IDENTIFICATION_TYPE_TAIWAN_RESIDENT：台湾居民证
        /// <para>示例值：IDENTIFICATION_TYPE_IDCARD</para>
        /// </remarks>
        [JsonPropertyName("contact_id_doc_type")]
        public string ContactIdDocType { get; set; }

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
        /// 超级管理员证件正面照片
        /// </summary>
        /// <remarks>
        /// 当超级管理员类型是经办人时，请上传超级管理员证件类型。
        /// 1、当超级管理员类型是经办人时，请上传超级管理员证件的正面照片。
        /// 2、若证件类型为身份证，请上传人像面照片。
        /// 3、可上传1张图片，请填写通过图片上传API预先上传图片生成好的MediaID。
        /// 4、请上传彩色照片or彩色扫描件or复印件（需加盖公章鲜章），可添加“微信支付”相关水印（如微信支付认证）。
        /// <para>示例值：jTpGmxUXqRTvDujqhThn4ReFxikqJ5YW6zFQ</para>
        /// </remarks>
        [JsonPropertyName("contact_id_doc_copy")]
        public string ContactIdDocCopy { get; set; }

        /// <summary>
        /// 超级管理员证件反面照片
        /// </summary>
        /// <remarks>
        /// 当超级管理员类型是经办人时，请上传超级管理员证件类型。
        /// 1、当超级管理员类型是经办人时，请上传超级管理员证件的反面照片。
        /// 2、若证件类型为护照，无需上传反面照片。
        /// 3、可上传1张图片，请填写通过图片上传API预先上传图片生成好的MediaID。
        /// 4、请上传彩色照片or彩色扫描件or复印件（需加盖公章鲜章），可添加“微信支付”相关水印（如微信支付认证）。
        /// <para>示例值：jTpGmxUXqRTvDujqhThn4ReFxikqJ5YW6zFQ</para>
        /// </remarks>
        [JsonPropertyName("contact_id_doc_copy_back")]
        public string ContactIdDocCopyBack { get; set; }

        /// <summary>
        /// 超级管理员证件有效期开始时间
        /// </summary>
        /// <remarks>
        /// 1、当超级管理员类型是经办人时，请上传证件有效期开始时间。
        /// 2、请按照示例值填写。
        /// 3、结束时间大于开始时间。
        /// <para>示例值：2019-06-06</para>
        /// </remarks>
        [JsonPropertyName("contact_period_begin")]
        public string ContactPeriodBegin { get; set; }

        /// <summary>
        /// 超级管理员证件有效期结束时间
        /// </summary>
        /// <remarks>
        /// 1、当超级管理员类型是经办人时，请上传证件有效期结束时间。
        /// 2、请按照示例值填写，若证件有效期为长期，请填写：长期。
        /// 3、结束时间大于开始时间。
        /// <para>示例值：2019-06-06</para>
        /// </remarks>
        [JsonPropertyName("contact_period_end")]
        public string ContactPeriodEnd { get; set; }

        /// <summary>
        /// 业务办理授权函
        /// </summary>
        /// <remarks>
        /// 1、当超级管理员类型是经办人时，请上传业务办理授权函。
        /// 2、请参照[示例图]打印业务办理授权函，全部信息需打印，不支持手写商户信息，并加盖公章。
        /// 3、可上传1张图片，请填写通过图片上传API预先上传图片生成好的MediaID。
        /// <para>示例值：47ZC6GC-vnrbEny_Ie_An5-tCpqxucuxi-vByf3Gjm7KEIUv0OF4wFNIO4kqg05InE4d2I6_H7I4</para>
        /// </remarks>
        [JsonPropertyName("business_authorization_letter")]
        public string BusinessAuthorizationLetter { get; set; }

        /// <summary>
        /// 超级管理员微信openid
        /// </summary>
        /// <remarks>
        /// 1、“超级管理员身份证件号码”与“超级管理员微信openid”，二选一必填。
        /// 2、超级管理员签约时，校验微信号是否与该微信openid一致。
        /// <para>示例值：oUpF8uMuAJO_M2pxb1Q9zNjWeS6o</para>
        /// </remarks>
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

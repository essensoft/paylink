using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 超级管理员信息
    /// </summary>
    public class EcommerceContactInfo : WeChatPayObject
    {
        /// <summary>
        /// 超级管理员类型
        /// </summary>
        /// <remarks>
        /// 1、主体为“小微/个人卖家 ”，可选择：65-经营者/法人。
        /// 2、主体为“个体工商户/企业/政府机关/事业单位/社会组织”，可选择：65-经营者/法人、66- 经办人。 （经办人：经商户授权办理微信支付业务的人员）。
        /// <para>示例值：65</para>
        /// </remarks>
        [JsonPropertyName("contact_type")]
        public string ContactType { get; set; }

        /// <summary>
        /// 超级管理员姓名
        /// </summary>
        /// <remarks>
        /// 1、若管理员类型为“法人”，则该姓名需与法人身份证姓名一致。
        /// 2、若管理员类型为“经办人”，则可填写实际负责人的姓名。
        /// 3、该字段需进行加密处理，加密方法详见敏感信息加密说明。(提醒：必须在HTTP头中上送Wechatpay-Serial)
        /// （后续该管理员需使用实名微信号完成签约）
        /// <para>示例值：pVd1HJ6zyvPedzGaV+X3IdGdbDnuC4Eelw/wDa4SzfeespQO/0kjiwfqdfg==</para>
        /// </remarks>
        [WeChatPayPrivacyProperty]
        [JsonPropertyName("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 超级管理员姓名
        /// </summary>
        /// <remarks>
        /// 当超级管理员类型是经办人时，请上传超级管理员证件类型。
        /// IDENTIFICATION_TYPE_MAINLAND_IDCARD：中国大陆居民-身份证
        /// IDENTIFICATION_TYPE_OVERSEA_PASSPORT：其他国家或地区居民-护照
        /// IDENTIFICATION_TYPE_HONGKONG：中国香港居民--来往内地通行证
        /// IDENTIFICATION_TYPE_MACAO：中国澳门居民--来往内地通行证
        /// IDENTIFICATION_TYPE_TAIWAN：中国台湾居民--来往大陆通行证
        /// IDENTIFICATION_TYPE_FOREIGN_RESIDENT：外国人居留证
        /// IDENTIFICATION_TYPE_HONGKONG_MACAO_RESIDENT：港澳居民证
        /// IDENTIFICATION_TYPE_TAIWAN_RESIDENT：台湾居民证
        /// <para>示例值：IDENTIFICATION_TYPE_MAINLAND_IDCARD</para>
        /// </remarks>
        [JsonPropertyName("contact_id_doc_type")]
        public string ContactIdDocType { get; set; }

        /// <summary>
        /// 超级管理员证件号码
        /// </summary>
        /// <remarks>
        /// 1、若超级管理员类型为法人，则该身份证号码需与法人身份证号码一致。若超级管理员类型为经办人，则可填写实际经办人的身份证号码。
        /// 2、可传身份证、来往内地通行证、来往大陆通行证、护照等证件号码。
        /// 3、超级管理员签约时，校验微信号绑定的银行卡实名信息，是否与该证件号码一致。
        /// 4、该字段需进行加密处理，加密方法详见敏感信息加密说明。(提醒：必须在HTTP头中上送Wechatpay-Serial)
        /// <para>示例值：pVd1HJ6zyvPedzGaV+X3qtmrq9bb9tPROvwia4ibL+F6mfjbzQIzfb3HHDnuC4EL5Kz4jBHLiCyOb+tI0m2qhZ9evAM+Jv1z0NVa8MRtelw/wDa4SzfeespQO/0kjiwfqdfg==</para>
        /// </remarks>
        [WeChatPayPrivacyProperty]
        [JsonPropertyName("contact_id_card_number")]
        public string ContactIdCardNumber { get; set; }

        /// <summary>
        /// 超级管理员证件正面照片
        /// </summary>
        /// <remarks>
        /// 1、当超级管理员类型是经办人时，请上传超级管理员证件的正面照片。
        /// 2、若证件类型为身份证，请上传人像面照片。
        /// 3、可上传1张图片，请填写通过图片上传API预先上传图片生成好的MediaID。
        /// 4、请上传彩色照片or彩色扫描件or复印件（需加盖公章鲜章），可添加“微信支付”相关水印（如微信支付认证）。
        /// <para>示例值：jTpGmxUX3FBWVQ5NJTZvvDujqhThn4ReFxikqJ5YW6zFQ</para>
        /// </remarks>
        [JsonPropertyName("contact_id_doc_copy")]
        public string ContactIdDocCopy { get; set; }

        /// <summary>
        /// 超级管理员证件反面照片
        /// </summary>
        /// <remarks>
        /// 1、当超级管理员类型是经办人时，请上传超级管理员证件的反面照片。
        /// 2、若证件类型为护照，无需上传反面照片。
        /// 3、可上传1张图片，请填写通过图片上传API预先上传图片生成好的MediaID。
        /// 4、请上传彩色照片or彩色扫描件or复印件（需加盖公章鲜章），可添加“微信支付”相关水印（如微信支付认证）。
        /// <para>示例值：jTpGmxUX3FBWVQ5NJTZvvDujqhThn4ReFxikqJ5YW6zFQ</para>
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
        [JsonPropertyName("contact_id_doc_period_begin")]
        public string ContactIdDocPeriodBegin { get; set; }

        /// <summary>
        /// 超级管理员证件有效期结束时间
        /// </summary>
        /// <remarks>
        /// 1、当超级管理员类型是经办人时，请上传证件有效期结束时间。
        /// 2、请按照示例值填写，若证件有效期为长期，请填写：长期。
        /// 3、结束时间大于开始时间。
        /// <para>示例值：2019-06-06</para>
        /// </remarks>
        [JsonPropertyName("contact_id_doc_period_end")]
        public string ContactIdDocPeriodEnd { get; set; }

        /// <summary>
        /// 业务办理授权函
        /// </summary>
        /// <remarks>
        /// 1、当超级管理员类型是经办人时，请上传业务办理授权函。
        /// 2、请参照示例图打印业务办理授权函，全部信息需打印，不支持手写商户信息，并加盖公章。
        /// 3、可上传1张图片，请填写通过图片上传API预先上传图片生成好的MediaID。
        /// <para>示例值：47ZC6GC-vnrbEny_Ie_An5-tCpqxucuxi-vByf3Gjm7KEIUv0OF4wFNIO4kqg05InE4d2I6_H7I4</para>
        /// </remarks>
        [JsonPropertyName("business_authorization_letter")]
        public string BusinessAuthorizationLetter { get; set; }

        /// <summary>
        /// 超级管理员手机
        /// </summary>
        /// <remarks>
        /// 1、请填写管理员的手机号，11位数字， 用于接收微信支付的重要管理信息及日常操作验证码 。
        /// 2、该字段需进行加密处理，加密方法详见敏感信息加密说明。(提醒：必须在HTTP头中上送Wechatpay-Serial)
        /// <para>示例值：pVd1HJ6zyvPedzGaV+X3qtmrq9bb9tPROvwia4ibL+F6mfjbzQIzfb3HHLEjZ4YiNWWNeespQO/0kjiwfqdfg==</para>
        /// </remarks>
        [WeChatPayPrivacyProperty]
        [JsonPropertyName("mobile_phone")]
        public string MobilePhone { get; set; }

        /// <summary>
        /// 超级管理员邮箱
        /// </summary>
        /// <remarks>
        /// 1、主体类型为“小微商户/个人卖家”可选填，其他主体需必填。
        /// 2、用于接收微信支付的开户邮件及日常业务通知。
        /// 3、需要带@，遵循邮箱格式校验 。
        /// 4、该字段需进行加密处理，加密方法详见敏感信息加密说明。(提醒：必须在HTTP头中上送Wechatpay-Serial)
        /// <para>示例值：pVd1HJ6zyvPedzGaV+X3qtmrq9bb9tPROvwia4ibL+FWWNUlw/wDa4SzfeespQO/0kjiwfqdfg==</para>
        /// </remarks>
        [WeChatPayPrivacyProperty]
        [JsonPropertyName("contact_email")]
        public string ContactEmail { get; set; }
    }
}

using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 最终受益人信息(UBO]
    /// </summary>
    public class UboInfo : WeChatPayObject
    {
        /// <summary>
        /// 证件类型
        /// </summary>
        /// <remarks>
        /// 请填写受益人的证件类型。枚举值：
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
        [JsonPropertyName("ubo_id_doc_type")]
        public string UboIdDocType { get; set; }

        /// <summary>
        /// 证件正面照片
        /// </summary>
        /// <remarks>
        /// 1、请上传受益人证件的正面照片。
        /// 2、若证件类型为身份证，请上传人像面照片。
        /// 3、可上传1张图片，请填写通过图片上传API预先上传图片生成好的MediaID。
        /// 4、请上传彩色照片or彩色扫描件or复印件（需加盖公章鲜章），可添加“微信支付”相关水印（如微信支付认证）。
        /// <para>示例值：jTpGmxUX3FBWeFxikqJ5YW6zFQ</para>
        /// </remarks>
        [JsonPropertyName("ubo_id_doc_copy")]
        public string UboIdDocCopy { get; set; }

        /// <summary>
        /// 证件反面照片
        /// </summary>
        /// <remarks>
        /// 1、请上传受益人证件的反面照片。
        /// 2、若证件类型为护照，无需上传反面照片。
        /// 3、可上传1张图片，请填写通过图片上传API预先上传图片生成好的MediaID。
        /// 4、请上传彩色照片or彩色扫描件or复印件（需加盖公章鲜章），可添加“微信支付”相关水印（如微信支付认证）。
        /// <para>示例值：jTpGmxUXqRTvDujqhThn4ReFxikqJ5YW6zFQ</para>
        /// </remarks>
        [JsonPropertyName("ubo_id_doc_copy_back")]
        public string UboIdDocCopyBack { get; set; }

        /// <summary>
        /// 证件姓名
        /// </summary>
        /// <remarks>
        /// 该字段需进行加密处理，加密方法详见<a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/wechatpay/wechatpay4_3.shtml">敏感信息加密说明</a>。(提醒：必须在HTTP头中上送Wechatpay-Serial)
        /// <para>示例值：AOZdYGISxo4y44/Ug4P4TG5xzchG/5IL9DBd+Z0zZXkw==</para>
        /// </remarks>
        [WeChatPayPrivacyProperty]
        [JsonPropertyName("ubo_id_doc_name")]
        public string UboIdDocName { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        /// <remarks>
        /// 该字段需进行加密处理，加密方法详见<a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/wechatpay/wechatpay4_3.shtml">敏感信息加密说明</a>。(提醒：必须在HTTP头中上送Wechatpay-Serial)
        /// <para>示例值：AOZdYGISxo4y44/Ug4P4TG5xzchG/5IL9DBd+Z0zZXkw==</para>
        /// </remarks>
        [WeChatPayPrivacyProperty]
        [JsonPropertyName("ubo_id_doc_number")]
        public string UboIdDocNumber { get; set; }

        /// <summary>
        /// 证件居住地址
        /// </summary>
        /// <remarks>
        /// 1、请按照证件上住址填写，若证件上无住址则按照实际住址填写，如广东省深圳市南山区xx路xx号xx室。
        /// 2、该字段需进行加密处理，加密方法详见<a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/wechatpay/wechatpay4_3.shtml">敏感信息加密说明</a>。(提醒：必须在HTTP头中上送Wechatpay-Serial)
        /// <para>示例值：AOZdYGISxo4y44/Ug4P4TG5xzchG/5IL9DBd+Z0zZXkw==</para>
        /// </remarks>
        [WeChatPayPrivacyProperty]
        [JsonPropertyName("ubo_id_doc_address")]
        public string UboIdDocAddress { get; set; }

        /// <summary>
        /// 证件有效期开始时间
        /// </summary>
        /// <remarks>
        /// 1、请按照示例值填写。
        /// 2、结束时间大于开始时间。
        /// <para>示例值：2019-06-06</para>
        /// </remarks>
        [JsonPropertyName("ubo_period_begin")]
        public string UboPeriodBegin { get; set; }

        /// <summary>
        /// 证件有效期结束时间
        /// </summary>
        /// <remarks>
        /// 1、请按照示例值填写，若证件有效期为长期，请填写：长期。
        /// 2、结束时间大于开始时间。
        /// <para>示例值：2026-06-06</para>
        /// </remarks>
        [JsonPropertyName("ubo_period_end")]
        public string UboPeriodEnd { get; set; }
    }
}

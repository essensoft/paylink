using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 经营者/法人身份证件
    /// </summary>
    public class IdentityInfo : WeChatPayObject
    {
        /// <summary>
        /// 证件持有人类型
        /// </summary>
        /// <remarks>
        /// 1. 主体类型为政府机关、事业单位时选传：
        /// （1）若上传的是法人证件，则不需要上传该字段
        /// （2）若因特殊情况，无法提供法人证件时，可上传经办人。 （经办人：经商户授权办理微信支付业务的人员，授权范围包括但不限于签约，入驻过程需完成账户验证）。
        /// 2. 主体类型为企业、个体户、社会组织时，默认为经营者/法人，不需要上传该字段。
        /// LEGAL：法人
        /// SUPER：经办人
        /// </remarks>
        [JsonPropertyName("id_holder_type")]
        public string IdHolderType { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        /// <remarks>
        /// 1、当证件持有人类型为法人时，填写。其他情况，无需上传。
        /// 2、个体户/企业/事业单位/社会组织：可选择任一证件类型，政府机关仅支持中国大陆居民-身份证类型。
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
        [JsonPropertyName("id_doc_type")]
        public string IdDocType { get; set; }

        /// <summary>
        /// 法定代表人说明函
        /// </summary>
        /// <remarks>
        /// 1、当证件持有人类型为经办人时，必须上传。其他情况，无需上传。
        /// 2、若因特殊情况，无法提供法定代表人证件时，请参照示例图打印法定代表人说明函，全部信息需打印，不支持手写商户信息，并加盖公章。
        /// 3、可上传1张图片，请填写通过图片上传APIAPI预先上传图片生成好的MediaID。
        /// <para>示例值：47ZC6GC-vnrbEny_Ie_An5-tCpqxucuxi-vByf3Gjm7KEIUv0OF4wFNIO4kqg05InE4d2I6_H7I4</para>
        /// </remarks>
        [JsonPropertyName("authorize_letter_copy")]
        public string AuthorizeLetterCopy { get; set; }

        /// <summary>
        /// 身份证信息
        /// </summary>
        /// <remarks>
        /// 当证件持有人类型为经营者/法人且证件类型为“身份证”时填写。
        /// </remarks>
        [JsonPropertyName("id_card_info")]
        public IdCardInfo IdCardInfo { get; set; }

        /// <summary>
        /// 其他类型证件信息
        /// </summary>
        /// <remarks>
        /// 当证件持有人类型为经营者/法人且证件类型不为“身份证”时填写。
        /// </remarks>
        [JsonPropertyName("id_doc_info")]
        public IdDocInfo IdDocInfo { get; set; }

        /// <summary>
        /// 经营者/法人是否为受益人
        /// </summary>
        /// <remarks>
        /// 主体类型为企业时，需要填写：
        /// 1、若经营者/法人是最终受益人，则填写：true。
        /// 2、若经营者/法人不是最终受益人，则填写：false。
        /// <para>示例值：true</para>
        /// </remarks>
        [JsonPropertyName("owner")]
        public bool Owner { get; set; }
    }
}

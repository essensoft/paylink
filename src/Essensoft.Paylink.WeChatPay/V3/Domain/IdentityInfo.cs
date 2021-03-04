using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 经营者/法人身份证件
    /// </summary>
    public class IdentityInfo : WeChatPayObject
    {
        /// <summary>
        /// 证件类型
        /// </summary>
        /// <remarks>
        /// 个体户/企业/党政、机关及事业单位/其他组织：可选择任一证件类型。
        /// 枚举值：
        /// IDENTIFICATION_TYPE_IDCARD：中国大陆居民-身份证
        /// IDENTIFICATION_TYPE_OVERSEA_PASSPORT：其他国家或地区居民-护照
        /// IDENTIFICATION_TYPE_HONGKONG_PASSPORT：中国香港居民-来往内地通行证
        /// IDENTIFICATION_TYPE_MACAO_PASSPORT：中国澳门居民-来往内地通行证
        /// IDENTIFICATION_TYPE_TAIWAN_PASSPORT：中国台湾居民-来往大陆通行证
        /// <para>示例值：IDENTIFICATION_TYPE_IDCARD</para>
        /// </remarks>
        [JsonPropertyName("id_doc_type")]
        public string IdDocType { get; set; }

        /// <summary>
        /// 身份证信息
        /// </summary>
        /// <remarks>
        /// 证件类型为“身份证”时填写。
        /// </remarks>
        [JsonPropertyName("id_card_info")]
        public IdCardInfo IdCardInfo { get; set; }

        /// <summary>
        /// 其他类型证件信息
        /// </summary>
        /// <remarks>
        /// 证件类型为“来往内地通行证、来往大陆通行证、护照”时填写。
        /// </remarks>
        [JsonPropertyName("id_doc_info")]
        public IdDocInfo IdDocInfo { get; set; }

        /// <summary>
        /// 经营者/法人是否为受益人
        /// </summary>
        /// <remarks>
        /// 1、若经营者/法人是最终受益人，则填写：true。
        /// 2、若经营者/法人不是最终受益人，则填写：false。
        /// <para>示例值：true</para>
        /// </remarks>
        [JsonPropertyName("owner")]
        public bool Owner { get; set; }
    }
}

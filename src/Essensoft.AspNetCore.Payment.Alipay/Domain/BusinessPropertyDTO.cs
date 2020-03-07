using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BusinessPropertyDTO Data Structure.
    /// </summary>
    public class BusinessPropertyDTO : AlipayObject
    {
        /// <summary>
        /// 业务负责人工号
        /// </summary>
        [JsonPropertyName("biz_owner_id")]
        public string BizOwnerId { get; set; }

        /// <summary>
        /// 所属业务画像id
        /// </summary>
        [JsonPropertyName("business_profile_id")]
        public string BusinessProfileId { get; set; }

        /// <summary>
        /// 业务画像标签id
        /// </summary>
        [JsonPropertyName("business_property_id")]
        public string BusinessPropertyId { get; set; }

        /// <summary>
        /// is_vip
        /// </summary>
        [JsonPropertyName("column_name")]
        public string ColumnName { get; set; }

        /// <summary>
        /// 来源字段类型
        /// </summary>
        [JsonPropertyName("column_type")]
        public string ColumnType { get; set; }

        /// <summary>
        /// 创建人工号
        /// </summary>
        [JsonPropertyName("creator_id")]
        public string CreatorId { get; set; }

        /// <summary>
        /// 数据负责人工号
        /// </summary>
        [JsonPropertyName("data_owner_id")]
        public string DataOwnerId { get; set; }

        /// <summary>
        /// 英文名称
        /// </summary>
        [JsonPropertyName("english_name")]
        public string EnglishName { get; set; }

        /// <summary>
        /// 个性化信息
        /// </summary>
        [JsonPropertyName("personality_info")]
        public List<PersonalityInfoDTO> PersonalityInfo { get; set; }

        /// <summary>
        /// 标签描述
        /// </summary>
        [JsonPropertyName("property_desc")]
        public string PropertyDesc { get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [JsonPropertyName("propery_name")]
        public string ProperyName { get; set; }

        /// <summary>
        /// 质量负责人工号
        /// </summary>
        [JsonPropertyName("quality_owner_id")]
        public string QualityOwnerId { get; set; }

        /// <summary>
        /// 标签状态
        /// </summary>
        [JsonPropertyName("stauts")]
        public string Stauts { get; set; }

        /// <summary>
        /// 来源表guid
        /// </summary>
        [JsonPropertyName("table_guid")]
        public string TableGuid { get; set; }
    }
}

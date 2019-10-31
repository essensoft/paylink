using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BusinessPropertyDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessPropertyDTO : AlipayObject
    {
        /// <summary>
        /// 业务负责人工号
        /// </summary>
        [JsonProperty("biz_owner_id")]
        public string BizOwnerId { get; set; }

        /// <summary>
        /// 所属业务画像id
        /// </summary>
        [JsonProperty("business_profile_id")]
        public string BusinessProfileId { get; set; }

        /// <summary>
        /// 业务画像标签id
        /// </summary>
        [JsonProperty("business_property_id")]
        public string BusinessPropertyId { get; set; }

        /// <summary>
        /// is_vip
        /// </summary>
        [JsonProperty("column_name")]
        public string ColumnName { get; set; }

        /// <summary>
        /// 来源字段类型
        /// </summary>
        [JsonProperty("column_type")]
        public string ColumnType { get; set; }

        /// <summary>
        /// 创建人工号
        /// </summary>
        [JsonProperty("creator_id")]
        public string CreatorId { get; set; }

        /// <summary>
        /// 数据负责人工号
        /// </summary>
        [JsonProperty("data_owner_id")]
        public string DataOwnerId { get; set; }

        /// <summary>
        /// 英文名称
        /// </summary>
        [JsonProperty("english_name")]
        public string EnglishName { get; set; }

        /// <summary>
        /// 个性化信息
        /// </summary>
        [JsonProperty("personality_info")]
        public List<PersonalityInfoDTO> PersonalityInfo { get; set; }

        /// <summary>
        /// 标签描述
        /// </summary>
        [JsonProperty("property_desc")]
        public string PropertyDesc { get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [JsonProperty("propery_name")]
        public string ProperyName { get; set; }

        /// <summary>
        /// 质量负责人工号
        /// </summary>
        [JsonProperty("quality_owner_id")]
        public string QualityOwnerId { get; set; }

        /// <summary>
        /// 标签状态
        /// </summary>
        [JsonProperty("stauts")]
        public string Stauts { get; set; }

        /// <summary>
        /// 来源表guid
        /// </summary>
        [JsonProperty("table_guid")]
        public string TableGuid { get; set; }
    }
}

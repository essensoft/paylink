using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataservicePropertyBusinesspropertyCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataservicePropertyBusinesspropertyCreateModel : AlipayObject
    {
        /// <summary>
        /// 业务负责人工号
        /// </summary>
        [JsonProperty("biz_owner_id")]
        public string BizOwnerId { get; set; }

        /// <summary>
        /// 业务画像消费类目id
        /// </summary>
        [JsonProperty("business_profile_category_id")]
        public string BusinessProfileCategoryId { get; set; }

        /// <summary>
        /// 业务画像ID
        /// </summary>
        [JsonProperty("business_profile_id")]
        public string BusinessProfileId { get; set; }

        /// <summary>
        /// 来源字段名
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
        /// 数据类型 NUMBER("数值型"), STRING("文本型"), DATE("日期型"), ENUM("枚举型"), LBS("经纬度类");
        /// </summary>
        [JsonProperty("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 当数据类型为枚举型时，要指定枚举ID
        /// </summary>
        [JsonProperty("enum_id")]
        public string EnumId { get; set; }

        /// <summary>
        /// 个性化信息，jsonarray字符串
        /// </summary>
        [JsonProperty("personality_info")]
        public List<string> PersonalityInfo { get; set; }

        /// <summary>
        /// 物理数据源类型 ODPS, HBASE, KUDU, ANTMETA, XVIEW, ANT_HBASE, EXPLOER;
        /// </summary>
        [JsonProperty("physical_type")]
        public string PhysicalType { get; set; }

        /// <summary>
        /// 主键
        /// </summary>
        [JsonProperty("primary_key")]
        public string PrimaryKey { get; set; }

        /// <summary>
        /// 统计类型 ETL("ETL统计"), MODEL("模型预测")
        /// </summary>
        [JsonProperty("proc_type")]
        public string ProcType { get; set; }

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
        /// 标签来源渠道 TABLE("数据表"), FILE("文件"), INTERFACE("接口"), OBJECT_PROPERTY("公域标签")
        /// </summary>
        [JsonProperty("source_channel")]
        public string SourceChannel { get; set; }

        /// <summary>
        /// 来源表guid
        /// </summary>
        [JsonProperty("table_guid")]
        public string TableGuid { get; set; }
    }
}

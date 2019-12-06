using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataservicePropertyBusinesspropertyModifyModel Data Structure.
    /// </summary>
    public class AlipayDataDataservicePropertyBusinesspropertyModifyModel : AlipayObject
    {
        /// <summary>
        /// 业务负责人工号
        /// </summary>
        [JsonPropertyName("biz_owner_id")]
        public string BizOwnerId { get; set; }

        /// <summary>
        /// 业务画像消费类目id
        /// </summary>
        [JsonPropertyName("business_profile_category_id")]
        public string BusinessProfileCategoryId { get; set; }

        /// <summary>
        /// 业务画像标签id
        /// </summary>
        [JsonPropertyName("business_property_id")]
        public string BusinessPropertyId { get; set; }

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
        /// 数据类型 NUMBER("数值型"), STRING("文本型"), DATE("日期型"), ENUM("枚举型"), LBS("经纬度类");
        /// </summary>
        [JsonPropertyName("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 当数据类型为枚举型时，要指定枚举ID
        /// </summary>
        [JsonPropertyName("enum_id")]
        public string EnumId { get; set; }

        /// <summary>
        /// 个性化信息，jsonarray字符串
        /// </summary>
        [JsonPropertyName("personality_info")]
        public List<string> PersonalityInfo { get; set; }

        /// <summary>
        /// 统计类型 ETL("ETL统计"), MODEL("模型预测")
        /// </summary>
        [JsonPropertyName("proc_type")]
        public string ProcType { get; set; }

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
    }
}

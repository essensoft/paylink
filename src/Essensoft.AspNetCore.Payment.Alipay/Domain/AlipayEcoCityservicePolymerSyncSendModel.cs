using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoCityservicePolymerSyncSendModel Data Structure.
    /// </summary>
    public class AlipayEcoCityservicePolymerSyncSendModel : AlipayObject
    {
        /// <summary>
        /// 描述实体变更类型，包含新增、删除、修改
        /// </summary>
        [JsonPropertyName("cud_type")]
        public string CudType { get; set; }

        /// <summary>
        /// 变更实体的详细内容，为json格式，根据entity_type的不同而具有不同的格式。
        /// </summary>
        [JsonPropertyName("entity_content")]
        public string EntityContent { get; set; }

        /// <summary>
        /// 该参数为变更实体类型，可能的变更实体包含： 城市、分类、服务、展台、角标、标签
        /// </summary>
        [JsonPropertyName("entity_type")]
        public string EntityType { get; set; }
    }
}

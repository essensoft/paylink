using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TaskTypeData Data Structure.
    /// </summary>
    public class TaskTypeData : AlipayObject
    {
        /// <summary>
        /// 商户数据回传的任务名称，供C端展示。当累计的数据类型为任务类型时，此为必传字段
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}

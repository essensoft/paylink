using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PosChooseDishGroupModel Data Structure.
    /// </summary>
    public class PosChooseDishGroupModel : AlipayObject
    {
        /// <summary>
        /// 组合菜的ID，如果套餐有组合菜，必传
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 菜品中项目组的排序号
        /// </summary>
        [JsonPropertyName("sort")]
        public long Sort { get; set; }
    }
}

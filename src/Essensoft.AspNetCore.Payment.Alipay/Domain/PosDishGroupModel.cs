using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PosDishGroupModel Data Structure.
    /// </summary>
    public class PosDishGroupModel : AlipayObject
    {
        /// <summary>
        /// 创建的用户名，请输入有效的用户ID，类型是新增时候，必填
        /// </summary>
        [JsonPropertyName("create_user")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 组合菜的详情，类型是删除时候可选，否则必填
        /// </summary>
        [JsonPropertyName("detail_list")]
        public List<PosDishGroupDetailModel> DetailList { get; set; }

        /// <summary>
        /// 组合菜的ID，除了新增时候，必传
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 组合菜的名称, 类型是删除时候可选，否则必填
        /// </summary>
        [JsonPropertyName("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 查询时候返回的详情列表
        /// </summary>
        [JsonPropertyName("query_detail_list")]
        public List<PosDishGroupDetailModel> QueryDetailList { get; set; }

        /// <summary>
        /// 门店ID，类型是删除时候可选，否则必填
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 套餐的排序号，只在查询套餐下组合菜的时候才会有这个值
        /// </summary>
        [JsonPropertyName("sort")]
        public long Sort { get; set; }

        /// <summary>
        /// 状态，类型是删除时候可选，否则必填
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 操作的类型，add新增 update更新 del删除
        /// </summary>
        [JsonPropertyName("sync_type")]
        public string SyncType { get; set; }

        /// <summary>
        /// 组合菜中最多可点份数，类型是删除时候可选，否则必填
        /// </summary>
        [JsonPropertyName("unit_count_limit")]
        public long UnitCountLimit { get; set; }

        /// <summary>
        /// 更新的用户名，请输入有效的用户ID，类型是新增时候可选，否则必填
        /// </summary>
        [JsonPropertyName("update_user")]
        public string UpdateUser { get; set; }
    }
}

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMerchantDepartmentShopModifyModel Data Structure.
    /// </summary>
    public class KoubeiMerchantDepartmentShopModifyModel : AlipayObject
    {
        /// <summary>
        /// isv回传的auth_code，通过auth_code校验当前操作人与商户的关系
        /// </summary>
        [JsonPropertyName("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 需要调整的部门id
        /// </summary>
        [JsonPropertyName("dept_id")]
        public string DeptId { get; set; }

        /// <summary>
        /// 部门类型，5为非叶子节点部门即商户创建的部门；6为叶子节点部门即门店，门店在业务上被当成是类型为6的部门
        /// </summary>
        [JsonPropertyName("dept_type")]
        public string DeptType { get; set; }

        /// <summary>
        /// 商户调整部门，门店关系时当前部门需要新增的门店列表，包括门店id和门店名称
        /// </summary>
        [JsonPropertyName("shop_list_to_add")]
        public List<SimpleShopModel> ShopListToAdd { get; set; }

        /// <summary>
        /// 商户调整部门，门店关联关系，需要解除关系的门店列表，包括门店id和门店名称
        /// </summary>
        [JsonPropertyName("shop_list_to_remove")]
        public List<SimpleShopModel> ShopListToRemove { get; set; }
    }
}

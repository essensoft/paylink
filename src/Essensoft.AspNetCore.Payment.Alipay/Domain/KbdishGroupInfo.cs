using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishGroupInfo Data Structure.
    /// </summary>
    public class KbdishGroupInfo : AlipayObject
    {
        /// <summary>
        /// 操作员
        /// </summary>
        [JsonPropertyName("create_user")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 套餐组明细
        /// </summary>
        [JsonPropertyName("detail_list")]
        public List<KbdishGroupDetailInfo> DetailList { get; set; }

        /// <summary>
        /// 组id
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 组名称
        /// </summary>
        [JsonPropertyName("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 预留字段
        /// </summary>
        [JsonPropertyName("group_rule")]
        public string GroupRule { get; set; }

        /// <summary>
        /// 版本号 就是一个数据操作的时间戳
        /// </summary>
        [JsonPropertyName("group_version")]
        public string GroupVersion { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [JsonPropertyName("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 最少可选份数，不为0，最大不能大于unit_count_limit
        /// </summary>
        [JsonPropertyName("min_count_limit")]
        public string MinCountLimit { get; set; }

        /// <summary>
        /// open 启动 stop 停用
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 份数限制
        /// </summary>
        [JsonPropertyName("unit_count_limit")]
        public string UnitCountLimit { get; set; }

        /// <summary>
        /// 修改操作小二
        /// </summary>
        [JsonPropertyName("update_user")]
        public string UpdateUser { get; set; }
    }
}

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicOdpsCrowdSyncModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicOdpsCrowdSyncModel : AlipayObject
    {
        /// <summary>
        /// 人群来源渠道
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 人群名称，不能包含特殊字符
        /// </summary>
        [JsonPropertyName("crowd_name")]
        public string CrowdName { get; set; }

        /// <summary>
        /// 即离线数据分区，多级分区时，为list格式
        /// </summary>
        [JsonPropertyName("data_partition")]
        public List<string> DataPartition { get; set; }

        /// <summary>
        /// 字段名称，账户类型非ALIPAY_USER 时必填
        /// </summary>
        [JsonPropertyName("field_name")]
        public string FieldName { get; set; }

        /// <summary>
        /// 集团人群id
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 数据odps表单名称,格式：project.tablename
        /// </summary>
        [JsonPropertyName("table_name")]
        public string TableName { get; set; }

        /// <summary>
        /// 用户类型，支付宝账户:ALIPAY_USER,淘宝账户:TAOBAO_USER
        /// </summary>
        [JsonPropertyName("user_type")]
        public string UserType { get; set; }
    }
}

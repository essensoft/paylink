using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdDatasetSyncModel Data Structure.
    /// </summary>
    public class AlipayDataDataserviceAdDatasetSyncModel : AlipayObject
    {
        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [JsonPropertyName("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 数据集外部标志，不允许重复
        /// </summary>
        [JsonPropertyName("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 数据集外部名称
        /// </summary>
        [JsonPropertyName("data_name")]
        public string DataName { get; set; }

        /// <summary>
        /// 数据源类型类型: LOCAL_MEMBER-本地生活会员数据 LOCAL_COUPON-本地生活优惠券数据 LOCAL_TRANSACTION-本地生活订单数据
        /// </summary>
        [JsonPropertyName("data_src_type")]
        public string DataSrcType { get; set; }

        /// <summary>
        /// 数据所属增量同步odps表名
        /// </summary>
        [JsonPropertyName("data_table_name")]
        public string DataTableName { get; set; }

        /// <summary>
        /// 数据类型：CONVERSION_DATA-转化数据
        /// </summary>
        [JsonPropertyName("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 商户在支付宝灯火pb侧的唯一标志
        /// </summary>
        [JsonPropertyName("principal_tag")]
        public string PrincipalTag { get; set; }

        /// <summary>
        /// 状态: ENABLE-有效; DISABLE-失效
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 用户唯一标志类型: PID-支付宝pid
        /// </summary>
        [JsonPropertyName("user_unique_type")]
        public string UserUniqueType { get; set; }
    }
}

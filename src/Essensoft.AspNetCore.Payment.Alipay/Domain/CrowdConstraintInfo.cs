using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CrowdConstraintInfo Data Structure.
    /// </summary>
    public class CrowdConstraintInfo : AlipayObject
    {
        /// <summary>
        /// 圈人的条件  op:表示操作符，目前支持EQ相等,GT大于,GTEQ大于等于,LT小于,LTEQ小于等于,NEQ不等,LIKE模糊匹配,IN在枚举范围内,NOTIN不在枚举范围内,BETWEEN范围比较,LEFTDAYS几天以内,RIGHTDAYS几天以外,LOCATE地理位置比较,LBS地图位置数据  tagCode:标签code，详细标签code参见附件。<a href="http://aopsdkdownload.cn-hangzhou.alipay-pub.aliyun-inc.com/doc/tags%26usecase.zip">标签信息</a>  value:标签值
        /// </summary>
        [JsonPropertyName("crowd_condition")]
        public string CrowdCondition { get; set; }

        /// <summary>
        /// 圈人名称
        /// </summary>
        [JsonPropertyName("crowd_name")]
        public string CrowdName { get; set; }

        /// <summary>
        /// 圈人约束，取值（NEWCOMER：新客人群；OFFLINE：离线人群），OFFLINE离线人群，需要传递crowd_condition圈人条件，使用方案参考crowd_condition使用说明
        /// </summary>
        [JsonPropertyName("crowd_restriction")]
        public string CrowdRestriction { get; set; }
    }
}

using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAntarchiveCustrelationCloseModel Data Structure.
    /// </summary>
    public class AlipayUserAntarchiveCustrelationCloseModel : AlipayObject
    {
        /// <summary>
        /// 关闭时间,可空.标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("close_date")]
        public string CloseDate { get; set; }

        /// <summary>
        /// 待关闭蚂蚁档案关联的客户id
        /// </summary>
        [JsonPropertyName("cust_id")]
        public string CustId { get; set; }
    }
}

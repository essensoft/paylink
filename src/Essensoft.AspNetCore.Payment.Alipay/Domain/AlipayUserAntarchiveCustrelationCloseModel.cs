using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAntarchiveCustrelationCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAntarchiveCustrelationCloseModel : AlipayObject
    {
        /// <summary>
        /// 关闭时间,可空.标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("close_date")]
        public string CloseDate { get; set; }

        /// <summary>
        /// 待关闭蚂蚁档案关联的客户id
        /// </summary>
        [JsonProperty("cust_id")]
        public string CustId { get; set; }
    }
}

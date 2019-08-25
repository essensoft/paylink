using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailInstanceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailInstanceQueryModel : AlipayObject
    {
        /// <summary>
        /// 券或者电子DM单（VOUCHER、DM），如果字段为空返回VOUCHER类型
        /// </summary>
        [JsonProperty("instance_type")]
        public string InstanceType { get; set; }

        /// <summary>
        /// 当前页码，默认1
        /// </summary>
        [JsonProperty("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 一次请求返回的数据量，1~100整数，默认10
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; }
    }
}

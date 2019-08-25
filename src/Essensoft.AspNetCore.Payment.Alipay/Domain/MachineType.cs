using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MachineType Data Structure.
    /// </summary>
    [Serializable]
    public class MachineType : AlipayObject
    {
        /// <summary>
        /// 柜内各层基础参数，json串
        /// </summary>
        [JsonProperty("attribute")]
        public string Attribute { get; set; }

        /// <summary>
        /// 货柜层数
        /// </summary>
        [JsonProperty("floor_num")]
        public long FloorNum { get; set; }

        /// <summary>
        /// 视觉货柜机型ID
        /// </summary>
        [JsonProperty("machine_type_id")]
        public string MachineTypeId { get; set; }

        /// <summary>
        /// 机型信息备注说明
        /// </summary>
        [JsonProperty("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 机型状态 (1:生效，0:下线)
        /// </summary>
        [JsonProperty("status")]
        public long Status { get; set; }

        /// <summary>
        /// 类型(0:商品库机型, 1:摆放模板机型)
        /// </summary>
        [JsonProperty("type")]
        public long Type { get; set; }
    }
}

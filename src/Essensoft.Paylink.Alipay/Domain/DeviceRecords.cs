using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// DeviceRecords Data Structure.
    /// </summary>
    public class DeviceRecords : AlipayObject
    {
        /// <summary>
        /// 设备唯一标识
        /// </summary>
        [JsonPropertyName("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 极简绑定：G1 三绑定：G3
        /// </summary>
        [JsonPropertyName("device_grade")]
        public string DeviceGrade { get; set; }

        /// <summary>
        /// 设备档案
        /// </summary>
        [JsonPropertyName("device_record_files")]
        public List<DeviceRecordFile> DeviceRecordFiles { get; set; }

        /// <summary>
        /// 设备档案拓展参数
        /// </summary>
        [JsonPropertyName("ext_params")]
        public DeviceExtParams ExtParams { get; set; }

        /// <summary>
        /// 设备序列号
        /// </summary>
        [JsonPropertyName("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 设备供应商ID
        /// </summary>
        [JsonPropertyName("supplier_id")]
        public string SupplierId { get; set; }
    }
}

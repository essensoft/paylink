using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// DeviceRecordFile Data Structure.
    /// </summary>
    public class DeviceRecordFile : AlipayObject
    {
        /// <summary>
        /// 1.直联商户三绑定必传： RECORDS_TYPE_PID(直连pid)、 RECORDS_TYPE_SHOPID(shopid); 2.间联商户三绑定必传： RECORDS_TYPE_SMID（间连smid）、 RECORDS_TYPE_PID(直连pid)、 RECORDS_TYPE_SHOPID(shopid)
        /// </summary>
        [JsonPropertyName("records_type")]
        public string RecordsType { get; set; }

        /// <summary>
        /// 与records_type对应的参数值。 如直连商户pid：2088101156429885
        /// </summary>
        [JsonPropertyName("records_value")]
        public string RecordsValue { get; set; }
    }
}

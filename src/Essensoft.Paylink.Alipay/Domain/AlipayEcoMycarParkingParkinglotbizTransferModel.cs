using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingParkinglotbizTransferModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarParkingParkinglotbizTransferModel : AlipayObject
    {
        /// <summary>
        /// 车场业务归属关系列表
        /// </summary>
        [JsonPropertyName("business_isv")]
        public List<BusinessItem> BusinessIsv { get; set; }

        /// <summary>
        /// 车场创建返回的parking_id字段
        /// </summary>
        [JsonPropertyName("parking_id")]
        public string ParkingId { get; set; }
    }
}

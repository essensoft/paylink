using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishTabInfo Data Structure.
    /// </summary>
    public class KbdishTabInfo : AlipayObject
    {
        /// <summary>
        /// 餐台所属餐区的id
        /// </summary>
        [JsonProperty("area_id")]
        public string AreaId { get; set; }

        /// <summary>
        /// 餐台创建人
        /// </summary>
        [JsonProperty("create_user")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 餐台服务费
        /// </summary>
        [JsonProperty("fee_price")]
        public string FeePrice { get; set; }

        /// <summary>
        /// 餐台座位人数
        /// </summary>
        [JsonProperty("seat_count")]
        public string SeatCount { get; set; }

        /// <summary>
        /// 餐台id
        /// </summary>
        [JsonProperty("tab_id")]
        public string TabId { get; set; }

        /// <summary>
        /// 餐台名称
        /// </summary>
        [JsonProperty("tab_name")]
        public string TabName { get; set; }

        /// <summary>
        /// 餐台序号
        /// </summary>
        [JsonProperty("tab_sort")]
        public string TabSort { get; set; }

        /// <summary>
        /// 餐台状态 empty:空闲 hold:站位  clean:清扫
        /// </summary>
        [JsonProperty("tab_tstatus")]
        public string TabTstatus { get; set; }

        /// <summary>
        /// 餐区修改人
        /// </summary>
        [JsonProperty("update_user")]
        public string UpdateUser { get; set; }
    }
}

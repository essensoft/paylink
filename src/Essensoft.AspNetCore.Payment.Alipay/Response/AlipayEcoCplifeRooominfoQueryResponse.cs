using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoCplifeRooominfoQueryResponse.
    /// </summary>
    public class AlipayEcoCplifeRooominfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 符合条件的小区房屋信息列表.
        /// </summary>
        [JsonPropertyName("room_info")]
        public List<CplifeRoomDetail> RoomInfo { get; set; }
    }
}

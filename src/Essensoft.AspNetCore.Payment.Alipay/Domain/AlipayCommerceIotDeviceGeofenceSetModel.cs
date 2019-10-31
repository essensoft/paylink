using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotDeviceGeofenceSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotDeviceGeofenceSetModel : AlipayObject
    {
        /// <summary>
        /// 地图围栏事件. 如果是createOrUpdate,则必填,如果是delete,则可不填
        /// </summary>
        [JsonProperty("fence_event")]
        public FenceEvent FenceEvent { get; set; }

        /// <summary>
        /// 操作类型.取值:createOrUpdate/delete. 表示新增或修改/删除该地理围栏事件
        /// </summary>
        [JsonProperty("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 一组地理围栏的唯一标识, 通常一条公交线路
        /// </summary>
        [JsonProperty("route_code")]
        public string RouteCode { get; set; }
    }
}

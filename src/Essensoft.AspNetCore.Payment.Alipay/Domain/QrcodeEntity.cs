using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// QrcodeEntity Data Structure.
    /// </summary>
    [Serializable]
    public class QrcodeEntity : AlipayObject
    {
        /// <summary>
        /// 桌台ID
        /// </summary>
        [JsonProperty("desk_id")]
        public string DeskId { get; set; }

        /// <summary>
        /// 二维码的ID，不传时则为删除（这时候必须有relation_id，删除该relation_id）
        /// </summary>
        [JsonProperty("qrcode_id")]
        public string QrcodeId { get; set; }

        /// <summary>
        /// 已经绑定的二维码关系ID  新增不传，修改删除传
        /// </summary>
        [JsonProperty("relation_id")]
        public string RelationId { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }
    }
}

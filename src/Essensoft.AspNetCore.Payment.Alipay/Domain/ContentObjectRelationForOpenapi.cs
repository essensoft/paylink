using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ContentObjectRelationForOpenapi Data Structure.
    /// </summary>
    [Serializable]
    public class ContentObjectRelationForOpenapi : AlipayObject
    {
        /// <summary>
        /// 对象id,如关联店铺则是shopId
        /// </summary>
        [JsonProperty("object_id")]
        public string ObjectId { get; set; }

        /// <summary>
        /// 对象类型，内容的关联对象类型。  SHOP代表店铺，  ITEM代表商品
        /// </summary>
        [JsonProperty("object_type")]
        public string ObjectType { get; set; }
    }
}

using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAntpaasRoleRelationSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAntpaasRoleRelationSaveModel : AlipayObject
    {
        /// <summary>
        /// 需要绑定的支付宝用户id
        /// </summary>
        [JsonProperty("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// true/false，若支付宝用户已被同一userSource下其他外部用户绑定，则自动删除已有关系，仅在opType=enable时有效
        /// </summary>
        [JsonProperty("alipay_user_occupied_auto_delete")]
        public bool AlipayUserOccupiedAutoDelete { get; set; }

        /// <summary>
        /// 可为enable/delete, 表示存储/删除绑定关系
        /// </summary>
        [JsonProperty("op_type")]
        public string OpType { get; set; }

        /// <summary>
        /// 外部用户id唯一标识, 例如高德用户id
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// true/false, 默认false, 若用户已被其它支付宝用户绑定，则自动删除已有关系, 仅在opType=enable时有效
        /// </summary>
        [JsonProperty("user_occupied_auto_delete")]
        public bool UserOccupiedAutoDelete { get; set; }

        /// <summary>
        /// 用户来源, 接入时会分配给接入方
        /// </summary>
        [JsonProperty("user_source")]
        public string UserSource { get; set; }
    }
}

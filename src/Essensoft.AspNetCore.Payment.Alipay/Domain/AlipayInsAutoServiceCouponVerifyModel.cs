using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsAutoServiceCouponVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsAutoServiceCouponVerifyModel : AlipayObject
    {
        /// <summary>
        /// 业务扩展数据,根据核销服务类型不同，业务相关扩展数据以json格式返回,蚂蚁根据json格式解析。
        /// </summary>
        [JsonProperty("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 蚂蚁内部券码ID,蚂蚁内部发送券时同步给服务商的唯一券码,服务商需要将蚂蚁内部券码和服务商自己的券码进行映射,引导核销阶段蚂蚁会将蚂蚁的这个券码传给服务商，服务商根据映射关系找到自己的券码进行核销,核销时需要将蚂蚁的券码也返回给蚂蚁。
        /// </summary>
        [JsonProperty("coupon_id")]
        public string CouponId { get; set; }

        /// <summary>
        /// 核销事件类型,枚举包含如下三种值(00: 预约 01: 取消预约  10: 核销 )  用于用户线下预约，取消预约，核销服务时服务商将对应的动作同步给蚂蚁，方便在卡券中展示。
        /// </summary>
        [JsonProperty("event")]
        public string Event { get; set; }

        /// <summary>
        /// 核销业务时间,服务核销的真正时间, 格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("event_date")]
        public string EventDate { get; set; }

        /// <summary>
        /// 外部业务单号,唯一,券核销时的服务商的外部业务单号,幂等字段用于控制幂等。
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 服务商券码ID, 服务商在核销用户的券码时候的唯一标识，该券码会和蚂蚁内部的券码有一一映射关系。
        /// </summary>
        [JsonProperty("sp_coupon_id")]
        public string SpCouponId { get; set; }

        /// <summary>
        /// 蚂蚁会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}

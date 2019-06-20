using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppCommonNotifySendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppCommonNotifySendModel : AlipayObject
    {
        /// <summary>
        /// 水电燃等机构为用户分配的户号
        /// </summary>
        [JsonProperty("bill_key")]
        public string BillKey { get; set; }

        /// <summary>
        /// 业务类型的缩写：  JF-缴费
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 出账机构的缩写
        /// </summary>
        [JsonProperty("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 特定通知类型可能需要提供扩展信息，用JSON字符串描述
        /// </summary>
        [JsonProperty("extend_data")]
        public string ExtendData { get; set; }

        /// <summary>
        /// 机构为用户发送通知的类型，需要与支付宝协商确定
        /// </summary>
        [JsonProperty("notify_type")]
        public string NotifyType { get; set; }

        /// <summary>
        /// 子业务类型英文名称:  ELECTRIC-电力  GAS-燃气  WATER-水
        /// </summary>
        [JsonProperty("sub_biz_type")]
        public string SubBizType { get; set; }

        /// <summary>
        /// 支付宝用户id，可空，用于特定场景下向指定用户发送通知
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}

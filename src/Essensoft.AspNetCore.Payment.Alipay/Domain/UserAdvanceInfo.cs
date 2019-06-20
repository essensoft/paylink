using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UserAdvanceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class UserAdvanceInfo : AlipayObject
    {
        /// <summary>
        /// 垫资查询结果：  0 查询成功  1 查询失败  如果返回查询失败，可重试
        /// </summary>
        [JsonProperty("consult_result")]
        public string ConsultResult { get; set; }

        /// <summary>
        /// true 代表当前时间点，支付宝停车平台准入当前用户垫资，考虑到极端情况下用户仍无法垫资，该项仅作为参考，车场服务商需自行判断用户在当前车场垫资资格。  false 代表当前时间点，支付宝停车平台不准入当前用户进行垫资
        /// </summary>
        [JsonProperty("user_alipay_parking_allow_advance")]
        public bool UserAlipayParkingAllowAdvance { get; set; }

        /// <summary>
        /// 用户在支付宝停车平台剩余的总待还金额
        /// </summary>
        [JsonProperty("user_wait_repayment_amount")]
        public string UserWaitRepaymentAmount { get; set; }

        /// <summary>
        /// 用户在支付宝停车平台总的未还垫资次数
        /// </summary>
        [JsonProperty("user_wait_repayment_order_count")]
        public long UserWaitRepaymentOrderCount { get; set; }
    }
}

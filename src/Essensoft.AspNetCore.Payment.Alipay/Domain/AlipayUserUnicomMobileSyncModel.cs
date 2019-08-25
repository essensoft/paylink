using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserUnicomMobileSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserUnicomMobileSyncModel : AlipayObject
    {
        /// <summary>
        /// 业务状态发生变更的时间戳，精确到毫秒
        /// </summary>
        [JsonProperty("gmt_status_change")]
        public long GmtStatusChange { get; set; }

        /// <summary>
        /// 联通老用户转宝卡套餐手机号，必须是联通手机号
        /// </summary>
        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 对手机号操作类型。CARD_ACTIVE:联通老用户转入宝卡套餐；CARD_CLOSE:宝卡用户转出宝卡套餐
        /// </summary>
        [JsonProperty("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 比如某种业务标准外部订单号,比如交易外部订单号，代表商户端自己订单号
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 联通资费产品名称
        /// </summary>
        [JsonProperty("product_name")]
        public string ProductName { get; set; }
    }
}

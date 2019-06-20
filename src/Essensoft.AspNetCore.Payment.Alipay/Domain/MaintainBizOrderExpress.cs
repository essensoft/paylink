using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MaintainBizOrderExpress Data Structure.
    /// </summary>
    [Serializable]
    public class MaintainBizOrderExpress : AlipayObject
    {
        /// <summary>
        /// 创建时间，物流子订单创建时间
        /// </summary>
        [JsonProperty("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 物流公司编号。支付宝支付物流公司编号。具体查看   支付宝支持物流公司编码
        /// </summary>
        [JsonProperty("express_code")]
        public string ExpressCode { get; set; }

        /// <summary>
        /// 物流单号， ISV上传商品物流单号，用于物流流水的查询。
        /// </summary>
        [JsonProperty("express_no")]
        public string ExpressNo { get; set; }

        /// <summary>
        /// 订单发货地址。记录订单发货的详细地址。省^^^市^^^区^^^详细地址。
        /// </summary>
        [JsonProperty("sender_addr")]
        public string SenderAddr { get; set; }
    }
}

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvTransactionInitializeModel Data Structure.
    /// </summary>
    public class AlipayMsaasMediarecogMmtcaftscvTransactionInitializeModel : AlipayObject
    {
        /// <summary>
        /// 商品信息列表
        /// </summary>
        [JsonPropertyName("goods_infos")]
        public List<GoodInfo> GoodsInfos { get; set; }

        /// <summary>
        /// 一键开柜链路唯一识别id
        /// </summary>
        [JsonPropertyName("req_id")]
        public string ReqId { get; set; }

        /// <summary>
        /// 标识是什么场景下的视觉识别请求
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 售卖设备编号
        /// </summary>
        [JsonPropertyName("terminal_id")]
        public string TerminalId { get; set; }

        /// <summary>
        /// 云平台请求唯一标示,保证用户请求的幂等性.
        /// </summary>
        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// 用户uid
        /// </summary>
        [JsonPropertyName("uid")]
        public string Uid { get; set; }
    }
}

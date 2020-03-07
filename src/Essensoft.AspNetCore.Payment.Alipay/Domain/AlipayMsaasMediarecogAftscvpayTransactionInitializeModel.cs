using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogAftscvpayTransactionInitializeModel Data Structure.
    /// </summary>
    public class AlipayMsaasMediarecogAftscvpayTransactionInitializeModel : AlipayObject
    {
        /// <summary>
        /// 商品信息,列表
        /// </summary>
        [JsonPropertyName("goods_infos")]
        public List<GoodInfo> GoodsInfos { get; set; }

        /// <summary>
        /// 视觉货柜机型信息
        /// </summary>
        [JsonPropertyName("machine_type")]
        public string MachineType { get; set; }

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
        /// 视觉货柜设备总层数
        /// </summary>
        [JsonPropertyName("total_floors")]
        public long TotalFloors { get; set; }

        /// <summary>
        /// 云平台请求唯一标示,保证用户请求的幂等性.
        /// </summary>
        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }
    }
}

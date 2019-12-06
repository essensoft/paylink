using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InboundOrder Data Structure.
    /// </summary>
    public class InboundOrder : AlipayObject
    {
        /// <summary>
        /// 扩展字段，json格式
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 入库业务类型，BHRK=补货入库，CGRK=采购入库，CGTHRK=采购退货入库，DDTHRK=订单退货入库，PDRK=盘点入库
        /// </summary>
        [JsonPropertyName("inbound_type")]
        public string InboundType { get; set; }

        /// <summary>
        /// 跟此入库通知单关联的外部业务订单号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 备注信息。
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 发货人信息，供货商补货必传，其他非必传
        /// </summary>
        [JsonPropertyName("sender_info_vo")]
        public SenderInfoVO SenderInfoVo { get; set; }

        /// <summary>
        /// 仓库编号
        /// </summary>
        [JsonPropertyName("warehouse_code")]
        public string WarehouseCode { get; set; }
    }
}

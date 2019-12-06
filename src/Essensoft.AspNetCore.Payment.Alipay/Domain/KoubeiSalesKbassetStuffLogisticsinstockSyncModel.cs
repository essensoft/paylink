using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiSalesKbassetStuffLogisticsinstockSyncModel Data Structure.
    /// </summary>
    public class KoubeiSalesKbassetStuffLogisticsinstockSyncModel : AlipayObject
    {
        /// <summary>
        /// 关单时间(YYYY-MM-DD HH:mm:ss)
        /// </summary>
        [JsonPropertyName("close_date")]
        public string CloseDate { get; set; }

        /// <summary>
        /// 口碑物料平台商品入库ERP号
        /// </summary>
        [JsonPropertyName("erp_code")]
        public string ErpCode { get; set; }

        /// <summary>
        /// ERP订单类型
        /// </summary>
        [JsonPropertyName("erp_order_type")]
        public string ErpOrderType { get; set; }

        /// <summary>
        /// 本次物流入库的物流单所属物流公司编号，  当前口碑仅支持一下物流公司  中国邮政： POST  浙江省邮政速递物流有限公司： ZJEMS  顺丰快递： SF  菜鸟： CAINIAO  圆通速递： YTO  宅急送快递： ZJS  中通速递： ZTO  韵达快递： YUNDA  申通快递：STO
        /// </summary>
        [JsonPropertyName("express_company_code")]
        public string ExpressCompanyCode { get; set; }

        /// <summary>
        /// 本次入库的商品快递物流单号
        /// </summary>
        [JsonPropertyName("express_no")]
        public string ExpressNo { get; set; }

        /// <summary>
        /// 入库单明细
        /// </summary>
        [JsonPropertyName("item_infos")]
        public List<InStockStuffInfo> ItemInfos { get; set; }

        /// <summary>
        /// 供应商入库号
        /// </summary>
        [JsonPropertyName("receipt_id")]
        public string ReceiptId { get; set; }

        /// <summary>
        /// 由调用方提供的一个唯一的请求ID，每一个请求对应一个id，用于实现调用幂等
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [JsonPropertyName("warehouse_code")]
        public string WarehouseCode { get; set; }
    }
}

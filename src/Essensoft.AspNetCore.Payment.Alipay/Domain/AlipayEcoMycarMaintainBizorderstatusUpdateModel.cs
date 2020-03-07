using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarMaintainBizorderstatusUpdateModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarMaintainBizorderstatusUpdateModel : AlipayObject
    {
        /// <summary>
        /// 支付宝交易流水号  如果保养订单变更状态为已支付，则必填
        /// </summary>
        [JsonPropertyName("alipay_trade_no")]
        public string AlipayTradeNo { get; set; }

        /// <summary>
        /// ISV订单业务状态文案，车主平台状态和ISV订单状态存在差异时，记录ISV对应的业务状态。
        /// </summary>
        [JsonPropertyName("biz_status_txt")]
        public string BizStatusTxt { get; set; }

        /// <summary>
        /// 行业类目标识  洗车-015；保养-016；4S-020
        /// </summary>
        [JsonPropertyName("industry_code")]
        public string IndustryCode { get; set; }

        /// <summary>
        /// 物流公司编号。支付宝支持物流公司编号。具体查看   支付宝支持物流公司编码.zip。  如果保养订单变更状态为已出库，则必填
        /// </summary>
        [JsonPropertyName("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 物流公司名称。支付宝支付物流公司名称。具体查看 支付宝支持物流公司编码.zip。  如果保养订单变更状态为已出库，则必填
        /// </summary>
        [JsonPropertyName("logistics_company")]
        public string LogisticsCompany { get; set; }

        /// <summary>
        /// 流单号， ISV上传商品物流单号，用于物流流水的查询。  如果保养订单变更状态为已出库，则必填
        /// </summary>
        [JsonPropertyName("logistics_no")]
        public string LogisticsNo { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 车主平台业务订单状态  1-未支付；  4-已关闭；  6-支付完成；  7-已出库；  8-已收货；   11-服务开始；  55-服务完成/已核销；  56-订单完成；
        /// </summary>
        [JsonPropertyName("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 支付宝账号  如果保养订单变更状态为已支付，则必填
        /// </summary>
        [JsonPropertyName("pay_account")]
        public string PayAccount { get; set; }

        /// <summary>
        /// 支付时间yyyy-MM-dd HH:mm:ss  如果保养订单变更状态为已支付，则必填
        /// </summary>
        [JsonPropertyName("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 订单发货地址。记录订单发货的详细地址。省^^^市^^^区^^^详细地址。  如果保养订单变更状态为已出库，则必填
        /// </summary>
        [JsonPropertyName("sender_addr")]
        public string SenderAddr { get; set; }
    }
}

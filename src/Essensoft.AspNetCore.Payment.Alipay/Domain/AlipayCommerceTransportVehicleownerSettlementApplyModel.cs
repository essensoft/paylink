using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportVehicleownerSettlementApplyModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportVehicleownerSettlementApplyModel : AlipayObject
    {
        /// <summary>
        /// 阿里门店编号
        /// </summary>
        [JsonPropertyName("alipay_store_id")]
        public string AlipayStoreId { get; set; }

        /// <summary>
        /// 银行追款场景数据
        /// </summary>
        [JsonPropertyName("bank_repay_data")]
        public BankRepayData BankRepayData { get; set; }

        /// <summary>
        /// 业务扣款协议号，由用户申请办理时生成并同步给外部；ETC卡号、车牌号码、OBU设备号、扣款协议号四者不能同时为空。
        /// </summary>
        [JsonPropertyName("biz_agreement_no")]
        public string BizAgreementNo { get; set; }

        /// <summary>
        /// 交易场景: HIGHWAY 高速场景; PARKING 车场停车场景; PARKING_SPACE 车位停车场景;  GAS 加油场景; BRIDGE 路桥场景; BANK_REPAY_SETTLE 银行追款;
        /// </summary>
        [JsonPropertyName("biz_scene_code")]
        public string BizSceneCode { get; set; }

        /// <summary>
        /// 业务数据json
        /// </summary>
        [JsonPropertyName("business_params")]
        public string BusinessParams { get; set; }

        /// <summary>
        /// ETC卡号；扣款协议号、车牌号码、ETC卡号和OBU设备号四者不能同时为空。
        /// </summary>
        [JsonPropertyName("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// OBU设备号；扣款协议号、车牌号码、ETC卡号和OBU设备号四者不能同时为空。
        /// </summary>
        [JsonPropertyName("device_no")]
        public string DeviceNo { get; set; }

        /// <summary>
        /// 禁用渠道,用户不可用指定渠道支付，多个渠道以逗号分割   注，与enable_pay_channels互斥   渠道列表：https://docs.open.alipay.com/common/wifww7
        /// </summary>
        [JsonPropertyName("disable_pay_channels")]
        public string DisablePayChannels { get; set; }

        /// <summary>
        /// 参与优惠计算的金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]。
        /// </summary>
        [JsonPropertyName("discountable_amount")]
        public string DiscountableAmount { get; set; }

        /// <summary>
        /// 业务扩展参数
        /// </summary>
        [JsonPropertyName("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 高速场景，该值必传
        /// </summary>
        [JsonPropertyName("highway_data")]
        public HighwaySceneData HighwayData { get; set; }

        /// <summary>
        /// 商户操作员编号
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 外部订单号,商户端唯一
        /// </summary>
        [JsonPropertyName("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 车牌颜色：   0：蓝；  1：黄；  2：黑；  3：白；  4：绿
        /// </summary>
        [JsonPropertyName("plate_color")]
        public string PlateColor { get; set; }

        /// <summary>
        /// 车牌号。仅包括省份+车牌，不包括特殊字符。
        /// </summary>
        [JsonPropertyName("plate_no")]
        public string PlateNo { get; set; }

        /// <summary>
        /// 卖家的支付宝UID 如果该值为空，则默认为商户 签约账号对应的支付宝用户ID
        /// </summary>
        [JsonPropertyName("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 结算描述信息
        /// </summary>
        [JsonPropertyName("settle_info")]
        public VehicleSettleInfo SettleInfo { get; set; }

        /// <summary>
        /// 商户门店编号
        /// </summary>
        [JsonPropertyName("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 订单标题
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 商户终端机具编号
        /// </summary>
        [JsonPropertyName("terminal_id")]
        public string TerminalId { get; set; }

        /// <summary>
        /// 该笔订单允许的最晚付款时间，逾期将关闭交易。取值范围：1m～15d。m-分钟，h-小时，d-天，1c-当天（1c-当天的情况下，无论交易何时创建，都在0点关闭）。 该参数数值不接受小数点， 如 1.5h，可转换为 90m。
        /// </summary>
        [JsonPropertyName("timeout_express")]
        public string TimeoutExpress { get; set; }

        /// <summary>
        /// 订单总金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 不参与优惠计算的金额，单位 为元，精确到小数点后两位 ，取值范围 [0.01,100000000]。如果该值 未传入，但传入了【订单总金 额】和【可打折金额】，则该 值默认为【订单总金额】-【 可打折金额】
        /// </summary>
        [JsonPropertyName("undiscountable_amount")]
        public string UndiscountableAmount { get; set; }
    }
}

using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandAutomatApplyUploadModel Data Structure.
    /// </summary>
    public class AntMerchantExpandAutomatApplyUploadModel : AlipayObject
    {
        /// <summary>
        /// 机具发货地址信息
        /// </summary>
        [JsonProperty("delivery_address")]
        public SmartAddressInfo DeliveryAddress { get; set; }

        /// <summary>
        /// 合作类型 COOPERATION_CONTRACT(新签合约机),COOPERATION_EXCLUSIVE(定制机),COOPERATION_REFORM(改造机),COOPERATION_STOCK(存量智能机),COOPERATION_OTHER(其他)
        /// </summary>
        [JsonProperty("machine_cooperation_type")]
        public string MachineCooperationType { get; set; }

        /// <summary>
        /// 机具出厂时间
        /// </summary>
        [JsonProperty("machine_delivery_date")]
        public string MachineDeliveryDate { get; set; }

        /// <summary>
        /// 机具名称，一般采用厂商名称的简称作为设备名称。8个英文字符或4个中文汉字
        /// </summary>
        [JsonProperty("machine_name")]
        public string MachineName { get; set; }

        /// <summary>
        /// 机具类型 AUTOMAT(自助售卖机),WASHING_MACHINE(洗衣机),      MASSAGE_CHAIR(按摩椅),      AIR_BLOWER(吹风机),      CRANE_MACHINE(娃娃机),      EV_CHARGER(充电桩),      SIMULATION_KTV(模拟KTV),      GAME_MACHINE(游戏机),      OTHER(其他);
        /// </summary>
        [JsonProperty("machine_type")]
        public string MachineType { get; set; }

        /// <summary>
        /// 商户的支付宝账号ID
        /// </summary>
        [JsonProperty("merchant_user_id")]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// 运营商类型 ALIPAY_MERCHANT(支付宝商家),DISTRIBUTOR(渠道商),ISV(ISV服务商),OPERATOR_MERCHANT(运营商)
        /// </summary>
        [JsonProperty("merchant_user_type")]
        public string MerchantUserType { get; set; }

        /// <summary>
        /// 机具点位地址信息
        /// </summary>
        [JsonProperty("point_position")]
        public SmartAddressInfo PointPosition { get; set; }

        /// <summary>
        /// 厂商的支付宝账号ID
        /// </summary>
        [JsonProperty("product_user_id")]
        public string ProductUserId { get; set; }

        /// <summary>
        /// 机具终端ID，由开发者生成，并需保证在开发者端不重复
        /// </summary>
        [JsonProperty("terminal_id")]
        public string TerminalId { get; set; }

        /// <summary>
        /// 机具交易号，商户在厂商淘宝门店购买的设备需要提供当时订单对应的支付宝交易号
        /// </summary>
        [JsonProperty("trade_no")]
        public string TradeNo { get; set; }
    }
}

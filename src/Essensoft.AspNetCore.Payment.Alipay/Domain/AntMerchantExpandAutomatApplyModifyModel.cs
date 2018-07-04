using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandAutomatApplyModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandAutomatApplyModifyModel : AlipayObject
    {
        /// <summary>
        /// 机具发货地址信息
        /// </summary>
        [JsonProperty("delivery_address")]
        [XmlElement("delivery_address")]
        public SmartAddressInfo DeliveryAddress { get; set; }

        /// <summary>
        /// 合作类型 COOPERATION_CONTRACT(新签合约机),COOPERATION_EXCLUSIVE(定制机),COOPERATION_REFORM(改造机),COOPERATION_STOCK(存量智能机),COOPERATION_OTHER(其他)
        /// </summary>
        [JsonProperty("machine_cooperation_type")]
        [XmlElement("machine_cooperation_type")]
        public string MachineCooperationType { get; set; }

        /// <summary>
        /// 机具出厂时间
        /// </summary>
        [JsonProperty("machine_delivery_date")]
        [XmlElement("machine_delivery_date")]
        public string MachineDeliveryDate { get; set; }

        /// <summary>
        /// 机具名称，一般采用厂商名称的简称作为设备名称。8个英文字符或4个中文汉字
        /// </summary>
        [JsonProperty("machine_name")]
        [XmlElement("machine_name")]
        public string MachineName { get; set; }

        /// <summary>
        /// 机具类型  AUTOMAT(自助售卖机),WASHING_MACHINE(洗衣机),MASSAGE_CHAIR(按摩椅),AIR_BLOWER(吹风机),CRANE_MACHINE(娃娃机),EV_CHARGER(充电桩),SIMULATION_KTV(模拟KTV),GAME_MACHINE(游戏机),JUICER(果汁机),COFFEE_MACHINE(咖啡机),WATER_PURIFIER(净水设备),SMART_CONTAINER(智能货柜),OPEN_SHELVES(开放式货架),LOTTERY_MACHINE(彩票机),OTHER(其他);
        /// </summary>
        [JsonProperty("machine_type")]
        [XmlElement("machine_type")]
        public string MachineType { get; set; }

        /// <summary>
        /// 商户的支付宝账号ID
        /// </summary>
        [JsonProperty("merchant_user_id")]
        [XmlElement("merchant_user_id")]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// 运营商类型 ALIPAY_MERCHANT(支付宝商家),DISTRIBUTOR(渠道商),ISV(ISV服务商),OPERATOR_MERCHANT(运营商)
        /// </summary>
        [JsonProperty("merchant_user_type")]
        [XmlElement("merchant_user_type")]
        public string MerchantUserType { get; set; }

        /// <summary>
        /// 机具点位地址信息
        /// </summary>
        [JsonProperty("point_position")]
        [XmlElement("point_position")]
        public SmartAddressInfo PointPosition { get; set; }

        /// <summary>
        /// 自助售卖机场景信息
        /// </summary>
        [JsonProperty("scene")]
        [XmlElement("scene")]
        public SmartAutomatScene Scene { get; set; }

        /// <summary>
        /// 机具终端ID，由开发者生成，并需保证在开发者端不重复
        /// </summary>
        [JsonProperty("terminal_id")]
        [XmlElement("terminal_id")]
        public string TerminalId { get; set; }
    }
}

using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEtcEcodataSyncModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportEtcEcodataSyncModel : AlipayObject
    {
        /// <summary>
        /// 收单方式，支付宝收单：ALIPAY;银行收单：BANK
        /// </summary>
        [JsonPropertyName("acquire_inst")]
        public string AcquireInst { get; set; }

        /// <summary>
        /// 是否代人办理订单: 代人办理 true; 本人办理 false;
        /// </summary>
        [JsonPropertyName("agent_flag")]
        public string AgentFlag { get; set; }

        /// <summary>
        /// 支付宝授权id，在用户前端授权页面同意授权之后生成
        /// </summary>
        [JsonPropertyName("agree_id")]
        public string AgreeId { get; set; }

        /// <summary>
        /// 申请类型, 货车：truck; 客车：bus
        /// </summary>
        [JsonPropertyName("apply_type")]
        public string ApplyType { get; set; }

        /// <summary>
        /// 核定载质量
        /// </summary>
        [JsonPropertyName("approved_load")]
        public string ApprovedLoad { get; set; }

        /// <summary>
        /// 车轴数
        /// </summary>
        [JsonPropertyName("axle_count")]
        public string AxleCount { get; set; }

        /// <summary>
        /// 支付宝收单协议号，支付宝收单时必传；
        /// </summary>
        [JsonPropertyName("biz_agreement_no")]
        public string BizAgreementNo { get; set; }

        /// <summary>
        /// 业务发生时间；对应order_status 几个状态的变更时间； 当order_status = CREATEED 时 biz_time 为订单创建时间；order_status = ACTIVATED时 biz_time为设备激活时间，以此类推
        /// </summary>
        [JsonPropertyName("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 品牌型号
        /// </summary>
        [JsonPropertyName("brand_model")]
        public string BrandModel { get; set; }

        /// <summary>
        /// 用户ETC卡号，同步激活状态必传；
        /// </summary>
        [JsonPropertyName("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 用户ETC OBU号
        /// </summary>
        [JsonPropertyName("device_no")]
        public string DeviceNo { get; set; }

        /// <summary>
        /// 车辆发动机号
        /// </summary>
        [JsonPropertyName("engine_no")]
        public string EngineNo { get; set; }

        /// <summary>
        /// 发行方卡名称；激活时必传
        /// </summary>
        [JsonPropertyName("etc_name")]
        public string EtcName { get; set; }

        /// <summary>
        /// 发证日期
        /// </summary>
        [JsonPropertyName("grant_date")]
        public string GrantDate { get; set; }

        /// <summary>
        /// 总质量
        /// </summary>
        [JsonPropertyName("gross_mass")]
        public string GrossMass { get; set; }

        /// <summary>
        /// 订单状态； 1、INFO_SUBMIT：信息已提交； 2、CENSOR_PASS：审核通过； 3、CENSOR_BLOCK：审核驳回； 4、DELIVERYED：已发货； 5、RECEIVED：已收货； 6、ACTIVATED：已激活； 7、UNMOUNTED：已注销； 8、ADD_BLACK：拉黑； 9、REMOVE_BLACK：解黑；
        /// </summary>
        [JsonPropertyName("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 外部业务号，对应用户该笔ETC申请单号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 外廓尺寸
        /// </summary>
        [JsonPropertyName("outline_size")]
        public string OutlineSize { get; set; }

        /// <summary>
        /// 车牌颜色, 0：蓝； 1：黄； 2：黑； 3：白； 4：绿； 5：黄绿；
        /// </summary>
        [JsonPropertyName("plate_color")]
        public string PlateColor { get; set; }

        /// <summary>
        /// 办理车牌
        /// </summary>
        [JsonPropertyName("plate_no")]
        public string PlateNo { get; set; }

        /// <summary>
        /// 注册日期
        /// </summary>
        [JsonPropertyName("register_date")]
        public string RegisterDate { get; set; }

        /// <summary>
        /// 发行方id，一般为ETC卡号前缀： "3701", "山东省"； "6201", "甘肃省"； "3201", "江苏省"； "1101", "北京"； "5301", "云南省"； "4601", "海南省"； "3301", "浙江省"； "3101", "上海"； "6101", "陕西省"； "1201", "天津"； "6501", "新疆维吾尔自治区"； "5201", "贵州省"； "3401", "安徽省"； "8201", "澳门特别行政区"； "4301", "湖南省"； "1301", "河北省"； "8101", "香港特别行政区"； "2101", "辽宁省"； "5101", "四川省"； "6401", "宁夏回族自治区"； "2201", "吉林省"； "3501", "福建省"； "4201", "湖北省"； "4401", "广东省"； "5001", "重庆"； "1401", "山西省"； "3601", "江西省"； "2301", "黑龙江省"； "6301", "青海省"； "4101", "河南省"； "7101", "台湾省"； "1501", "内蒙古自治区"； "5401", "西藏自治区"； "4501", "广西壮族自治区"；
        /// </summary>
        [JsonPropertyName("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 发行方名称；激活时必传
        /// </summary>
        [JsonPropertyName("seller_name")]
        public string SellerName { get; set; }

        /// <summary>
        /// 准牵引总质量
        /// </summary>
        [JsonPropertyName("traction_mass")]
        public string TractionMass { get; set; }

        /// <summary>
        /// 整备质量
        /// </summary>
        [JsonPropertyName("unladen_mass")]
        public string UnladenMass { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户办理ETC预留手机号，激活状态时必传；
        /// </summary>
        [JsonPropertyName("user_mobile")]
        public string UserMobile { get; set; }

        /// <summary>
        /// 核定载人数
        /// </summary>
        [JsonPropertyName("vehicle_ac")]
        public string VehicleAc { get; set; }

        /// <summary>
        /// 车主姓名
        /// </summary>
        [JsonPropertyName("vehicle_owner_name")]
        public string VehicleOwnerName { get; set; }

        /// <summary>
        /// 车辆类型，行驶证上的值，小型轿车；
        /// </summary>
        [JsonPropertyName("vehicle_type")]
        public string VehicleType { get; set; }

        /// <summary>
        /// 车辆使用性质
        /// </summary>
        [JsonPropertyName("vehicle_use_type")]
        public string VehicleUseType { get; set; }

        /// <summary>
        /// 车辆识别号，请勿乱传，会校验格式；激活状态时必传；
        /// </summary>
        [JsonPropertyName("vin")]
        public string Vin { get; set; }
    }
}

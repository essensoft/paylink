using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataAiservicePriceoptimizerGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataAiservicePriceoptimizerGetModel : AlipayObject
    {
        /// <summary>
        /// 接口版本号
        /// </summary>
        [JsonProperty("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 目前有两种 :alipay_tinyapp:小程序, app:app客户端
        /// </summary>
        [JsonProperty("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 市  城市码（例如 杭州 330100）
        /// </summary>
        [JsonProperty("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 拓展变量列表
        /// </summary>
        [JsonProperty("extend_agrs")]
        public List<MakePriceAgrs> ExtendAgrs { get; set; }

        /// <summary>
        /// 特征变量列表
        /// </summary>
        [JsonProperty("feature_args")]
        public List<MakePriceAgrs> FeatureArgs { get; set; }

        /// <summary>
        /// 活动页面来源，即用户跳转到 活动页面的前一个页面
        /// </summary>
        [JsonProperty("from")]
        public string From { get; set; }

        /// <summary>
        /// 商户Id （接入方ISV 必填）
        /// </summary>
        [JsonProperty("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 定价对象列表
        /// </summary>
        [JsonProperty("product_list")]
        public List<MakePriceCards> ProductList { get; set; }

        /// <summary>
        /// 标识定价场景 single_pay:单次支付定价 stored_value_card:储值卡
        /// </summary>
        [JsonProperty("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 接入方名称
        /// </summary>
        [JsonProperty("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 用户参与活动的业务标识，需要唯一。通过该业务标识串联用户在活动中的涉及的关键业务流程，该参数由mammoth业务端生成该id并在上述业务流程推进过程中存储记录该id。
        /// </summary>
        [JsonProperty("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// 最小定价单元ID
        /// </summary>
        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID.作为用户标识，该参数可通过alipay.user.info.share接口获取。
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}

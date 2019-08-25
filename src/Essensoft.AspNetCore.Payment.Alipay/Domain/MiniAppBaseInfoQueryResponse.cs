using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MiniAppBaseInfoQueryResponse Data Structure.
    /// </summary>
    [Serializable]
    public class MiniAppBaseInfoQueryResponse : AlipayObject
    {
        /// <summary>
        /// 小程序应用描述
        /// </summary>
        [JsonProperty("app_desc")]
        public string AppDesc { get; set; }

        /// <summary>
        /// tinyapp
        /// </summary>
        [JsonProperty("app_english_name")]
        public string AppEnglishName { get; set; }

        /// <summary>
        /// 手淘开放平台鉴权key，支付宝不需要
        /// </summary>
        [JsonProperty("app_key")]
        public string AppKey { get; set; }

        /// <summary>
        /// 小程序应用logo图标
        /// </summary>
        [JsonProperty("app_logo")]
        public string AppLogo { get; set; }

        /// <summary>
        /// 小程序名称
        /// </summary>
        [JsonProperty("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 小程序简介
        /// </summary>
        [JsonProperty("app_slogan")]
        public string AppSlogan { get; set; }

        /// <summary>
        /// 小程序类型，TINYAPP_TEMPLATE，TINYAPP_NORMAL，TINYAPP_PLUGIN
        /// </summary>
        [JsonProperty("app_sub_type")]
        public string AppSubType { get; set; }

        /// <summary>
        /// 小程序所属主体信息
        /// </summary>
        [JsonProperty("dev_id")]
        public string DevId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [JsonProperty("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 应用创建来源，alipay = 支付宝，taobao = 淘宝
        /// </summary>
        [JsonProperty("origin")]
        public string Origin { get; set; }

        /// <summary>
        /// 1：表示上线状态 0：初始化状态 -1 下架状态
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}

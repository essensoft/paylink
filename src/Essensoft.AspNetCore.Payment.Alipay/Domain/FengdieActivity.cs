using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FengdieActivity Data Structure.
    /// </summary>
    [Serializable]
    public class FengdieActivity : AlipayObject
    {
        /// <summary>
        /// H5应用的唯一id，调用alipay.marketing.tool.fengdie.activity.create接口时自动生成
        /// </summary>
        [JsonProperty("id")]
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 应用是否已在线，在H5编辑器中点击发布按钮或者过了有效期会修改状态。如：true：在线，在设置的有效期内 ；false：已下线，超过了设置的有效期范围
        /// </summary>
        [JsonProperty("is_online")]
        [XmlElement("is_online")]
        public bool IsOnline { get; set; }

        /// <summary>
        /// 创建的H5应用的名称，调用alipay.marketing.tool.fengdie.activity.create接口时作为参数传入，默认自动生成。最终显示在H5生成的URL上。URL规则为 "域名/p/f/${name}/index.html"
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// appid所属支付宝账号昵称
        /// </summary>
        [JsonProperty("nick_name")]
        [XmlElement("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// H5应用下线时间，在H5编辑器中修改
        /// </summary>
        [JsonProperty("offline_time")]
        [XmlElement("offline_time")]
        public string OfflineTime { get; set; }

        /// <summary>
        /// 唤起H5编辑器时默认展示的表单数据
        /// </summary>
        [JsonProperty("page")]
        [XmlArray("page")]
        [XmlArrayItem("fengdie_activity_page")]
        public List<FengdieActivityPage> Page { get; set; }

        /// <summary>
        /// H5应用最近一次发布时间，在H5编辑器中点击发布按钮时会修改
        /// </summary>
        [JsonProperty("publish_time")]
        [XmlElement("publish_time")]
        public string PublishTime { get; set; }

        /// <summary>
        /// H5应用被编辑的状态，如：OPEN：编辑中；COMPLETE：已完成；PRERELEASED：预览页面生成成功；PRERELEASE_FAIL：预览页面生成失败；RELEASED：已发布；RELEASE_FAIL：发布失败。在H5编辑器中点击保存、编辑完成、发布按钮时会触发。
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 创建H5应用所使用的模板包唯一id
        /// </summary>
        [JsonProperty("template_id")]
        [XmlElement("template_id")]
        public long TemplateId { get; set; }

        /// <summary>
        /// H5应用的标题，在唤起的H5编辑器中输入
        /// </summary>
        [JsonProperty("title")]
        [XmlElement("title")]
        public string Title { get; set; }
    }
}

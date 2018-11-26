using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FengdieActivityCreatePagesData Data Structure.
    /// </summary>
    [Serializable]
    public class FengdieActivityCreatePagesData : AlipayObject
    {
        /// <summary>
        /// 指定页面使用的组件，展示顺序和传入的列表顺序一致，一旦使用这个参数，模板中 {% components %} {% endcomponents %} 区域只会显示这里指定的组件
        /// </summary>
        [JsonProperty("components")]
        [XmlArray("components")]
        [XmlArrayItem("fengdie_activity_component_model")]
        public List<FengdieActivityComponentModel> Components { get; set; }

        /// <summary>
        /// 指定模板中页面采用的 schema 数据，默认为 schema 默认数据
        /// </summary>
        [JsonProperty("page_data")]
        [XmlArray("page_data")]
        [XmlArrayItem("fengdie_activity_schema_model")]
        public List<FengdieActivitySchemaModel> PageData { get; set; }

        /// <summary>
        /// 模板中页面的路径（相对于项目根目录）
        /// </summary>
        [JsonProperty("page_path")]
        [XmlElement("page_path")]
        public string PagePath { get; set; }

        /// <summary>
        /// 站点标题，默认为“未命名标题”
        /// </summary>
        [JsonProperty("title")]
        [XmlElement("title")]
        public string Title { get; set; }
    }
}

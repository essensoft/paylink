using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FengdieTemplateDetailModel Data Structure.
    /// </summary>
    [Serializable]
    public class FengdieTemplateDetailModel : AlipayObject
    {
        /// <summary>
        /// 模板 id
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// 模板包开发者，由开发者在package.json中指定
        /// </summary>
        [JsonProperty("maintainer")]
        public List<string> Maintainer { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 模板包拥有者
        /// </summary>
        [JsonProperty("owner")]
        public string Owner { get; set; }

        /// <summary>
        /// 模板包预览图，开发者在模板根目录放置的一张命名为snapshot.png的图片
        /// </summary>
        [JsonProperty("snapshot")]
        public string Snapshot { get; set; }

        /// <summary>
        /// 模板包描述，开发者在package.json里指定
        /// </summary>
        [JsonProperty("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// 模板标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 模板版本号
        /// </summary>
        [JsonProperty("ver")]
        public string Ver { get; set; }
    }
}

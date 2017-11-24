using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// FengdieTemplate Data Structure.
    /// </summary>
    public class FengdieTemplate : AlipayObject
    {
        /// <summary>
        /// 模板包唯一id，上传模板时自动生成
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// 模板包开发者，由开发者在package.json中指定
        /// </summary>
        [JsonProperty("maintainer")]
        public List<string> Maintainer { get; set; }

        /// <summary>
        /// 模板包名称，开发模板时由开发者在package.json里指定
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

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
        /// 模板包中文标题，开发者在fengdie.config.js里指定
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}

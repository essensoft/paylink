using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SignDataInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SignDataInfo : AlipayObject
    {
        /// <summary>
        /// 待签约数据编号，由外部系统定义，用于数据关联
        /// </summary>
        [JsonProperty("data_id")]
        [XmlElement("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 待签约数据名称，支持GBK编码字符
        /// </summary>
        [JsonProperty("data_name")]
        [XmlElement("data_name")]
        public string DataName { get; set; }

        /// <summary>
        /// 代签名数据类型  'DATA'   //数据原文  'FILE'    //文档索引，通过OSS空间交换  'TEMPLATE'   //文档模板
        /// </summary>
        [JsonProperty("data_type")]
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 当data_type=FILE时，制定文档类型。  'html'  //html格式文档  'pdf'   //pdf格式文档
        /// </summary>
        [JsonProperty("file_type")]
        [XmlElement("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// OSS空间中存储的文件Id
        /// </summary>
        [JsonProperty("oss_file_id")]
        [XmlElement("oss_file_id")]
        public string OssFileId { get; set; }

        /// <summary>
        /// 文档预览地址信息
        /// </summary>
        [JsonProperty("preview_url")]
        [XmlElement("preview_url")]
        public string PreviewUrl { get; set; }

        /// <summary>
        /// 文档签章列表，参考FileSignatrue
        /// </summary>
        [JsonProperty("signature_list")]
        [XmlArray("signature_list")]
        [XmlArrayItem("file_signature")]
        public List<FileSignature> SignatureList { get; set; }

        /// <summary>
        /// 文档原文内容，当data_type=DATA时必传。
        /// </summary>
        [JsonProperty("source_data")]
        [XmlElement("source_data")]
        public string SourceData { get; set; }
    }
}

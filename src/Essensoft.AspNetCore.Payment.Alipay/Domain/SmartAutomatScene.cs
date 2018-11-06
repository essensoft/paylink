using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SmartAutomatScene Data Structure.
    /// </summary>
    [Serializable]
    public class SmartAutomatScene : AlipayObject
    {
        /// <summary>
        /// 自助售货机一级场景，可取值如下：  SCHOOL  MALL  STATION  FACTORY  COMMUNITY  OFFICE  HOSPITAL  GOVERNMENT  SCENIC_SPOT  OTHERS
        /// </summary>
        [JsonProperty("level_1")]
        [XmlElement("level_1")]
        public string Level1 { get; set; }

        /// <summary>
        /// 自助售货机二级场景，可取值如下(不同的一级场景下，可取值不同，详见scene说明)：  001  002  003  004  005  006  007
        /// </summary>
        [JsonProperty("level_2")]
        [XmlElement("level_2")]
        public string Level2 { get; set; }
    }
}

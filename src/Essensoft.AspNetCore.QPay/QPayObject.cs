namespace Essensoft.AspNetCore.QPay
{
    /// <summary>
    /// 基础对象。
    /// </summary>
    public abstract class QPayObject
    {
        /// <summary>
        /// 响应原始内容
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// 响应原始参数
        /// </summary>
        public QPayDictionary Parameters { get; private set; } = new QPayDictionary();
    }
}

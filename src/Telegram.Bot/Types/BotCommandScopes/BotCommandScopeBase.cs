using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.Bot.Types.BotCommandScopes
{
    /// <summary>
    /// 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class BotCommandScopeBase
    {
        /// <summary>
        /// Unique identifier of this result
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string Type { get; private set; }

        ///  <summary>
        /// Initializes a new inline query result
        ///  </summary>
        /// <param name="type">Type of the result</param>
        protected BotCommandScopeBase(string type)
        {
            Type = type;
        }


    }
}

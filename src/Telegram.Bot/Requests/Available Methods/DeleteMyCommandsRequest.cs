using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.Bot.Types;
using Telegram.Bot.Types.BotCommandScopes;

// ReSharper disable once CheckNamespace
namespace Telegram.Bot.Requests
{
    /// <summary>
    /// Use this method to get the current list of the bot's commands. Requires no parameters. Returns array of <see cref="BotCommand"/> on success.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class DeleteMyCommandsRequest : RequestBase<BotCommand[]>
    {
        /// <summary>
        /// Optional.  Scope of the bot commands
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public BotCommandScopeBase Scope { get; }

        /// <summary>
        /// Optional. IETF language tag of the bot commands
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// Initializes a new request
        /// </summary>
        public DeleteMyCommandsRequest(BotCommandScopeBase scope = null, string languageCode = null)
            : base("deleteMyCommands")
        {
            Scope = scope;
            LanguageCode = languageCode;
        }
    }
}

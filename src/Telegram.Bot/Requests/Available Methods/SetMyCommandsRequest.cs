using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.Bot.Types;
using Telegram.Bot.Types.BotCommandScopes;

// ReSharper disable once CheckNamespace
namespace Telegram.Bot.Requests
{
    /// <summary>
    /// Use this method to change the list of the bot's commands. Returns True on success.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class SetMyCommandsRequest : RequestBase<bool>
    {
        /// <summary>
        /// A list of bot commands to be set as the list of the bot's commands. At most 100 commands can be specified.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public IEnumerable<BotCommand> Commands { get; }

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
        /// Initializes a new request with commands
        /// </summary>
        /// <param name="commands">A list of bot commands to be set</param>
        /// <param name="scope"></param>
        /// <param name="languageCode"></param>
        public SetMyCommandsRequest(IEnumerable<BotCommand> commands, BotCommandScopeBase scope = null, string languageCode = null)
            : base("setMyCommands")
        {
            Commands = commands;
            Scope = scope;
            LanguageCode = languageCode;
        }
    }
}

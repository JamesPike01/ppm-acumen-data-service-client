using Newtonsoft.Json;
using System;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    /// <summary>
    /// Metadata for a single preference key. Maps to the PREFERENCE_DEFINITION table.
    /// Definitions are seeded centrally (not per-workbook) so this DTO is intentionally
    /// excluded from <see cref="WorkbookImportPayload"/>; it's exposed by the management
    /// API for callers that need to discover available preferences and their schema.
    /// </summary>
    public class PreferenceDefinitionPayloadDto
    {
        /// <summary>Global preference key (e.g. "acumen.export.ipmdr.cost").</summary>
        [JsonProperty("preferenceKey")]
        public string? PreferenceKey { get; set; }

        /// <summary>JSON metadata: type, defaults, validation rules, allowed scopes.</summary>
        [JsonProperty("data")]
        public string? Data { get; set; }
    }

    /// <summary>
    /// A preference value at one of four scopes. Maps to the PREFERENCE_VALUE table.
    /// The (PreferenceKey, Scope, ModuleName, EntityType, EntityUid, UserUid) tuple is unique.
    /// Resolution precedence is USER → ENTITY → MODULE → APP — most-specific wins, unless a
    /// less-specific row sets <see cref="IsEnforced"/> = true (admin lock-down).
    /// </summary>
    public class PreferenceValuePayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        /// <summary>FK → <see cref="PreferenceDefinitionPayloadDto.PreferenceKey"/>.</summary>
        [JsonProperty("preferenceKey")]
        public string? PreferenceKey { get; set; }

        /// <summary>One of "APP", "MODULE", "ENTITY", "USER".</summary>
        [JsonProperty("scope")]
        public string? Scope { get; set; }

        /// <summary>Module identifier when Scope = "MODULE"; null for other scopes.</summary>
        [JsonProperty("moduleName")]
        public string? ModuleName { get; set; }

        /// <summary>Entity discriminator when Scope = "ENTITY" (e.g. "Project", "Workbook").</summary>
        [JsonProperty("entityType")]
        public string? EntityType { get; set; }

        /// <summary>Owning entity UID when Scope = "ENTITY".</summary>
        [JsonProperty("entityUid")]
        public Guid? EntityUid { get; set; }

        /// <summary>Owning user when Scope = "USER".</summary>
        [JsonProperty("userUid")]
        public Guid? UserUid { get; set; }

        /// <summary>The stored value — typically a JSON document conforming to the definition's schema.</summary>
        [JsonProperty("value")]
        public string? Value { get; set; }

        /// <summary>When true, this value overrides more-specific scopes (admin lock-down).</summary>
        [JsonProperty("isEnforced")]
        public bool IsEnforced { get; set; }
    }
}

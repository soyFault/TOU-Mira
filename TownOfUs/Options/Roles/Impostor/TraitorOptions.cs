using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TownOfUs.Roles.Impostor;

namespace TownOfUs.Options.Roles.Impostor;

public sealed class TraitorOptions : AbstractRoleOptionGroup<TraitorRole>
{
    public override string GroupName => MiraLocaleManager.Get("TownOfUsMira.Role.Traitor", "Traitor");

    [ModdedNumberOption("Mínimo de Vivos para Traidor", 3f, 15f, 1f, MiraNumberSuffixes.None, "0")]
    public float LatestSpawn { get; set; } = 5f;

    [ModdedToggleOption("No aparece si hay Neutral Asesino")]
    public bool NeutralKillingStopsTraitor { get; set; } = false;

    [ModdedToggleOption("Desactiva Roles Impostor Existentes")]
    public bool RemoveExistingRoles { get; set; } = true;

    public ModdedEnumOption TraitorGuess { get; set; } = new(" Debe Ser Adivinado Como", (int)CacheRoleGuess.ActiveOrCachedRole, typeof(CacheRoleGuess), ["Traidor", "Nuevo Rol", "Traidor o Nuevo Rol"]);

    public ModdedToggleOption TraitorCanAssassin { get; } =
        new("Puede Adivinar", true);
}
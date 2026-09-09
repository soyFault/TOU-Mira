using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.Utilities;
using TownOfUs.Roles.Impostor;

namespace TownOfUs.Options.Roles.Impostor;

public sealed class HypnotistOptions : AbstractRoleOptionGroup<HypnotistRole>
{
    public override string GroupName => MiraLocaleManager.Get("TownOfUsMira.Role.Hypnotist", "Hypnotist");

    [ModdedNumberOption("Recarga de Hipnotizar", 5f, 120f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float HypnotiseCooldown { get; set; } = 25f;

    [ModdedToggleOption("Puede Matar")]
    public bool HypnoKill { get; set; } = true;
}
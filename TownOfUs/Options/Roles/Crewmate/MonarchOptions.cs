using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TownOfUs.Roles.Crewmate;

namespace TownOfUs.Options.Roles.Crewmate;

public sealed class MonarchOptions : AbstractRoleOptionGroup<MonarchRole>
{
    public override string GroupName => MiraLocaleManager.Get("TownOfUsMira.Role.Monarch", "Monarch");

    [ModdedNumberOption("Recarga de Investir", 5f, 30f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float KnightCooldown { get; set; } = 20f;

    [ModdedNumberOption("Máx Caballeros", 0f, 15f, 1f, MiraNumberSuffixes.None, "0", zeroInfinity: true)]
    public float MaxKnights { get; set; } = 3f;
    [ModdedNumberOption("Votos por Caballero", 1f, 5f, 1f, MiraNumberSuffixes.None, "0")]
    public float VotesPerKnight { get; set; } = 1f;
    [ModdedNumberOption("Retraso de Investir (Cancelable)", 1f, 10f, 1f, MiraNumberSuffixes.Seconds)]
    public float KnightDelay { get; set; } = 3f;

    [ModdedToggleOption("Reveal Caballeros en Reunión")]
    public bool RevealAtMeeting { get; set; } = false;

    [ModdedToggleOption("Mostrar Votos de Caballero")]
    public bool ShowKnightedVotes { get; set; } = true;

    [ModdedToggleOption("Permitir en Ronda 1")]
    public bool FirstRoundUse { get; set; } = false;
    [ModdedToggleOption("Avisar si muere un Caballero")]
    public bool InformWhenKnightDies { get; set; } = true;

    [ModdedToggleOption("Caballeros Tripulantes dan Inmunidad")]
    public bool CrewKnightsGrantKillImmunity { get; set; } = true;
}

public enum ProtectionFlash
{
    Configurable,
    NoFlash,
    Cleric,
    Medic,
    Mercenary,
    Warden
}
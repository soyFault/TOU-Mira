using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.Utilities;
using TownOfUs.Roles.Impostor;

namespace TownOfUs.Options.Roles.Impostor;

public sealed class ScavengerOptions : AbstractRoleOptionGroup<ScavengerRole>
{
    public override string GroupName => MiraLocaleManager.Get("TownOfUsMira.Role.Scavenger", "Scavenger");

    [ModdedNumberOption("Duración de Carroñeo", 5f, 120f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float ScavengeDuration { get; set; } = 25f;

    [ModdedNumberOption("Aumento de Duración por Muerte", 5f, 15f, 0.5f, MiraNumberSuffixes.Seconds)]
    public float ScavengeIncreaseDuration { get; set; } = 10f;

    [ModdedNumberOption("Recarga de Muerte en Carroñeo", 5f, 15f, 0.5f, MiraNumberSuffixes.Seconds)]
    public float ScavengeCorrectKillCooldown { get; set; } = 10f;

    [ModdedNumberOption("Multiplicador de Recarga de Muerte Incorrecta", 1.25f, 5f, 0.25f, MiraNumberSuffixes.Multiplier)]
    public float ScavengeIncorrectKillCooldown { get; set; } = 3f;
}
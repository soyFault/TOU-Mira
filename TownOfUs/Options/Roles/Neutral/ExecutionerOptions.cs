using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using TownOfUs.Roles.Neutral;

namespace TownOfUs.Options.Roles.Neutral;

public sealed class ExecutionerOptions : AbstractRoleOptionGroup<ExecutionerRole>
{
    public override string GroupName => MiraLocaleManager.Get("TownOfUsMira.Role.Executioner", "Executioner");

    [ModdedEnumOption("TouOptionExecutionerBecomesTargetDeath", typeof(BecomeOptions), ["MiraApi.RoleTeam.Crewmate", "TownOfUsMira.Role.Amnesiac", "TownOfUsMira.Role.Survivor", "TownOfUsMira.Role.Mercenary", "TownOfUsMira.Role.Jester"])]
    public BecomeOptions OnTargetDeath { get; set; } = BecomeOptions.Jester;

    [ModdedToggleOption("Puede usar botón")]
    public bool CanButton { get; set; } = true;

    [ModdedEnumOption("Si gana", typeof(ExeWinOptions), ["Termina Partida", "Tortura", "Nada"])]
    public ExeWinOptions ExeWin { get; set; } = ExeWinOptions.Torments;

    public ModdedToggleOption ExeAnonymizeWin { get; set; } =
        new("TouOptionNeutAnonymousVictoryWin", false)
    {
        Visible = () => OptionGroupSingleton<ExecutionerOptions>.Instance.ExeWin is not ExeWinOptions.EndsGame
    };
}

public enum ExeWinOptions
{
    EndsGame,
    Torments,
    Nothing
}
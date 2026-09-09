using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TownOfUs.Roles.Neutral;

namespace TownOfUs.Options.Roles.Neutral;

public sealed class MedusaOptions : AbstractRoleOptionGroup<MedusaRole>
{
    public override string GroupName => MiraLocaleManager.Get("TownOfUsMira.Role.Medusa", "Medusa");

    [ModdedNumberOption("TouOptionMedusaPetrifyCooldown", 5f, 120f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float KillCooldown { get; set; } = 25f;

    [ModdedNumberOption("Tiempo para volverse piedra", 5f, 20f, 1f, MiraNumberSuffixes.Seconds)]
    public float StoneDelay { get; set; } = 10f;

    [ModdedNumberOption("Tiempo para romperse", 12.5f, 60f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float StoneCompletion { get; set; } = 20f;

    public ModdedToggleOption StoneGazeAvailable { get; set; } = new("Puede usar Mirada", true);
    
    public ModdedNumberOption StoneGazeCooldown { get; set; } = new("Recarga de Mirada", 35f, 5f, 120f, 2.5f, MiraNumberSuffixes.Seconds)
    {
        Visible = () => OptionGroupSingleton<MedusaOptions>.Instance.StoneGazeAvailable
    };
    
    public ModdedNumberOption StoneGazeDuration { get; set; } = new("Duración de Mirada", 10f, 5f, 20f, 2.5f, MiraNumberSuffixes.Seconds)
    {
        Visible = () => OptionGroupSingleton<MedusaOptions>.Instance.StoneGazeAvailable
    };
    
    public ModdedNumberOption StoneGazeUses { get; set; } = new("Usos de Mirada", 3f, 1f, 10f, 1f, MiraNumberSuffixes.None)
    {
        Visible = () => OptionGroupSingleton<MedusaOptions>.Instance.StoneGazeAvailable
    };

    [ModdedToggleOption("TouOptionMedusaCanVent")]
    public bool CanVent { get; set; } = false;
}
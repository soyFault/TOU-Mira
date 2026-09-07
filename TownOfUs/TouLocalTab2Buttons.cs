using BepInEx.Configuration;
using InnerNet;
using MiraAPI;
using MiraAPI.Hud;
using MiraAPI.LocalSettings.Attributes;
using TownOfUs.Buttons;
using TownOfUs.Patches.Misc;
using TownOfUs.Roles;

namespace TownOfUs;

public class TouLocalTabButtons(ConfigFile config) : LocalSettingsTab(config)
{
    public override string TabName => "IU / UX";
    protected override bool ShouldCreateLabels => true;

    public override void OnOptionChanged(ConfigEntryBase configEntry)
    {
        base.OnOptionChanged(configEntry);
        if (configEntry == OffsetButtonsToggle)
        {
            if ((AmongUsClient.Instance.GameState != InnerNetClient.GameStates.Started &&
                 !TutorialManager.InstanceExists) || !PlayerControl.LocalPlayer || !PlayerControl.LocalPlayer.Data ||
                PlayerControl.LocalPlayer.Data.Role == null || !ShipStatus.Instance)
            {
                return;
            }

            var role = PlayerControl.LocalPlayer.Data.Role;

            var fakeVent = CustomButtonSingleton<FakeVentButton>.Instance;
            fakeVent.SetActive(fakeVent.Enabled(role), role);
            if (role is not ITownOfUsRole touRole)
            {
                return;
            }

            touRole.OffsetButtons();
        }
        else if (configEntry == ZoomOnBottomRow)
        {
            MiraApiSettings.SetUpButtonPositions();
        }
        else if (configEntry == ModStampPlacement)
        {
            ModStampPatch.StampPlacement = ModStampPlacement.Value;
        }
    }

    public override LocalSettingTabAppearance TabAppearance => new()
    {
        TabIcon = TouAssets.LocalButtons,
        HideIconOnHover = false,
    };

    [LocalToggleSetting]
    public ConfigEntry<bool> ZoomOnBottomRow { get; private set; } =
        config.Bind("IU / Visuales", "ZoomOnBottomRow", false);

    [LocalToggleSetting]
    public ConfigEntry<bool> ShowShieldHudToggle { get; private set; } =
        config.Bind("IU / Visuales", "ShowShieldHud", true);

    [LocalToggleSetting]
    public ConfigEntry<bool> ShowBasicAssassinOnHud { get; private set; } =
        config.Bind("IU / Visuales", "ShowBasicAssassinOnHud", true);

    [LocalEnumSetting(names: ["ModStampTopLeft", "ModStampTopRight", "ModStampBottomLeft", "ModStampBottomRight"])]
    public ConfigEntry<ModStampLocation> ModStampPlacement { get; private set; } =
        config.Bind("IU / Visuales", "ModStampPlacement", ModStampLocation.TopRight);

    [LocalToggleSetting]
    public ConfigEntry<bool> PreciseCooldownsToggle { get; private set; } =
        config.Bind("Habilidades", "PreciseCooldowns", true);

    [LocalToggleSetting]
    public ConfigEntry<bool> OffsetButtonsToggle { get; private set; } =
        config.Bind("Habilidades", "OffsetButtons", false);
}

public enum ModStampLocation
{
    TopLeft,
    TopRight,
    BottomLeft,
    BottomRight
}
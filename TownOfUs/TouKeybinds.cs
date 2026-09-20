using Rewired;

namespace TownOfUs;

[RegisterCustomKeybinds]
public static class TouKeybinds
{
    /// <summary>
    /// Gets the keybind for opening the in-game wiki.
    /// </summary>
    public static MiraKeybind Wiki { get; } = new("Abrir Wiki", KeyboardKeyCode.F1);

    /// <summary>
    /// Gets the keybind for zooming in.
    /// </summary>
    public static MiraKeybind ZoomIn { get; } = new("Acercar Zoom", KeyboardKeyCode.Equals);

    /// <summary>
    /// Gets the keybind for zooming in.
    /// </summary>
    public static MiraKeybind ZoomInKeypad { get; } = new("Acercar Zoom (Alt)", KeyboardKeyCode.KeypadPlus);

    /// <summary>
    /// Gets the keybind for zooming out.
    /// </summary>
    public static MiraKeybind ZoomOut { get; } = new("Alejar Zoom", KeyboardKeyCode.Minus);

    /// <summary>
    /// Gets the keybind for zooming out.
    /// </summary>
    public static MiraKeybind ZoomOutKeypad { get; } = new("Alejar Zoom (Alt)", KeyboardKeyCode.KeypadMinus);

    /// <summary>
    /// Gets the keybind for moving up as ControlRole.
    /// </summary>
    public static MiraKeybind ControlRolePrimaryUp { get; } = new("Mover Rol de Control Arriba", KeyboardKeyCode.W, exclusive: false);

    /// <summary>
    /// Gets the keybind for moving left as ControlRole.
    /// </summary>
    public static MiraKeybind ControlRolePrimaryLeft { get; } = new("Mover Rol de Control Izquierda", KeyboardKeyCode.A, exclusive: false);

    /// <summary>
    /// Gets the keybind for moving down as ControlRole.
    /// </summary>
    public static MiraKeybind ControlRolePrimaryDown { get; } = new("Mover Rol de Control Abajo", KeyboardKeyCode.S, exclusive: false);

    /// <summary>
    /// Gets the keybind for moving right as ControlRole.
    /// </summary>
    public static MiraKeybind ControlRolePrimaryRight { get; } = new("Mover Rol de Control Derecha", KeyboardKeyCode.D, exclusive: false);

    /// <summary>
    /// Gets the keybind for moving up as the ControlRole's Victim.
    /// </summary>
    public static MiraKeybind ControlRoleSecondaryUp { get; } = new("Mover Objetivo Controlado Arriba", KeyboardKeyCode.UpArrow, exclusive: false);

    /// <summary>
    /// Gets the keybind for moving left as the ControlRole's Victim.
    /// </summary>
    public static MiraKeybind ControlRoleSecondaryLeft { get; } = new("Mover Objetivo Controlado Izquierda", KeyboardKeyCode.LeftArrow, exclusive: false);

    /// <summary>
    /// Gets the keybind for moving down as the ControlRole's Victim.
    /// </summary>
    public static MiraKeybind ControlRoleSecondaryDown { get; } = new("Mover Objetivo Controlado Abajo", KeyboardKeyCode.DownArrow, exclusive: false);

    /// <summary>
    /// Gets the keybind for moving right as the ControlRole's Victim.
    /// </summary>
    public static MiraKeybind ControlRoleSecondaryRight { get; } = new("Mover Objetivo Controlado Derecha", KeyboardKeyCode.RightArrow, exclusive: false);
}

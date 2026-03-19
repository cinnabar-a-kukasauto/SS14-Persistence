using Content.Shared.Damage.Systems;
using Content.Shared.FixedPoint;
using Robust.Shared.GameStates;

namespace Content.Shared.Damage.Components;

[RegisterComponent, NetworkedComponent, Access(typeof(SharedGodmodeSystem))]
public sealed partial class GodmodeComponent : Component
{
    [DataField("wasMovedByPressure")]
    public bool WasMovedByPressure;
<<<<<<< HEAD

    [DataField("oldDamage")]
    public DamageSpecifier? OldDamage = null;

    [DataField] public Dictionary<string, FixedPoint2>? DamageDictCopy { get; set; } = new();

=======
>>>>>>> 6a675126ad848468cfce6f538545d77ed5e7fea9
}

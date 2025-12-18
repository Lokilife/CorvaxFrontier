using Content.Shared.Roles;
using Robust.Shared.Prototypes;

namespace Content.Server._Forge.AutoSalarySystem;

[RegisterComponent]
public sealed partial class AutoSalaryComponent : Component
{
    [DataField]
    public TimeSpan LastSalaryAt = TimeSpan.Zero;

    [DataField]
    public ProtoId<JobPrototype>? Job;
}

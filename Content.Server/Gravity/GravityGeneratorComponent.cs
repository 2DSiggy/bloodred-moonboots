using Content.Server.StationEvents.Events;
using Content.Shared.Gravity;
using Content.Shared.Construction.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;

namespace Content.Server.Gravity
{
    [RegisterComponent]
    [Access(typeof(GravityGeneratorSystem))]
    public sealed partial class GravityGeneratorComponent : SharedGravityGeneratorComponent
    {
        [DataField]
        public float LightRadiusMin;
        [DataField]
        public float LightRadiusMax;
        [DataField]
        public float MaxMass;
        [DataField]
        public bool IsMini;

        /// <summary>
        /// Is the gravity generator currently "producing" gravity?
        /// </summary>
        [ViewVariables]
        public bool GravityActive = false;
    }
}

using System.Collections.Generic;
using Sandbox.Game;
using Sandbox.ModAPI;
using VRage.Game;
using VRage.Game.Components;
using VRage.Game.ModAPI;
using VRageMath;


namespace klime.Experimental
{
    [MySessionComponentDescriptor(MyUpdateOrder.AfterSimulation)]
    public class Experimental : MySessionComponentBase
    {
        public override void Init(MyObjectBuilder_SessionComponent sessionComponent)
        {
        }

        public override void UpdateAfterSimulation()
        {

        }
        protected override void UnloadData()
        {

        }
    }
}
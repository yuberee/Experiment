using Sandbox;

public partial class Seal : AnimEntity
{

	public override void Spawn()
	{

		base.Spawn();

		SetModel( "models/seal/seal.vmdl" );
		SetupPhysicsFromModel( PhysicsMotionType.Static );

	}

	[Event.Tick.Client]
	public void Tick()
	{

		SetAnimParameter( "Honk", true );

	}

}

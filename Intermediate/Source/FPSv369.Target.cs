using UnrealBuildTool;

public class FPSv369Target : TargetRules
{
	public FPSv369Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("FPSv369");
	}
}

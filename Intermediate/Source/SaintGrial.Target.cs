using UnrealBuildTool;

public class SaintGrialTarget : TargetRules
{
	public SaintGrialTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("SaintGrial");
	}
}
